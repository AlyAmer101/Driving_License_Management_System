using DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses;
using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Issue_New_Driving_License;
using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_License;
using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History;
using DVLD.Applications.Schedule_Tests;
using DVLD.General_Classes;
using DVLD.Licenses;
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

namespace DVLD.Applications.Manage_Driving_Licenses_Applications
{
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        //! Starting Methods
        public frmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);

            cbLDLAppFilter.SelectedIndex = 0;
        }

        private void frmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLocalDrivingLicenseApplications.LocalDrivingLicenseApplications_View' table. You can move, or remove it, as needed.
            ReLoadDgv();
        }


        //! My Methods
        enum enLDLAppsFilter { None, LDL_AppID, NationalNo, FullName, Status }

        int LDL_AppID
        {
            get
            {
                return (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            }
        }

        int ApplicationID
        {
            get
            {
                return clsLocalDrivingLicenseApplications.GetAppID_By_LDLAppID(LDL_AppID);
            }
        }

        string NationalNo
        {
            get
            {
                return (string)dgvLDLApps.CurrentRow.Cells[2].Value;
            }
        }


        void ReLoadDgv()
        {
            this.localDrivingLicenseApplications_ViewTableAdapter.Fill(this.dsLocalDrivingLicenseApplications.LocalDrivingLicenseApplications_View);
            labRecordCount.Text = dgvLDLApps.Rows.Count.ToString();
        }

        // String Filter
        void _dgvLDL_AppsFilter(string ColumnName, string FilterValue)
        {
            localDrivingLicenseApplicationsViewBindingSource.Filter = $"{ColumnName} LIKE '{FilterValue}%'";
        }

        // Int Filter
        void _dgvLDL_AppsFilter(string ColumnName, int FilterValue)
        {
            localDrivingLicenseApplicationsViewBindingSource.Filter = $"{ColumnName} = '{FilterValue}'";
        }

        void ApplyFilter()
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text) && tbFilterValue.Visible)
            {
                localDrivingLicenseApplicationsViewBindingSource.Filter = "";
                return;
            }


            string FilterValue = tbFilterValue.Text;

            switch (cbLDLAppFilter.SelectedIndex)
            {
                case (int)enLDLAppsFilter.None:

                    localDrivingLicenseApplicationsViewBindingSource.Filter = "";
                    break;

                case (int)enLDLAppsFilter.LDL_AppID:

                    if (int.TryParse(FilterValue, out int LDL_AppID))
                        _dgvLDL_AppsFilter("LocalDrivingLicenseApplicationID", LDL_AppID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enLDLAppsFilter.NationalNo:

                    _dgvLDL_AppsFilter("NationalNo", FilterValue);

                    break;

                case (int)enLDLAppsFilter.FullName:

                    _dgvLDL_AppsFilter("FullName", FilterValue);

                    break;

                case (int)enLDLAppsFilter.Status:

                    _dgvLDL_AppsFilter("Status", FilterValue);

                    break;

            }



        }

        void DefaultItemsEnabelingOfCmcLDLApps_Handeler()
        {
            scheduleTestsToolStripMenuItem.Enabled = true;
                                        cmcItem_VisionTest.Enabled = false;
                                        cmcItem_WrittenTest.Enabled = false;
                                        cmcItem_StreetTest.Enabled = false;

            showApplicationDetailsToolStripMenuItem.Enabled = true;
            editApplicationToolStripMenuItem.Enabled = true;
            deleteApplicationToolStripMenuItem.Enabled = true;
            cancelApplicationToolStripMenuItem.Enabled = true;
            issuDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
        }
        void OpenAllTests()
        {
            scheduleTestsToolStripMenuItem.Enabled = true;

            cmcItem_VisionTest.Enabled = true;
            cmcItem_WrittenTest.Enabled = true;
            cmcItem_StreetTest.Enabled = true;
            issuDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
        }

        void ScheduleTest(clsUtility.enTestTypeIDs TestType)
        {
            clsGlobalSettings.CurrentActiveTestType = TestType;

            Form frm = new frmTestAppointments(ApplicationID, LDL_AppID); 

            frm.ShowDialog();
            ReLoadDgv();
        }

        void HandleEnablingTests()
        {
            switch ((int)dgvLDLApps.CurrentRow.Cells[5].Value) // Passed Tests
            {

                case 0:

                    cmcItem_VisionTest.Enabled = true;
                    break;

                case 1:

                    cmcItem_WrittenTest.Enabled = true;
                    break;

                case 2:

                    cmcItem_StreetTest.Enabled = true;
                    break;

                case 3:

                    scheduleTestsToolStripMenuItem.Enabled = false;
                    issuDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                    break;

            }
        }

        void HandleEnablingItemsWithCompletedApps()
        {
            showLicenseToolStripMenuItem.Enabled = true;
            showApplicationDetailsToolStripMenuItem.Enabled = true;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            editApplicationToolStripMenuItem.Enabled = false;
            scheduleTestsToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;
            deleteApplicationToolStripMenuItem.Enabled = false;
            issuDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        }
       
        void HandleEnablingItemsWithCancelledApps()
        {
            showApplicationDetailsToolStripMenuItem.Enabled = true;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            deleteApplicationToolStripMenuItem.Enabled = false;
            editApplicationToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            scheduleTestsToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;
            issuDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        }

        void HandleEnablingItems()
        {
            string AppStatus = (string)dgvLDLApps.CurrentRow.Cells[6].Value;

            //! Reset Enabled Itmes
            DefaultItemsEnabelingOfCmcLDLApps_Handeler();

            HandleEnablingTests();

            if (AppStatus == "Completed")
            {
                HandleEnablingItemsWithCompletedApps();
            }
            else if (AppStatus == "Cancelled")
            {
                HandleEnablingItemsWithCancelledApps();
            }

        }

        void UpdateCurrentPersonID()
        {
            clsGlobalSettings.CurrentPersonId = clsPeople.GetPersonIdBy_LDLAppID(LDL_AppID);
        }
        
        void ResetCurrentPersonID()
        {
            clsGlobalSettings.CurrentPersonId = -1;
        }

        //! Healper Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewLocalDrivingLicense();

            frm.ShowDialog();
            ReLoadDgv();

        }

        private void cbLDLAppFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLDLAppFilter.SelectedIndex == (int)enLDLAppsFilter.None)
                tbFilterValue.Visible = false;
            else
                tbFilterValue.Visible = true;

        }

        private void tbSearcherValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }


        private void cmsLDL_Apps_Opening(object sender, CancelEventArgs e)
        {

            HandleEnablingItems();
        }

        private void dgvLDLApps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void scheduleTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsUtility.enTestTypeIDs.VisionTest);
        }

        private void cmcItem_WrittenTest_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsUtility.enTestTypeIDs.WrittenTest);
        }

        private void cmcItem_StreetTest_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsUtility.enTestTypeIDs.StreetTest);
        }

        private void issuDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCurrentPersonID();

            Form frm = new frmIssueDrivingLicenseForFirstTime(ApplicationID, LDL_AppID);

            frm.ShowDialog();
            ReLoadDgv();

            ResetCurrentPersonID();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLocalDrivingLicenseApplications.GetLicenseID(LDL_AppID);

            Form frm = new frmShowDriverLicenseInfo(LicenseID);

            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCurrentPersonID();

            Form frm = new frmShowPersonLicenseHistory(clsGlobalSettings.CurrentPersonId);

            frm.ShowDialog();

            ResetCurrentPersonID();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCurrentPersonID();

            Form frm = new frmAddNewLocalDrivingLicense(clsGlobalSettings.CurrentPersonId, LDL_AppID);


            frm.ShowDialog();
            ReLoadDgv();

            ResetCurrentPersonID();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplications.UpdateApplicationStatus(LDL_AppID, (int)clsUtility.enApplicationStatus.Canceled);
            ReLoadDgv();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUtility.QuestionMessage("Are you sure you want to delete this Application?") != DialogResult.Yes)
                return;

            if (clsLocalDrivingLicenseApplications.IsApplicationDeletable(LDL_AppID))
            {
                if (clsLocalDrivingLicenseApplications.DeleteApplication(LDL_AppID))
                    clsUtility.InfoMessage("Application Deleted Successfully.");
                else
                    clsUtility.ErorrMessage("Failed To Delete Application.");
            }
            else
                    clsUtility.ErorrMessage("You Cannot Delete This Application Because It's Linked To Other Processes.");
            
            
            ReLoadDgv();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLocalDrivingLicenseApplicationInfo(ApplicationID, LDL_AppID);
            frm.ShowDialog();
        }

    }
}
