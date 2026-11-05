using DVLD.General_Classes;
using DVLD___BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controles
{
    public partial class ucRetakeTestInfo : UserControl
    {
        public int RetakeTestAppID { get; set; }
        public int LDLAppID { get; set; }
        public int TestAppointmentID { get; set; }


        public ucRetakeTestInfo()
        {
            InitializeComponent();

        }

        private void gbRetakeTestInfo_Enter(object sender, EventArgs e)
        {

        }

        public void LoadInfo(int TestFees)
        {
            
            int RetakeTestFees = clsApplicationsTypes.GetApplicationFees((int)clsUtility.enApplicationTypes.Retake_Test);
          
            labRetakeApplicationFees.Text = RetakeTestFees.ToString();
            labTotaleFees.Text = (TestFees + RetakeTestFees).ToString();

            RetakeTestAppID = clsTestAppointments.GetRetakeTestAppId(TestAppointmentID);

            if (RetakeTestAppID != -1)
                labRetakeTestAppID.Text = RetakeTestAppID.ToString();
        }


        public bool AddNewRetakeTestApplication()
        {
            clsApplications application = new clsApplications();

            application.ApplicationPersonID = clsGlobalSettings.CurrentPersonId;
            application.ApplicationDate = DateTime.Today;
            application.ApplicationTypeID = (int)clsUtility.enApplicationTypes.Retake_Test;
            application.ApplicationStatus = (int)clsUtility.enApplicationStatus.New;
            application.LastStatusDate = DateTime.Today;
            application.PaidFees = clsApplicationsTypes.GetApplicationFees((int)clsUtility.enApplicationTypes.Retake_Test);
            application.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            RetakeTestAppID = clsApplications.AddNewApplication(application);

            
            if (RetakeTestAppID != -1)
            {
                labRetakeTestAppID.Text = RetakeTestAppID.ToString();
                
                if (clsTestAppointments.UpdateTestAppointmentWithRetakeTestAppID(TestAppointmentID, RetakeTestAppID))
                    return true;
            }


            return false;
        }


    }
}
