using DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses.Add_Inter_Licenses;
using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_License;
using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Applications.Driving_Licenses_Services.Renew_Driving_License
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        public frmRenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        //! My Methods

        public int ApplicationID { set; get; }
        public int RenewedLicenseID { set; get; }
        public int OldLicenseID
        {
            get
            {
                return ucLicenseInfoFilter1.LocalLicenseID;
            }
        }

        void FillThisObject(clsApplications Applicaton)
        {
            Applicaton.ApplicationPersonID = clsLicenses.GetPersonID(OldLicenseID);
            Applicaton.ApplicationDate = DateTime.Today;
            Applicaton.ApplicationTypeID = (int)clsUtility.enApplicationTypes.Renew_Driving_License_Service;
            Applicaton.ApplicationStatus = (int)clsUtility.enApplicationStatus.Completed;
            Applicaton.LastStatusDate = DateTime.Today;
            Applicaton.PaidFees = clsApplicationsTypes.GetApplicationFees(Applicaton.ApplicationTypeID);
            Applicaton.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void FillThisObject(clsLicenses RenewedLicense)
        {
            RenewedLicense.ApplicationID = ApplicationID;
            RenewedLicense.DriverID = clsLicenses.GetDriverID(OldLicenseID);
            RenewedLicense.LicenseClassID = clsLicenses.GetLicenseClassIdByLicenseID(OldLicenseID);
            RenewedLicense.IssueDate = DateTime.Today;
            RenewedLicense.ExpirationDate = clsLicenses.CalcExpirationDate(DateTime.Today, RenewedLicense.LicenseClassID);
            RenewedLicense.Notes = ucApplicationRenewLicenseInfo1.tbNotesValue;
            RenewedLicense.PaidFees = clsLicenseClasses.GetLicenseFees(RenewedLicense.LicenseClassID);
            RenewedLicense.IsActive = (int)clsUtility.enLicenseActivityStatus.Active;
            RenewedLicense.IssueReason = (int)clsUtility.enIssueLicenseReasons.Renew;
            RenewedLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        int AddNewApplication()
        {
            clsApplications Application = new clsApplications();

            FillThisObject(Application);

            return (ApplicationID = clsApplications.AddNewApplication(Application));
        }

        int AddNewRenewedLicense()
        {
            clsLicenses RenewedLicense = new clsLicenses();

            FillThisObject(RenewedLicense);

            return (RenewedLicenseID = clsLicenses.AddNewLicense(RenewedLicense));
        }

        bool DeActiveOldLicense()
        {
            return clsLicenses.UpdateLicenseStatus(OldLicenseID, (int)clsUtility.enLicenseActivityStatus.NotActive);
        }

        bool RenewLicense()
        {
            //! Add New Application With Renew Type ID
            if (AddNewApplication() == -1)
            {
                clsUtility.ErorrMessage("Faild To Create New Application.");
                return false;
            }

            //! Add New Local License
            if (AddNewRenewedLicense() != -1)
            {
                if (DeActiveOldLicense())
                    return true;
                else
                {
                    clsUtility.ErorrMessage("Faild To De-Active Old License.");
                    return false;
                }

            }
            else
                clsApplications.DeleteApplication(ApplicationID);


            return false;
        }

        //! Healper Methods
        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            ucApplicationRenewLicenseInfo1.LoadBasicApplicationInfo();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucLicenseInfoFilter1.tbLicenseIdValue))
                return;

            ucLicenseInfoFilter1.ApplyFilter(false);

            if (ucLicenseInfoFilter1.IsLicenseFound)
            {
                ucApplicationRenewLicenseInfo1.LoadLicenseApplicationInfo(OldLicenseID);

                if (clsLicenses.IsLicenseExpired(OldLicenseID))
                {
                    btnRenew.Enabled = true;
                    btnShowLicensesHistory.Enabled = true;
                }
                else
                    clsUtility.ErorrMessage($"Selected License is not yet expired, it will expire at {clsLicenses.GetExpirationDateByLicenseID(OldLicenseID).ToString(clsUtility.DateFormat)}");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverLicenseInfo(RenewedLicenseID);

            frm.ShowDialog();
        }
        private void btnShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicenses.GetPersonID(OldLicenseID);

            Form frm = new frmShowPersonLicenseHistory(PersonID);

            frm.ShowDialog();
        }


        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (clsUtility.QuestionMessage("Are you sure you want to Renew the license?") == DialogResult.Yes)
            {
                if (RenewLicense())
                {
                    clsUtility.InfoMessage($"License Renewed Successfully With ID = {RenewedLicenseID}");

                    ucApplicationRenewLicenseInfo1.LoadLicenseApplicationIDs(ApplicationID, RenewedLicenseID);
                    btnShowLicenseInfo.Enabled = true;

                    //! Disable Issue button and Filter Group Box
                    btnRenew.Enabled = false;
                    btnFilter.Enabled = false;
                    ucLicenseInfoFilter1.EnablingFilterGroupBox = false;
                }
                else
                    clsUtility.ErorrMessage("Faild To Renew License.");

            }
        }


    }
}
