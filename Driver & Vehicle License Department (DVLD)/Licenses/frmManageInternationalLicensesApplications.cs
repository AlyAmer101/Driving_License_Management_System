using DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses;
using DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses.Add_Inter_Licenses;
using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History;
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

namespace DVLD.Applications.Manage_Applications.International_Licenses_Applications
{
    public partial class frmManageInternationalLicensesApplications : Form
    {
        public frmManageInternationalLicensesApplications()
        {
            InitializeComponent();

            cbInterAppsFilter.SelectedIndex = 1;
        }


        //! My Methods
        enum enInterAppsFilter { None, InterLicenseID, ApplicationID, DriverID, LocalLicenseID, IsActive }
        enum enIsActive { No = 0, Yes = 1 }

        int InternationalLicenseID
        {
            get
            {
                return (int)dgvInterLicenses.CurrentRow.Cells[0].Value;
            }
        }
        string NationalNo
        {
            get
            {
                return clsInternationalLicenses.GetNationalNo(InternationalLicenseID);
            }
        }
        int PersonID
        {
            get
            {
                return clsPeople.GetPersonID(NationalNo);
            }
        }

        void ReLoadDgv()
        {
            // TODO: This line of code loads data into the 'dsInternational_Licenses.InternationalLicenses' table. You can move, or remove it, as needed.
            this.internationalLicensesTableAdapter.Fill(this.dsInternational_Licenses.InternationalLicenses);
          
            labRecordCount.Text = dgvInterLicenses.Rows.Count.ToString();
        }

        void _dgvInterAppsFilter(string ColumnName, int FilterValue)
        {
            internationalLicensesBindingSource.Filter = $"{ColumnName} = '{FilterValue}'";
        }


        void ApplyFilter()
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text) && tbFilterValue.Visible)
            {
                internationalLicensesBindingSource.Filter = "";
                return;
            }


            string FilterValue = tbFilterValue.Text;

            switch (cbInterAppsFilter.SelectedIndex)
            {
                case (int)enInterAppsFilter.None:

                    internationalLicensesBindingSource.Filter = "";
                    break;

                case (int)enInterAppsFilter.InterLicenseID:

                    if (int.TryParse(FilterValue, out int InterLicenseID))
                        _dgvInterAppsFilter("InternationalLicenseID", InterLicenseID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enInterAppsFilter.ApplicationID:

                    if (int.TryParse(FilterValue, out int ApplicationID))
                        _dgvInterAppsFilter("ApplicationID", ApplicationID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enInterAppsFilter.DriverID:

                    if (int.TryParse(FilterValue, out int DriverID))
                        _dgvInterAppsFilter("DriverID", DriverID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enInterAppsFilter.LocalLicenseID:

                    if (int.TryParse(FilterValue, out int LocalLicenseID))
                        _dgvInterAppsFilter("IssuedUsingLocalLicenseID", LocalLicenseID);
                    else
                        tbFilterValue.Text = "";

                    break;

            }
        }

        //! Healper Methods

        private void frmManageInternationalLicensesApplications_Load(object sender, EventArgs e)
        {
            ReLoadDgv();
            clsGlobalSettings.NormalizeForm(this);
        }

        private void btnAddNewInterLicense_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewInternationlDrivingLicense();

            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbInterAppsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInterAppsFilter.SelectedIndex == (int)enInterAppsFilter.None
                || cbInterAppsFilter.SelectedIndex == (int)enInterAppsFilter.IsActive)
                tbFilterValue.Visible = false;
            else
                tbFilterValue.Visible = true;

            if (cbInterAppsFilter.SelectedIndex == (int)enInterAppsFilter.IsActive)
            {
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
                cbIsActive.Visible = false;

        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActive.SelectedIndex)
            {
                case (int)enIsActive.No:

                    internationalLicensesBindingSource.Filter = $"IsActive = false";
                    break;

                case (int)enIsActive.Yes:

                    internationalLicensesBindingSource.Filter = $"IsActive = true";
                    break;

            }


        }

        //! Context Menue Items 
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonLicenseHistory(PersonID);

            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowDriverInterLicenseInfo(InternationalLicenseID);

            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo(PersonID);

            frm.ShowDialog();
        }

    }
}
