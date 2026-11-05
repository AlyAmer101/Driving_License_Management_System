using DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses.Add_Inter_Licenses;
using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses
{
    public partial class frmAddNewInternationlDrivingLicense : Form
    {
        public frmAddNewInternationlDrivingLicense()
        {
            InitializeComponent();
        }

        private void frmAddNewInternationlDrivingLicense_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);
            ucLicenseApplicationInfo1.LoadLicenseApplicationInfo();
        }

        //! My Methods

        public int InternationalLicenseID { set; get; }
        public int LocalLicenseID
        {
            get
            {
                return ucLicenseInfoFilter1.LocalLicenseID;
            }
        }
        public int ApplicationID { set; get; }

        void FillThisObject(clsApplications Applicaton)
        {
            Applicaton.ApplicationPersonID = clsLicenses.GetPersonID(LocalLicenseID);
            Applicaton.ApplicationDate = DateTime.Today;
            Applicaton.ApplicationTypeID = (int)clsUtility.enApplicationTypes.New_International_License;
            Applicaton.ApplicationStatus = (int)clsUtility.enApplicationStatus.Completed;
            Applicaton.LastStatusDate = DateTime.Today;
            Applicaton.PaidFees = clsApplicationsTypes.GetApplicationFees(Applicaton.ApplicationTypeID);
            Applicaton.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }
       
        void FillThisObject(clsInternationalLicenses License)
        {
            License.ApplicationID = ApplicationID;
            License.DriverID = clsLicenses.GetDriverID(LocalLicenseID);
            License.IssuedUsingLocalLicenseID = LocalLicenseID;
            License.IssueDate = DateTime.Today;
            License.ExpirationDate = DateTime.Today.AddYears(clsUtility.ValidityLengthOfInternationalLicenses);
            License.IsActive = (int)clsUtility.enLicenseActivityStatus.Active;
            License.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        int AddNewApplication()
        {
            clsApplications Application = new clsApplications();

            FillThisObject(Application);

            return (ApplicationID = clsApplications.AddNewApplication(Application));
        }

        int AddNewInternationalLicense()
        {
            clsInternationalLicenses NewLicense = new clsInternationalLicenses();

            FillThisObject(NewLicense);

            return ( InternationalLicenseID = clsInternationalLicenses.AddNewLicense(NewLicense) );
        }

        bool IssueNewLicense()
        {
            //! Add New Application With International Type ID
            if (AddNewApplication() == -1)
            {
                clsUtility.ErorrMessage("Faild To Create New Application.");
                return false;
            }

            //! Add New International License
            if (AddNewInternationalLicense() != -1)
                return true;
            else
                clsApplications.DeleteApplication(ApplicationID);


            return false;
        }

        //! Healper Methods


        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucLicenseInfoFilter1.tbLicenseIdValue))
                return;

            ucLicenseInfoFilter1.ApplyFilter();

            btnShowLicensesHistory.Enabled = ucLicenseInfoFilter1.IsLicenseFound;
            btnIssue.Enabled = ucLicenseInfoFilter1.CanIssueInternationalLicense;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (clsUtility.QuestionMessage("Are you sure you want to issue the license?") == DialogResult.Yes)
            {
                if (IssueNewLicense())
                {
                    clsUtility.InfoMessage($"International License Issued Successfully With ID = {InternationalLicenseID}");

                    ucLicenseApplicationInfo1.LoadLicenseApplicationIDs(ApplicationID, InternationalLicenseID, LocalLicenseID);

                    btnShowLicenseInfo.Enabled = true;

                    //! Disable Issue button and Filter Group Box
                    btnIssue.Enabled = false;
                    btnFilter.Enabled = false;
                    ucLicenseInfoFilter1.EnablingFilterGroupBox = false;
                }
                else
                    clsUtility.ErorrMessage("Faild To Issue New License.");
            }
        }
        
        
        private void btnShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverInterLicenseInfo(InternationalLicenseID);

            frm.ShowDialog();
        }
        private void btnShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicenses.GetPersonID(LocalLicenseID);

            Form frm = new frmShowPersonLicenseHistory(PersonID);

            frm.ShowDialog();
        }



    
    
    }
}
