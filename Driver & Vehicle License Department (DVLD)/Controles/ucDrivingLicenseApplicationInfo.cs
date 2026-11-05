using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_License;
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
    public partial class ucDrivingLicenseApplicationInfo : UserControl
    {
        public ucDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        int LDLApplicationID = -1;

        //! My Methods

        public void LoadLDLApplicationInfo(int LDLApplicationID)
        {
            this.LDLApplicationID = LDLApplicationID;

            labLDLAppIDValue.Text = LDLApplicationID.ToString();
            labPassedTestsValue.Text = clsLocalDrivingLicenseApplications.GetPassedTestsCountByLDLAppID(LDLApplicationID).ToString();
            labLicenseClassValue.Text = clsLocalDrivingLicenseApplications.GetLicenseClassName(LDLApplicationID);

        }

        public void Clear()
        {
            labLDLAppIDValue.Text = "-1";
            labLicenseClassValue.Text = "??";
            labPassedTestsValue.Text = "??";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmShowDriverLicenseInfo(clsLocalDrivingLicenseApplications.GetLicenseID(LDLApplicationID));

            frm.ShowDialog();
        }


    }
}
