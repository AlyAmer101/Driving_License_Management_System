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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Issue_New_Driving_License
{
    public partial class frmIssueDrivingLicenseForFirstTime : Form
    {
        public frmIssueDrivingLicenseForFirstTime(int AppID, int LDLAppID)
        {
            InitializeComponent();

            ApplicationID = AppID;
            this.LDLAppID = LDLAppID;
        }

        private void frmIssueDrivingLicenseForFirstTime_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            ucApplicationBasicInfo2.LoadApplicationInfo(ApplicationID);
            ucDrivingLicenseApplicationInfo2.LoadLDLApplicationInfo(LDLAppID);
        }

        //! My Methods

        int ApplicationID = -1;
        int LDLAppID = -1;
        int NewLicenseID = -1;

        string NationalNo
        {
            get
            {
                return clsLocalDrivingLicenseApplications.GetNationalNoByLDLAppID(LDLAppID);
            }
        }

        void FillThisObject(int DriverID, clsLicenses license)
        {
            license.ApplicationID = ApplicationID;
            license.DriverID = DriverID;
            license.LicenseClassID = clsLocalDrivingLicenseApplications.GetLicenseClassID(LDLAppID);
            license.IssueDate = DateTime.Today;
            license.ExpirationDate = clsLicenses.CalcExpirationDate(DateTime.Today, license.LicenseClassID);
            license.Notes = tbNotes.Text;
            license.PaidFees = clsLicenseClasses.GetLicenseFees(license.LicenseClassID);
            license.IsActive = (int)clsUtility.enLicenseActivityStatus.Active;
            license.IssueReason = (int)clsUtility.enIssueLicenseReasons.FirstTime;
            license.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        int AddNewLicense(int DriverID)
        {
            clsLicenses license = new clsLicenses();

            FillThisObject(DriverID, license);

            return clsLicenses.AddNewLicense(license);
        }

        void IssueNewLicenseForFirstTime()
        {
            int DriverID = -1;

            // 1. Make The Person a Driver
            if (clsDriver.IsPersonAlreadyDriver(NationalNo))
                DriverID = clsDriver.GetDriverIdByNationalNo(NationalNo);
            else
            {
                DriverID = clsDriver.AddNewDriver(clsGlobalSettings.CurrentPersonId, clsGlobalSettings.CurrentUser.UserID, DateTime.Today);
                
                if (DriverID == -1)
                {
                    clsUtility.ErorrMessage("Faild To Add This Person As A Diver, Try Agin.");
                    return;
                }
            }


            // 2. Add New License 
            NewLicenseID = AddNewLicense(DriverID); 

            
            if (NewLicenseID == -1)
            {
                clsUtility.ErorrMessage("Faild To Issue The License.");
                return;
            }
            else
                clsUtility.InfoMessage($"License Issued Successfully With License ID = {NewLicenseID}");


            // 3. Update App Status To Complete
            bool IsAppStatusUpdated = clsLocalDrivingLicenseApplications.UpdateApplicationStatus(LDLAppID, (int)clsUtility.enApplicationStatus.Completed);
          
            if (!IsAppStatusUpdated)
            {
                clsUtility.ErorrMessage("Faild Update Application Status.");
                return;
            }

        }

        //! Healper Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            IssueNewLicenseForFirstTime();
            this.Close();
        }

    }
}
