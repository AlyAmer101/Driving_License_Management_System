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

namespace DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_License
{
    public partial class frmShowDriverLicenseInfo : Form
    {
        
        int DriverID = -1;
        int LicenseID = -1;


        public frmShowDriverLicenseInfo(int LicenseID)
        {
            InitializeComponent();

            this.LicenseID = LicenseID;
            this.DriverID = clsLicenses.GetDriverID(LicenseID);
        }

        private void frmShowDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            ucDriverLicenseInfo1.LoadDriverInfo(DriverID, LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
