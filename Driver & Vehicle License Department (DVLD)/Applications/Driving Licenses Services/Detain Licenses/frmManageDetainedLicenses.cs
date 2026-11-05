using DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_License;
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

namespace DVLD.Applications.Driving_Licenses_Services.Detain_Licenses
{
    public partial class frmManageDetainedLicenses : Form
    {
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        //! My Methods
        void ReLoadDgv()
        {
            this.detainedLicenses_ViewTableAdapter.Fill(this.dsDetainedLicenses.DetainedLicenses_View);
            labRecordCount.Text = dgvDetainedLicenses.Rows.Count.ToString();

            cbLicensesFilter.SelectedIndex = 0;
        }

        enum enDetainedLicensesFilter { None, DetainID, LicenseID, NationalNo, FullName, IsRelease }

        int LicenseID
        {
            get
            {
                return Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            }
        }
        bool IsRelease
        {
            get
            {
                return (bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value;
            }
        }
      
        string NationalNo
        {
            get
            {
                return dgvDetainedLicenses.CurrentRow.Cells["nationalNoDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        // String Filter
        void _dgvDetainedLicensesFilter(string ColumnName, string FilterValue)
        {
            detainedLicensesViewBindingSource.Filter = $"{ColumnName} LIKE '{FilterValue}%'";
        }

        // Int Filter
        void _dgvDetainedLicensesFilter(string ColumnName, int FilterValue)
        {
            detainedLicensesViewBindingSource.Filter = $"{ColumnName} = '{FilterValue}'";
        }

        void ApplyFilter()
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text) && tbFilterValue.Visible)
            {
                detainedLicensesViewBindingSource.Filter = "";
                return;
            }


            string FilterValue = tbFilterValue.Text;

            switch (cbLicensesFilter.SelectedIndex)
            {
                case (int)enDetainedLicensesFilter.None:

                    detainedLicensesViewBindingSource.Filter = "";
                    break;

                case (int)enDetainedLicensesFilter.DetainID:

                    if (int.TryParse(FilterValue, out int DetainID))
                        _dgvDetainedLicensesFilter("DetainID", DetainID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enDetainedLicensesFilter.LicenseID:

                    if (int.TryParse(FilterValue, out int LicenseID))
                        _dgvDetainedLicensesFilter("LicenseID", LicenseID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enDetainedLicensesFilter.NationalNo:

                    _dgvDetainedLicensesFilter("NationalNo", FilterValue);

                    break;

                case (int)enDetainedLicensesFilter.FullName:

                    _dgvDetainedLicensesFilter("FullName", FilterValue);

                    break;

            }


        }

        //! Healper Methods
        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            ReLoadDgv();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDetain_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainAndReleaseLicenses(clsUtility.enDetainOrRelease.Detain);

            frm.ShowDialog();
            ReLoadDgv();
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainAndReleaseLicenses(clsUtility.enDetainOrRelease.Release);

            frm.ShowDialog();
            ReLoadDgv();
        }



        private void cms_DetainedLicenses_Opening(object sender, CancelEventArgs e)
        {
            if (IsRelease)
                releaseDetainedLicToolStripMenuItem.Enabled = false;
            else
                releaseDetainedLicToolStripMenuItem.Enabled = true;
        }

     
        private void showPersonDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo(clsPeople.GetPersonID(NationalNo));

            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowDriverLicenseInfo(LicenseID);

            frm.ShowDialog();
        }

        private void showPersonLicensesHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonLicenseHistory(clsPeople.GetPersonID(NationalNo));

            frm.ShowDialog();
        }

        private void releaseDetainedLicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDetainAndReleaseLicenses(clsUtility.enDetainOrRelease.Release, LicenseID);

            frm.ShowDialog();
            ReLoadDgv();
        }


        // Filter 
        private void cbLicensesFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Text = "";

            if (cbLicensesFilter.SelectedIndex == (int)enDetainedLicensesFilter.None)
            {
                tbFilterValue.Visible = false;
            }
            else
                tbFilterValue.Visible = true;
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }


    }
}
