using DVLD.General_Classes;
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

namespace DVLD.Applications.Manage_Driving_Licenses_Applications.Schedule_Tests.Vision_Test
{
    public partial class frmTakeTest : Form
    {

        int LDLAppID = -1;
        int TestAppointmentID = -1;

        public frmTakeTest(int LDLAppID, string ClassName)
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);

            ucScheduleTest1.LoadInfo(LDLAppID, ClassName);
            ucScheduleTest1.TestMode = clsUtility.enVisionTestMode.Normal;
            ucScheduleTest1.HandleFormUiWithCurrentMode();
            this.LDLAppID = LDLAppID;
        }

        public frmTakeTest(int LDLAppID, string ClassName, DateTime TestAppointmentDate, int TestAppointmentID) : this(LDLAppID, ClassName)
        {
            ucScheduleTest1.EnableReadOnlyMode();
            ucScheduleTest1.SetTestDate(TestAppointmentDate);

            this.TestAppointmentID = TestAppointmentID;
        }

       
        clsTests Test = new clsTests();

        void FillThisObject()
        {
            int Result = 0;

            if (rbFail.Checked)
            {
                Result = (int)clsUtility.enTestResult.Failed;
            }
            else
                Result = (int)clsUtility.enTestResult.Passed;


            Test.TestAppointmentID = TestAppointmentID;
            Test.TestResult= Result;
            Test.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            if (string.IsNullOrEmpty(tbNotes.Text))
                Test.Notes = string.Empty;
            else
                Test.Notes = tbNotes.Text;
        }

        bool AddNewTest()
        {
            FillThisObject();

            return clsTests.AddNewTest(Test) == -1 ? false : true  ;
        }

        void Save()
        {
            if (clsUtility.WarningMessage("Are you sure you want to save? After that you cannot change the pass,fail results afte ryou save?.") == DialogResult.Yes)
            {
                if (AddNewTest() && clsTestAppointments.LockTestAppointment(TestAppointmentID) )
                    clsUtility.InfoMessage("Data Saved Successfully.");                
                else
                    clsUtility.ErorrMessage("Faild To Save Data.");
            }
            else
            {
                clsUtility.ErorrMessage("Faild To Save Data.");
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(); this.Close();
        }

        private void ucVisionTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
