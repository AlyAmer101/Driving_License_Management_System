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

namespace DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses.Add_Inter_Licenses
{
    public partial class frmShowDriverInterLicenseInfo : Form
    {
        int InternationalLicenseID = -1;

        public frmShowDriverInterLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();

            this.InternationalLicenseID = InternationalLicenseID;
        }

        private void frmShowDriverInterLicenseInfo_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);
            ucDriverInterLicenseInfo1.LoadDriverInterLicenseInfo(InternationalLicenseID);
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
