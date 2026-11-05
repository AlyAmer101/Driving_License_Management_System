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
    public partial class ucApplicationRenewLicenseInfo : UserControl
    {
        public ucApplicationRenewLicenseInfo()
        {
            InitializeComponent();
        }

        public string tbNotesValue
        {
            get
            {
                return tbNotes.Text;
            }
        }

        public void LoadBasicApplicationInfo()
        {
            short ApplicationFees = (short)clsApplicationsTypes.GetApplicationFees((int)clsUtility.enApplicationTypes.Renew_Driving_License_Service);

            labApplicationFeesValue.Text = ApplicationFees.ToString();
            labApplicationDateValue.Text = DateTime.Today.ToString(clsUtility.DateFormat);
            labIssueDateValue.Text = DateTime.Today.ToString(clsUtility.DateFormat);
            labCreatedByValue.Text = clsGlobalSettings.CurrentUser.UserName;

        }
        public void LoadLicenseApplicationInfo(int OldLicenseID)
        {
            DateTime ExpirationDate = clsLicenses.GetExpirationDateByLicenseID(OldLicenseID);
            int LicenseClassID = clsLicenses.GetLicenseClassIdByLicenseID(OldLicenseID);
            short LicenseFees = (short)clsLicenseClasses.GetLicenseFees(LicenseClassID);

            labLicenseFeesValue.Text = LicenseFees.ToString();
            labExpirationDateValue.Text = ExpirationDate.ToString(clsUtility.DateFormat);
            labTotalFeesValue.Text = $"{LicenseFees + Convert.ToInt32(labApplicationFeesValue.Text)}";
            labOldLicenseIDValue.Text = OldLicenseID.ToString();
        }
        public void LoadLicenseApplicationIDs(int ApplicationID, int RenewedLicenseID)
        {
            labRenweLicenseAppIDValue.Text = ApplicationID.ToString();
            labNewLicenseIDValue.Text = RenewedLicenseID.ToString();
        }

    }
}
