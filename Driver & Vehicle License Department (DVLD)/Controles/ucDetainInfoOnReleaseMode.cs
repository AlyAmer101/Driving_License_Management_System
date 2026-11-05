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
    public partial class ucDetainInfoOnReleaseMode : UserControl
    {
        public ucDetainInfoOnReleaseMode()
        {
            InitializeComponent();
        }


        public void LoadDetainInfo(int LicenseID)
        {
            clsDetainedLicenses DetainedLicenseInfo = clsDetainedLicenses.GetDetainedLicenseInfo(LicenseID);

            labLicenseIDValue.Text = LicenseID.ToString();
            labDetainIDValue.Text = DetainedLicenseInfo.DetainID.ToString();
            labDetainDateValue.Text = DetainedLicenseInfo.DetainDate.ToString();
            labCreatedByValue.Text = DetainedLicenseInfo.CreatedByUserID.ToString();
            labFineFeesValue.Text = DetainedLicenseInfo.FineFees.ToString();

            labApplicationFeesValue.Text = clsApplicationsTypes.GetApplicationFees((int)clsUtility.enApplicationTypes.Release_Detained_Driving_Licsense).ToString();
            
            labTotalFeesValue.Text = (DetainedLicenseInfo.FineFees + Convert.ToInt32(labApplicationFeesValue.Text)).ToString();
        }

        public void LoadApplicationID(int ApplicationID)
        {
            labApplicationIdValue.Text = ApplicationID.ToString();
        }


    }
}
