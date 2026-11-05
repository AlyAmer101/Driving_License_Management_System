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
    public partial class ucApplicationInfoForLicenseReplacement : UserControl
    {
        public ucApplicationInfoForLicenseReplacement()
        {
            InitializeComponent();
        }

        int _GetAppropriateApplicationFees(clsUtility.enReplacementReason Reason)
        {
            switch (Reason)
            {
                case clsUtility.enReplacementReason.Damaged:

                    return clsApplicationsTypes.GetApplicationFees((int)clsUtility.enApplicationTypes.Replacement_For_Damaged_Driving_License);

                case clsUtility.enReplacementReason.Lost:

                    return clsApplicationsTypes.GetApplicationFees((int)clsUtility.enApplicationTypes.Replacement_For_Lost_Driving_License);
            }

            return 0;
        }

        public void LoadBasicApplicationInfo(clsUtility.enReplacementReason Reason)
        {
            int ApplicationFees = _GetAppropriateApplicationFees(Reason);

            labApplicationFeesValue.Text = ApplicationFees.ToString();
            labApplicationDateValue.Text = DateTime.Today.ToString(clsUtility.DateFormat);
            labCreatedByValue.Text = clsGlobalSettings.CurrentUser.UserName;

        }
        public void LoadLicenseApplicationInfo(int OldLicenseID)
        {
            labOldLicenseIDValue.Text = OldLicenseID.ToString();
        }
        public void LoadLicenseApplicationIDs(int ApplicationID, int ReplacedLicenseID)
        {
            labReplacedLicenseAppIDValue.Text = ApplicationID.ToString();
            labReplacedLicenseIDValue.Text = ReplacedLicenseID.ToString();
        }

    }
}
