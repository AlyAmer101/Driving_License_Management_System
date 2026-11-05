using DVLD.Applications.Manage_Driving_Licenses_Applications.Schedule_Tests.Vision_Test;
using DVLD.Applications.Schedule_Tests.Vision_Test;
using DVLD.General_Classes;
using DVLD.Properties;
using DVLD___BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Applications.Schedule_Tests
{
    public partial class frmTestAppointments : Form
    {
        

        public frmTestAppointments(int AppID, int LDLAppID)
        {
            InitializeComponent();

            ApplicationID = AppID;
            this.LDLAppID = LDLAppID;
        }


        //! My Methods


        int ApplicationID = -1;
        int LDLAppID = -1;
        int PassedTests = 0;
        string ClassName = "";
        int LicenseClassID = -1;

        public int TestAppointmentId
        {
            get
            {
                if (dgvAppointments.CurrentRow != null && dgvAppointments.CurrentRow.Index != -1)
                {
                    return Convert.ToInt32(dgvAppointments.CurrentRow.Cells[0].Value);
                }
                return -1;
            }
        }
        public int LockStatus
        {
            get
            {
                if (dgvAppointments.Rows.Count > 0)
                    return Convert.ToInt32(dgvAppointments.CurrentRow.Cells[4].Value);
                else
                    return (int)clsUtility.enTestAppointmentLockStatus.Active;
            }
        }
        public DateTime TestAppointmentDate
        {
            get
            {
                return Convert.ToDateTime(dgvAppointments.CurrentRow.Cells[2].Value);
            }
        }

        private void frmScheduleVisionTest_Load(object sender, EventArgs e)
        {
            this.PassedTests = clsLocalDrivingLicenseApplications.GetPassedTestsCountByLDLAppID(LDLAppID);
            this.ClassName = clsLocalDrivingLicenseApplications.GetLicenseClassName(LDLAppID);
            this.LicenseClassID = Convert.ToInt32(ClassName[6].ToString());

            // TODO: This line of code loads data into the 'dS_TestAppointments.TestAppointments_View' table. You can move, or remove it, as needed.
            this.testAppointments_ViewTableAdapter.Fill(this.dS_TestAppointments.TestAppointments_View);

            clsGlobalSettings.NormalizeForm(this);
            clsUtility.HandleFormWithActiveTestType(pbFormLogo, FormTitle);

            testAppointmentsViewBindingSource.Filter = $"localDrivingLicenseApplicationID = {LDLAppID} and testTypeID = {(int)clsGlobalSettings.CurrentActiveTestType}";
            testAppointmentsViewBindingSource.Sort = "testAppointmentID DESC";
            
            RefreshDate();
        }

        void ScheduleNewTest()
        {
            int ResultOfLastVisionTest = clsPersonTestsInfo.GetResultOfLastVisionTestByPersonID(ucApplicationBasicInfo2.ApplicationPersonID, LicenseClassID, (int)clsGlobalSettings.CurrentActiveTestType);
            int LockStautes = (int)clsUtility.enTestAppointmentLockStatus.Active;

            if (ResultOfLastVisionTest == (int)clsUtility.enTestResult.Passed)
            {
                clsUtility.ErorrMessage("This Person already passed this test before, you can only retake failed test.", "Not Allowed");
                return;
            }
            else if (ResultOfLastVisionTest == (int)clsUtility.enTestResult.Failed)
            {
                Form frm = new Vision_Test.frmScheduleTest(LDLAppID, ClassName, LockStautes, TestAppointmentId, TestAppointmentDate, clsUtility.enVisionTestMode.Retake);

                frm.ShowDialog();
                RefreshDate();
            }
            else
            {
                Form frm = new Vision_Test.frmScheduleTest(LDLAppID, ClassName, LockStautes);
                
                frm.ShowDialog();
                RefreshDate();
            }

        }

        void RefreshDate()
        {
            PassedTests = clsLocalDrivingLicenseApplications.GetPassedTestsCountByLDLAppID(LDLAppID);

            // TODO: This line of code loads data into the 'dsTestAppointments.TestAppointments_View' table. You can move, or remove it, as needed.
            this.testAppointments_ViewTableAdapter.Fill(this.dS_TestAppointments.TestAppointments_View);

            ucApplicationBasicInfo2.LoadApplicationInfo(ApplicationID);
            ucDrivingLicenseApplicationInfo2.LoadLDLApplicationInfo(LDLAppID);

            labRecordCount.Text = dgvAppointments.Rows.Count.ToString();

            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.ClearSelection();

                dgvAppointments.Rows[0].Selected = true;
            } 
         

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments.IsLDLAppHasActiveAppointments(LDLAppID))
            {
                clsUtility.ErorrMessage("Person Already have an active appointment for this test. You cannot add new appointment.");

                return;
            }

            ScheduleNewTest();

            RefreshDate();
        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ResultOfLastVisionTest = clsPersonTestsInfo.GetResultOfLastVisionTestByPersonID(ucApplicationBasicInfo2.ApplicationPersonID, LicenseClassID, (int)clsGlobalSettings.CurrentActiveTestType);
            clsUtility.enVisionTestMode Mode = clsUtility.enVisionTestMode.Edit;

            if (ResultOfLastVisionTest == (int)clsUtility.enTestResult.Failed)
                Mode = clsUtility.enVisionTestMode.Edit_Retake;

            Form frm = new Vision_Test.frmScheduleTest(LDLAppID, ClassName, LockStatus, TestAppointmentId, TestAppointmentDate, Mode);

            
            frm.ShowDialog();
            RefreshDate();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form frm = new frmTakeTest(LDLAppID, ClassName, TestAppointmentDate, TestAppointmentId);

            frm.ShowDialog();
            RefreshDate();
        }

        private void cmsAppointments_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAppointments.Rows.Count == 0)
            {
                takeTestToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                return;
            }
            else
            {
                takeTestToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
            }

            int LockedStatus = Convert.ToInt32(dgvAppointments.CurrentRow.Cells[4].Value);

            if (LockedStatus == (int)clsUtility.enTestAppointmentLockStatus.Locked)
                takeTestToolStripMenuItem.Enabled = false;
            else
                takeTestToolStripMenuItem.Enabled = true;


        }

        private void ucDrivingLicenseApplicationInfo2_Load(object sender, EventArgs e)
        {

        }
    }
}
