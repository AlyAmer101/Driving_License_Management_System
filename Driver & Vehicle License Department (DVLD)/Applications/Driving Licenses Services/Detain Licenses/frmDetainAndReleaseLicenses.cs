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

namespace DVLD.Applications.Driving_Licenses_Services.Detain_Licenses
{
    public partial class frmDetainAndReleaseLicenses : Form
    {

        clsUtility.enDetainOrRelease CurrentMode = 0;

        public frmDetainAndReleaseLicenses(clsUtility.enDetainOrRelease FormMode, int LicenseID = -1)
        {
            InitializeComponent();

            CurrentMode = FormMode;

            if (LicenseID != -1)
            {
                this.LicenseID = LicenseID;

                // Apply Filter 
                btnFilter.Enabled = false;
                ucLicenseInfoFilter1.ApplyFilter(false);
                LoadDetianInfoBasedOnCurrentMode();
            }

        }


        //! My Methods

        public int LicenseID  
        {
            get
            {
                return ucLicenseInfoFilter1.LocalLicenseID;
            }
            set
            {
                ucLicenseInfoFilter1.LocalLicenseID = value;
            }


        }
        public int ApplicationID { set; get; } // Release Mode
        public int DetainID { set; get; } // Deatin Mode


        string GetCurrentModeAsString()
        {
            switch (CurrentMode)
            {
                case clsUtility.enDetainOrRelease.Detain:
                    return "Detain";

                case clsUtility.enDetainOrRelease.Release:
                    return "Release";
            }

            return "";
        }
        void HandleEnablingFormItemsAfterAction()
        {
            btnShowLicenseInfo.Enabled = true;

            btnDetainRelease.Enabled = false;
            btnFilter.Enabled = false;
            ucLicenseInfoFilter1.EnablingFilterGroupBox = false;
        }

        void HandleFormWithCurrentMode()
        {
            switch (CurrentMode)
            {
                case clsUtility.enDetainOrRelease.Detain:

                    this.Text = FormTitle.Text = "Detain License";
                    FormTitle.Location = new Point(431, 11);
                    
                    ucDetainInfo1.Visible = true;
                    ucDetainInfoOnReleaseMode1.Visible = false;
                    
                    btnDetainRelease.Text = "Detain";
                    btnDetainRelease.Image = Properties.Resources.Detain_32;

                    break;

                case clsUtility.enDetainOrRelease.Release:

                    this.Text = FormTitle.Text = "Release Detained License";
                    FormTitle.Location = new Point(341, 11);

                    ucDetainInfo1.Visible = false;
                    ucDetainInfoOnReleaseMode1.Visible = true;

                    btnDetainRelease.Text = "Release";
                    btnDetainRelease.Image = Properties.Resources.Release_Detained_License_32;

                    break;
            }
        }

        void LoadDetianInfoBasedOnCurrentMode()
        {
            switch (CurrentMode)
            {
                case clsUtility.enDetainOrRelease.Detain:


                    if (!clsDetainedLicenses.IsLicenseDetained(LicenseID))
                    {
                        // Load License Application Info
                        ucDetainInfo1.LoadLicenseID(LicenseID);

                        btnDetainRelease.Enabled = true;
                        btnShowLicensesHistory.Enabled = true;
                    }
                    else
                        clsUtility.ErorrMessage($"Selected License Already Detained, Choose Another One.");
                break;

                case clsUtility.enDetainOrRelease.Release:


                    if (clsDetainedLicenses.IsLicenseDetained(LicenseID))
                    {
                        // Load License Application Info
                        ucDetainInfoOnReleaseMode1.LoadDetainInfo(LicenseID);

                        btnDetainRelease.Enabled = true;
                        btnShowLicensesHistory.Enabled = true;
                    }
                    else
                        clsUtility.ErorrMessage($"Selected License Not Detained, Choose Another One.");
                    break;
            }
        }

        
        void FillThisObject(clsApplications Applicaton)
        {

            Applicaton.ApplicationPersonID = clsLicenses.GetPersonID(LicenseID);
            Applicaton.ApplicationDate = DateTime.Today;
            Applicaton.ApplicationTypeID = (int)clsUtility.enApplicationTypes.Release_Detained_Driving_Licsense;
            Applicaton.ApplicationStatus = (int)clsUtility.enApplicationStatus.Completed;
            Applicaton.LastStatusDate = DateTime.Today;
            Applicaton.PaidFees = clsApplicationsTypes.GetApplicationFees(Applicaton.ApplicationTypeID);
            Applicaton.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }  

        void FillThisObject(clsDetainedLicenses ReleaseInfo)  
        {
            ReleaseInfo.IsReleased = (int)clsUtility.enIsReleased.Yes;
            ReleaseInfo.ReleaseDate = DateTime.Today;
            ReleaseInfo.ReleaseApplicationID = ApplicationID;
            ReleaseInfo.ReleaseByUserID = clsGlobalSettings.CurrentUser.UserID;
        }  

        int AddNewApplication()
        {
            clsApplications Application = new clsApplications();

            FillThisObject(Application);

            return (ApplicationID = clsApplications.AddNewApplication(Application));
        }  

        bool ReleaseDetainedLicense()
        {
            clsDetainedLicenses ReleaseInfo = new clsDetainedLicenses();

            FillThisObject(ReleaseInfo);

            return clsDetainedLicenses.ReleaseDetainedLicense(LicenseID, ReleaseInfo);
        } 

        bool ActiveLicense()
        {
            return clsLicenses.UpdateLicenseStatus(LicenseID, (int)clsUtility.enLicenseActivityStatus.Active);
        }
        bool DeActiveLicense()
        {
            return clsLicenses.UpdateLicenseStatus(LicenseID, (int)clsUtility.enLicenseActivityStatus.NotActive);
        }

        bool ReleaseLicense() 
        {
            //! Add New Application With Renew Type ID
            if (AddNewApplication() == -1)
            {
                clsUtility.ErorrMessage("Faild To Create New Application.");
                return false;
            }

            //! Release Detained License
            if (ReleaseDetainedLicense())
            {
                if (ActiveLicense())
                    return true;
                else
                {
                    clsUtility.ErorrMessage("Faild To Active Old License.");
                    return false;
                }

            }
            else
                clsApplications.DeleteApplication(ApplicationID);


            return false;
        }

        bool DetainLicense()
        {
            if (ucDetainInfo1.FineFees == -1)
            {
                clsUtility.ErorrMessage("Write a Valid Fine Fees.");
                return false;
            }

            clsDetainedLicenses DetainedLicense = new clsDetainedLicenses();
            DetainedLicense.FineFees = ucDetainInfo1.FineFees;
            DetainedLicense.DetainDate = DateTime.Today;
            DetainedLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            DetainID = clsDetainedLicenses.AddNewDetainedLicense(LicenseID, DetainedLicense);

            return (DeActiveLicense() && DetainID != -1);
        }

    
        //! Healper Methods
        private void frmDetainAndReleaseLicenses_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            HandleFormWithCurrentMode();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucLicenseInfoFilter1.tbLicenseIdValue))
                return;

            // Load Driver  License Info
            ucLicenseInfoFilter1.ApplyFilter(false);

            if (ucLicenseInfoFilter1.IsLicenseFound)
            {
                LoadDetianInfoBasedOnCurrentMode();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetainRelease_Click(object sender, EventArgs e)
        {
            if (clsUtility.QuestionMessage($"Are you sure you want to {GetCurrentModeAsString()} the license?") == DialogResult.Yes)
            {
                if ((CurrentMode == clsUtility.enDetainOrRelease.Detain) 
                    ? DetainLicense()
                    : ReleaseLicense())
                {

                    if (CurrentMode == clsUtility.enDetainOrRelease.Detain)
                    {
                        clsUtility.InfoMessage($"License Detained Successfully with Id = {DetainID}");
                        ucDetainInfo1.LoadDetainID(DetainID);
                    }
                    else if (CurrentMode == clsUtility.enDetainOrRelease.Release)
                    {
                        clsUtility.InfoMessage($"License Released Successfully.");
                        ucDetainInfoOnReleaseMode1.LoadApplicationID(ApplicationID);
                    }

                    //! Disable DetainRelease button and Filter Group Box
                    HandleEnablingFormItemsAfterAction();
                }
                else
                    clsUtility.ErorrMessage($"Faild To {GetCurrentModeAsString()} License.");
            }



        }

        private void btnShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicenses.GetPersonID(LicenseID);

            Form frm = new frmShowPersonLicenseHistory(PersonID);

            frm.ShowDialog();
        }
        private void btnShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverLicenseInfo(LicenseID);

            frm.ShowDialog();
        }

    }

    
}
