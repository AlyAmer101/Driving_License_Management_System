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


namespace DVLD.Applications.Driving_Licenses_Services.Replacement_For_Damaged_Or_Lost_Licenses
{
    public partial class frmReplacementForDamagedOrLostLicenses : Form
    {
        public frmReplacementForDamagedOrLostLicenses()
        {
            InitializeComponent();
        }


        //! My Methods


        public clsUtility.enReplacementReason SelectedReplacementReason
        {
            get
            {
                return (rbDamaged.Checked == true ? clsUtility.enReplacementReason.Damaged : clsUtility.enReplacementReason.Lost);
            }
        }

        public int ApplicationID { set; get; }
        public int ReplacedLicenseID { set; get; }
        public int OldLicenseID
        {
            get
            {
                return ucLicenseInfoFilter1.LocalLicenseID;
            }
        }

        void _ReloadBasicAppInfo()
        {
            ucApplicationInfoForLicenseReplacement1.LoadBasicApplicationInfo(SelectedReplacementReason);
        }

        void FillThisObject(clsApplications Applicaton)
        {
            int ApplicationTypeID = (int)SelectedReplacementReason;

            Applicaton.ApplicationPersonID = clsLicenses.GetPersonID(OldLicenseID);
            Applicaton.ApplicationDate = DateTime.Today;
            Applicaton.ApplicationTypeID = ApplicationTypeID;
            Applicaton.ApplicationStatus = (int)clsUtility.enApplicationStatus.Completed;
            Applicaton.LastStatusDate = DateTime.Today;
            Applicaton.PaidFees = clsApplicationsTypes.GetApplicationFees(Applicaton.ApplicationTypeID);
            Applicaton.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void FillThisObject(clsLicenses ReplacedLicense)
        {
            ReplacedLicense.ApplicationID = ApplicationID;
            ReplacedLicense.DriverID = clsLicenses.GetDriverID(OldLicenseID);
            ReplacedLicense.LicenseClassID = clsLicenses.GetLicenseClassIdByLicenseID(OldLicenseID);
            ReplacedLicense.IssueDate = DateTime.Today;
            ReplacedLicense.ExpirationDate = clsLicenses.CalcExpirationDate(DateTime.Today, ReplacedLicense.LicenseClassID);
            ReplacedLicense.Notes = string.Empty;
            ReplacedLicense.PaidFees = clsLicenseClasses.GetLicenseFees(ReplacedLicense.LicenseClassID);
            ReplacedLicense.IsActive = (int)clsUtility.enLicenseActivityStatus.Active;
            ReplacedLicense.IssueReason = (int)SelectedReplacementReason;
            ReplacedLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        int AddNewApplication()
        {
            clsApplications Application = new clsApplications();

            FillThisObject(Application);

            return (ApplicationID = clsApplications.AddNewApplication(Application));
        }

        int AddNewReplacedLicense()
        {
            clsLicenses RenewedLicense = new clsLicenses();

            FillThisObject(RenewedLicense);

            return (ReplacedLicenseID = clsLicenses.AddNewLicense(RenewedLicense));
        }

        bool DeActiveOldLicense()
        {
            return clsLicenses.UpdateLicenseStatus(OldLicenseID, (int)clsUtility.enLicenseActivityStatus.NotActive);
        }

        bool ReplaceLicense()
        {
            //! Add New Application With Renew Type ID
            if (AddNewApplication() == -1)
            {
                clsUtility.ErorrMessage("Faild To Create New Application.");
                return false;
            }

            //! Add New Local License
            if (AddNewReplacedLicense() != -1)
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

        private void frmReplacementForDamagedOrLostLicenses_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            _ReloadBasicAppInfo();
        }


        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            FormTitle.Text = this.Text = "Replacement For Damaged Application";
            FormTitle.Location = new Point(234, 9);

            _ReloadBasicAppInfo();
        }
        private void rdLost_CheckedChanged(object sender, EventArgs e)
        {
            FormTitle.Text = this.Text = "Replacement For Lost Application";
            FormTitle.Location = new Point(279, 9);

            _ReloadBasicAppInfo();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucLicenseInfoFilter1.tbLicenseIdValue))
                return;

            // Load Driver  License Info
            ucLicenseInfoFilter1.ApplyFilter(false);

            if (ucLicenseInfoFilter1.IsLicenseFound)
            {
                // Load License Application Info
                ucApplicationInfoForLicenseReplacement1.LoadLicenseApplicationInfo(OldLicenseID);

                if (clsLicenses.IsLicenseActive(OldLicenseID) == (short)clsUtility.enLicenseActivityStatus.Active)
                {
                    btnIssue.Enabled = true;
                    btnShowLicensesHistory.Enabled = true;
                }
                else
                    clsUtility.ErorrMessage($"Selected License is not Active, Choose an active license.");
            }


        }

        private void btnShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicenses.GetPersonID(OldLicenseID);

            Form frm = new frmShowPersonLicenseHistory(PersonID);

            frm.ShowDialog();
        }
        private void btnShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverLicenseInfo(ReplacedLicenseID);

            frm.ShowDialog();
        }


        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (clsUtility.QuestionMessage("Are you sure you want to Renew the license?") == DialogResult.Yes)
            {
                if (ReplaceLicense())
                {
                    clsUtility.InfoMessage($"License Replaced Successfully With ID = {ReplacedLicenseID}");

                    ucApplicationInfoForLicenseReplacement1.LoadLicenseApplicationIDs(ApplicationID, ReplacedLicenseID);
                    btnShowLicenseInfo.Enabled = true;

                    //! Disable Issue button and Filter Group Box
                    btnIssue.Enabled = false;
                    btnFilter.Enabled = false;
                    ucLicenseInfoFilter1.EnablingFilterGroupBox = false;
                }
                else
                    clsUtility.ErorrMessage("Faild To Replace License.");

            }
        }


    }
}
