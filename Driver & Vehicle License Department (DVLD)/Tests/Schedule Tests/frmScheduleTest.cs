using DVLD.General_Classes;
using DVLD.User_Controles;
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

namespace DVLD.Applications.Schedule_Tests.Vision_Test
{
    public partial class frmScheduleTest : Form
    {
        int LDLAppID = -1;
        string ClassName = "";
        int TestAppointmentID = -1;
        bool AddNewRetakeTestMode = false;

        clsTestAppointments TestAppointment = new clsTestAppointments();

        public frmScheduleTest(int LDLAppID, string ClassName, int LockStatus)
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);


            //! Show Info
            ucScheduleTest1.LoadInfo(LDLAppID, ClassName);
            ucScheduleTest1.TestMode = ((LockStatus == (int)clsUtility.enTestAppointmentLockStatus.Active) ? clsUtility.enVisionTestMode.Normal : clsUtility.enVisionTestMode.Locked);
            ucScheduleTest1.HandleFormUiWithCurrentMode();
            ucScheduleTest1.SetTestDate(DateTime.Today);

            btnSave.Enabled = (ucScheduleTest1.TestMode == clsUtility.enVisionTestMode.Normal ? true : false);

            this.LDLAppID = LDLAppID;
            this.ClassName = ClassName;
        }

        public frmScheduleTest(int LDLAppID, string ClassName, int LockStatus ,int TestAppointmentID, DateTime TestAppointmentDate, clsUtility.enVisionTestMode Mode = clsUtility.enVisionTestMode.Normal) : this(LDLAppID, ClassName, LockStatus)
        {
            //! Enable Updating 
            this.TestAppointmentID = TestAppointmentID;
            ucScheduleTest1.SetTestDate(TestAppointmentDate);
           
            btnSave.Enabled = true;
            ucRetakeTestInfo1.Enabled = false;

            //!  Case 0 : Locked
            if (LockStatus == (int)clsUtility.enTestAppointmentLockStatus.Locked)
            {
                HandleFormWithMode(clsUtility.enVisionTestMode.Locked);
                btnSave.Enabled = false;

                return;
            }

            //!  Case 1 : Add New Reteke Test App
            if (Mode == clsUtility.enVisionTestMode.Retake)
            {
                AddNewRetakeTestMode = true;

                //! AddNew , Cuz We Create New RetakeTest Application and Appointment
                this.TestAppointment.Mode = clsTestAppointments.enMode.AddNew;

                HandleFormWithMode();

                this.TestAppointmentID = -1;
                LoadRetakeInfo();

                return;
            }

            //! Case 2 : Edit RetekeTest  Mode
            else if (Mode == clsUtility.enVisionTestMode.Edit_Retake)
            {
                //! AddNew , Cuz We Create New RetakeTest Application and Appointment
                this.TestAppointment.Mode = clsTestAppointments.enMode.Update;

                HandleFormWithMode();
                LoadRetakeInfo();

                return;
            }

            //! Case 3 : Edit
            else if (Mode == clsUtility.enVisionTestMode.Edit)
            {
                ucRetakeTestInfo1.RetakeTestAppID = -1;

                //! AddNew , Cuz We Create New RetakeTest Application and Appointment
                this.TestAppointment.Mode = clsTestAppointments.enMode.Update;

                HandleFormWithMode(Mode);
                return;
            }


        }

        void LoadRetakeInfo()
        {
            ucRetakeTestInfo1.Enabled = true;
            ucRetakeTestInfo1.LDLAppID = LDLAppID;
            ucRetakeTestInfo1.TestAppointmentID = TestAppointmentID;
            ucRetakeTestInfo1.LoadInfo(ucScheduleTest1.PaidFees);

            AddNewRetakeTestMode = true;
        }

        void HandleFormWithMode(clsUtility.enVisionTestMode Mode = clsUtility.enVisionTestMode.Retake)
        {
            ucScheduleTest1.TestMode = Mode;
            ucScheduleTest1.HandleFormUiWithCurrentMode();
        }
  
  

        void FillThisObject(clsTestAppointments TestAppointment)
        {

            TestAppointment.TestTypeID = (int)clsGlobalSettings.CurrentActiveTestType;
            TestAppointment.LocalDrivingLicenseApplicationID = LDLAppID;
            TestAppointment.PaidFees = ucScheduleTest1.PaidFees;
            TestAppointment.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            TestAppointment.IsLocked = (int)clsUtility.enTestAppointmentLockStatus.Active;
            TestAppointment.AppointmentDate = ucScheduleTest1.TestDate;

            TestAppointment.TestAppointmentID = -1;
            TestAppointment.RetakeTestApplicationID = -1;
        }

        int AddNewTestAppointment()
        {

            FillThisObject(TestAppointment);

            return clsTestAppointments.AddNewTestAppointment(TestAppointment);
        }

        bool UpdateTestAppointment()
        {
            DateTime NewTestDate = ucScheduleTest1.TestDate;

            return clsTestAppointments.UpdateTestAppointment(TestAppointmentID, NewTestDate);
        }

        void Save()
        {

            switch (TestAppointment.Mode)
            {
                case clsTestAppointments.enMode.AddNew:

                    if (AddNewRetakeTestMode)
                    {
                        ucRetakeTestInfo1.TestAppointmentID = AddNewTestAppointment();

                        if (ucRetakeTestInfo1.AddNewRetakeTestApplication())
                            clsUtility.InfoMessage("Data Saved Successfully.");
                        else
                            clsUtility.ErorrMessage("Faild To Save Data.");
                    }
                    else
                    {
                        if (AddNewTestAppointment() != -1)
                            clsUtility.InfoMessage("Data Saved Successfully.");
                        else
                            clsUtility.ErorrMessage("Faild To Save Data.");
                    }

                        TestAppointmentID = -1;
                    break;


                case clsTestAppointments.enMode.Update:

                    if (UpdateTestAppointment())
                        clsUtility.InfoMessage("Data Updated Successfully.");
                    else
                        clsUtility.ErorrMessage("Faild To Update Data.");

                    TestAppointmentID = -1;
                    break;

            }



        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();

        }

        private void ucVisionTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
