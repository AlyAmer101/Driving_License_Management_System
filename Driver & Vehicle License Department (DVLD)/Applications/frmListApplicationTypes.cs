using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.Properties;
using System.Windows.Forms;
using DVLD.General_Classes;

namespace DVLD.Applications.Manage_Applications
{
    public partial class frmListApplicationTypes : Form
    {
        void _RefreshDgv()
        {
            this.applicationTypesTableAdapter.Fill(this.dsApplicationTypes.ApplicationTypes);
        }

        public frmListApplicationTypes()
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);
        }

        private void frmListApplicationTypes_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsApplicationTypes.ApplicationTypes' table. You can move, or remove it, as needed.

            _RefreshDgv();

            labRecordCount.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrentAppTypeID = Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value);
            string CurrentAppTypeTitle = dgvApplicationTypes.CurrentRow.Cells[1].Value.ToString();
            double CurrentAppTypeFees = Convert.ToDouble(dgvApplicationTypes.CurrentRow.Cells[2].Value);

            Form frm = new frmUpdateApplicationType(CurrentAppTypeID, CurrentAppTypeTitle, CurrentAppTypeFees);

            frm.ShowDialog();

            _RefreshDgv();

        }


    }
}
