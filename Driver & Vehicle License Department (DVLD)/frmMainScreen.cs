using DVLD;
using DVLD.Applications.Driving_Licenses_Services.Detain_Licenses;
using DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses;
using DVLD.Applications.Driving_Licenses_Services.Renew_Driving_License;
using DVLD.Applications.Driving_Licenses_Services.Replacement_For_Damaged_Or_Lost_Licenses;
using DVLD.Applications.Manage_Applications;
using DVLD.Applications.Manage_Applications.International_Licenses_Applications;
using DVLD.Applications.Manage_Driving_Licenses_Applications;
using DVLD.Applications.Manage_TestTypes;
using DVLD.Drivers;
using DVLD.General_Classes;
using DVLD.Login;
using DVLD.Users;
using DVLD___BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin = null;

        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;
        }

        //! Helper Methods  (On Clicks, On Changed, etc..)

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            this.MaximizeBox = true;
        }

        private void itemSignOut_Click(object sender, EventArgs e)
        {
            clsGlobalSettings.CurrentUser = null;

            _frmLogin.Show();

            this.Close();
        }
    
        private void People_Click(object sender, EventArgs e)
        {
            Form frm = new frmPeopleManagement();

            frm.ShowDialog();
            
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Form frm = new frmUsersManagement();

            frm.ShowDialog();
        }

        private void itemCurrentUserInfo_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo(clsGlobalSettings.CurrentUser.PersonInfo.ID, clsGlobalSettings.CurrentUser.UserID);

            frm.ShowDialog();
        }

        private void itemChangePassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(clsGlobalSettings.CurrentUser.UserID);

            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListApplicationTypes();

            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListTestTypes();

            frm.ShowDialog();
        }

        private void localLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewLocalDrivingLicense();

            frm.ShowDialog();
        }

        private void localDrivingLicensesApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageLocalDrivingLicenseApplications();

            frm.ShowDialog();
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
            Form frm = new frmDriverManagement();

            frm.ShowDialog();
        }

        private void interToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewInternationlDrivingLicense();

            frm.ShowDialog();
        }

        private void internationalDrivingLicensesApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageInternationalLicensesApplications();

            frm.ShowDialog();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmRenewLocalDrivingLicense();

            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageLocalDrivingLicenseApplications();

            frm.ShowDialog();

        }

        private void replacementForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmReplacementForDamagedOrLostLicenses();

            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainAndReleaseLicenses(clsUtility.enDetainOrRelease.Detain);

            frm.ShowDialog();
        }

        private void reToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainAndReleaseLicenses(clsUtility.enDetainOrRelease.Release);

            frm.ShowDialog();
        }

        private void releToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainAndReleaseLicenses(clsUtility.enDetainOrRelease.Release);

            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageDetainedLicenses();

            frm.ShowDialog();
        }

        private void AccountSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
