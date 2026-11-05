using DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses.Add_Inter_Licenses;
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

namespace DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History
{
    public partial class frmShowPersonLicenseHistory : Form
    {

        public int IocalLicenseID
        {
            get
            {
                return (int)dgvIocalLicensesHistory.CurrentRow.Cells[0].Value;
            }
        }
        public int InterLicenseID
        {
            get
            {
                return (int)dgvInternationalLicensesHistory.CurrentRow.Cells[0].Value;
            }
        }

        int PersonID = -1;

        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();

            this.PersonID = PersonID;
        }


        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsInternationalLicenses_View.InternationalLicenses_View' table. You can move, or remove it, as needed.
            clsGlobalSettings.NormalizeForm(this);

            //? Local Licenses
                this.licenses_ViewTableAdapter.Fill(this.dsLocalLicenses.Licenses_View);
                //! Filter Local Licenses To Get Person's Licenses
                licensesViewBindingSource.Filter = $"applicantPersonID = {PersonID}";
                labLocalLicesnesCount.Text = dgvIocalLicensesHistory.Rows.Count.ToString();

            //? International Licenses
                this.internationalLicenses_ViewTableAdapter.Fill(this.dsInternationalLicenses_View.InternationalLicenses_View);
                //! Filter International Licenses To Get Person's Licenses
                internationalLicensesViewBindingSource.Filter = $"applicantPersonID = {PersonID}";
                labInternationalLicesnesCount.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form frm = new frmShowPersonInfo(PersonID);

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (tcAddNewDrivingLicense.SelectedIndex)
            {
                case 0: // Local License 

                    Form frm1 = new frmShowDriverLicenseInfo(IocalLicenseID);
                    frm1.ShowDialog();
                    
                    break;
                    
                case 1:  // Inter License 

                    Form frm2 = new frmShowDriverInterLicenseInfo(InterLicenseID);
                    frm2.ShowDialog();
                    
                    break;
            }

        }


    }
}
