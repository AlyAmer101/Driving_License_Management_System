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

namespace DVLD.Drivers
{
    public partial class frmDriverManagement : Form
    {
        public frmDriverManagement()
        {
            InitializeComponent();
        }

        private void frmDriverManagement_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);
            
            this.drivers_ViewTableAdapter.Fill(this.dsDrivers.Drivers_View);
            labRecordCount.Text = dgvDrivers.Rows.Count.ToString();
            cbDriversFilter.SelectedIndex = 0;
            tbFilterValue.Visible = false;
        }

        //! My Methods
        enum enDriversFilter { None, DriverID , PersonID, NationalNo, FullName }

        // String Filter
        void _dgvDriversFilter(string ColumnName, string FilterValue)
        {
            driversViewBindingSource.Filter = $"{ColumnName} LIKE '{FilterValue}%'";
        }

        // Int Filter
        void _dgvDriversFilter(string ColumnName, int FilterValue)
        {
            driversViewBindingSource.Filter = $"{ColumnName} = '{FilterValue}'";
        }

        void _ApplyFilter()
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text))
            {
                driversViewBindingSource.Filter = "";
                return;
            }

            string FilterValue = tbFilterValue.Text;

            
            switch (cbDriversFilter.SelectedIndex)
            {
                case (int)enDriversFilter.None:

                    driversViewBindingSource.Filter = "";

                    break;

                case (int)enDriversFilter.DriverID:

                    if (int.TryParse(FilterValue, out int DriverID))
                        _dgvDriversFilter("DriverID", DriverID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enDriversFilter.PersonID:

                    if (int.TryParse(FilterValue, out int PersonID))
                        _dgvDriversFilter("PersonID", PersonID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enDriversFilter.NationalNo:

                    _dgvDriversFilter("NationalNo", FilterValue);

                    break;

                case (int)enDriversFilter.FullName:

                    _dgvDriversFilter("FullName", FilterValue);

                    break;
            }


            
        }


        //! Healper Methods 


        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }


        private void cbDriversFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDriversFilter.SelectedIndex == (int)enDriversFilter.None)
                tbFilterValue.Visible = false;
            else
                tbFilterValue.Visible = true;

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
