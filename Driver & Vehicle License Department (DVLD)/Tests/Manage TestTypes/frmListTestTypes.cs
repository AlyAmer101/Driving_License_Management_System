using DVLD.Applications.Manage_Applications;
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

namespace DVLD.Applications.Manage_TestTypes
{
    public partial class frmListTestTypes : Form
    {
        void _RefreshDgv()
        {
            this.testTypesTableAdapter.Fill(this.dsTestTypes.TestTypes);
        }

        public frmListTestTypes()
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);
        }


        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshDgv();

            labRecordCount.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUpdateTestType
                (
                  Convert.ToInt32(dgvTestTypes.CurrentRow.Cells[0].Value)   // CurrentTestTypeID
                , dgvTestTypes.CurrentRow.Cells[1].Value.ToString()         // CurrentTestTypeTitle
                , dgvTestTypes.CurrentRow.Cells[2].Value.ToString()         // CurrentDescriptionTypeTitle
                , Convert.ToDouble(dgvTestTypes.CurrentRow.Cells[3].Value)  // CurrentTestTypeFees
                );

            frm.ShowDialog();

            _RefreshDgv();
        }


    }
}
