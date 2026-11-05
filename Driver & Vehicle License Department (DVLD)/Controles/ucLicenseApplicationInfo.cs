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
    public partial class ucLicenseApplicationInfo : UserControl
    {
        public ucLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadLicenseApplicationInfo()
        {
            DateTime ExpirationDate = DateTime.Today.AddYears(clsUtility.ValidityLengthOfInternationalLicenses);

            labApplicationDateValue.Text = DateTime.Today.ToString(clsUtility.DateFormat);
            labIssueDateValue.Text = DateTime.Today.ToString(clsUtility.DateFormat);
            labExpirationDateValue.Text = ExpirationDate.ToString(clsUtility.DateFormat);
            labFeesValue.Text = clsApplicationsTypes.GetApplicationFees((int)clsUtility.enApplicationTypes.New_International_License).ToString();


            labCreatedByValue.Text = clsGlobalSettings.CurrentUser.UserName;
        }
        
        public void LoadLicenseApplicationIDs(int InternationalApplicationID, int InternationalLicenseID, int LocalLicenseID)
        {
            labInternationalLicenseIDValue.Text = InternationalLicenseID.ToString();
            labILA_IDValue.Text = InternationalApplicationID.ToString();
            labLocalLicenseIDValue.Text = LocalLicenseID.ToString();
        }


    }
}
