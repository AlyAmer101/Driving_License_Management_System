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

namespace DVLD.User_Controles
{
    public partial class ucLicenseInfoFilter : UserControl
    {
        public ucLicenseInfoFilter()
        {
            InitializeComponent();
        }


        //! My Methods
        public int LocalLicenseID { set; get; }
        public bool IsLicenseFound { set; get; }
        public bool CanIssueInternationalLicense { set; get; }

        public bool EnablingFilterGroupBox
        {
            set
            {
                gbFilter.Enabled = value;
            }
                
        }
        public string tbLicenseIdValue
        {
            get { return tbLicenseIDValue.Text; }
        }


        bool IsQualifiedForInternationalLicense(int DriverID, int LicenseID)
        {
            int InternationalLicenseID = clsInternationalLicenses.GetInternationalLicenseID(DriverID);
           
            if (InternationalLicenseID != -1)
            {
                clsUtility.ErorrMessage($"This Person Already have an Active International License With ID = {InternationalLicenseID}");
                return false;
            }

            if (clsLicenses.IsLicenseActive(LicenseID) == (int)clsUtility.enLicenseActivityStatus.NotActive)
            {
                clsUtility.ErorrMessage($"The License Of This Person Is Not Active.");
                return false;
            }

            if (clsLicenses.IsLicenseExpired(LicenseID))
            {
                clsUtility.ErorrMessage($"The License Of Person Is Expired.");
                return false;
            }

            if (!clsLicenses.IsPersonHasLicenseClassThree(LicenseID))
            {
                clsUtility.ErorrMessage($"This Person Dose Not Have License Class Three.");
                return false;
            }


            return true;
        }

        public void ApplyFilter(bool CheckIfPersonCanIssueInterLicense = true)
        {
            if (LocalLicenseID == 0)
                LocalLicenseID = Convert.ToInt32(tbLicenseIDValue.Text);
            else
            {
                tbLicenseIDValue.Text = LocalLicenseID.ToString();
                gbFilter.Enabled = false;
            }

            if (IsLicenseFound = clsLicenses.IsLicenseExist(LocalLicenseID))
            {
                ucDriverLicenseInfo1.LoadDriverInfo(LocalLicenseID);


                if (CheckIfPersonCanIssueInterLicense)
                {
                    int DriverID = clsLicenses.GetDriverID(LocalLicenseID);
                    CanIssueInternationalLicense = IsQualifiedForInternationalLicense(DriverID, LocalLicenseID);
                }
            }
            else
                clsUtility.ErorrMessage($"The License With Id = {LocalLicenseID} Is Not Exist.");
        }

        //! Healper Methods
        private void tbLicenseIDValue_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbLicenseIDValue.Text, out int LicenseID))
                tbLicenseIDValue.Text = "";
        }

        private void tbLicenseIDValue_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, erValidateTextBox);
        }

    }
}
