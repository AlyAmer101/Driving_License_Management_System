using DVLD.General_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        int ApplicationID = -1;
        int LDLAppId = -1;

        public frmLocalDrivingLicenseApplicationInfo(int ApplicationID, int LDLAppId)
        {
            InitializeComponent();

            this.ApplicationID = ApplicationID;
            this.LDLAppId = LDLAppId;
        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            ucDrivingLicenseApplicationInfo1.LoadLDLApplicationInfo(LDLAppId);
            ucApplicationBasicInfo1.LoadApplicationInfo(ApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
