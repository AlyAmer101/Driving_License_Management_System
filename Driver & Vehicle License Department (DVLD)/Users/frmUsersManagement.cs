using DVLD.Properties;
using DVLD.General_Classes;
using DVLD.Properties;
using DVLD.Users;
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

namespace DVLD.Users
{
    public partial class frmUsersManagement : Form
    {
        //! Starting Methods
        public frmUsersManagement()
        {
            InitializeComponent();
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            // TODO: This line of code loads data into the 'dsUsers2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsUsers2.Users);

            cbUsersFilter.SelectedIndex = 0;
            labRecordCount.Text = dgvUsers.Rows.Count.ToString();

            //! Load ContextMenue Images 
            MenueItemShowDetails.Image = Resources.PersonDetails_32;
            MenueItemEdit.Image = Resources.edit_32;
            MenueItemDelete.Image = Resources.Delete_32;
            MenueItemSendEmail.Image = Resources.send_email_32;
            MenueItemCallPhone.Image = Resources.call_32;
            MenueItemAddNewUser.Image = Resources.Add_New_User_32;
            MenueItemChangePassword.Image = Resources.Password_32;
        }


        //! My Methods
        enum enUsersFilter { None, UserID, UserName, PersonID, FullName, IsActive }
        enum enIsActive { All, Yes, No }

        private int _PersonID
        {
            get
            {
                return (int)dgvUsers.CurrentRow.Cells[1].Value;
            }
        }
        private int _UserID
        {
            get
            {
                return (int)dgvUsers.CurrentRow.Cells[0].Value;
            }
        }

        void _RefreashUsersDgv()
        {
            this.usersTableAdapter.Fill(this.dsUsers2.Users);
        }

        // String Filter
        void _dgvUsersFilter(string ColumnName, string FilterValue)
        {
            usersBindingSource.Filter = $"{ColumnName} LIKE '{FilterValue}%'";
        }
        
        // Int Filter
        void _dgvUsersFilter(string ColumnName, int FilterValue)
        {
            usersBindingSource.Filter = $"{ColumnName} = '{FilterValue}'";
        }
      
        // IsActive Filter 
        void _dgvUsersFilter(enIsActive FilterValue)
        {
            switch (FilterValue)
            {
                case enIsActive.All:

                    usersBindingSource.Filter = "";

                    break;

                case enIsActive.Yes:

                    usersBindingSource.Filter = $"IsActive = true";

                    break;

                case enIsActive.No:

                    usersBindingSource.Filter = $"IsActive = false";

                    break;
            }

        }

        void _ApplyFilter()
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text) && tbFilterValue.Visible)
            {
                usersBindingSource.Filter = "";
                return;
            }

            string FilterValue = tbFilterValue.Text;

            switch (cbUsersFilter.SelectedIndex)
            {

                case (int)enUsersFilter.None:

                    usersBindingSource.Filter = "";
                    tbFilterValue.Visible = false;

                    break;

                case (int)enUsersFilter.UserID:

                    if (int.TryParse(FilterValue, out int UserID))
                        _dgvUsersFilter("UserID", UserID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enUsersFilter.UserName:

                    _dgvUsersFilter("UserName", FilterValue);

                    break;

                case (int)enUsersFilter.PersonID:

                    if (int.TryParse(FilterValue, out int PersonID))
                        _dgvUsersFilter("PersonID", PersonID);
                    else
                        tbFilterValue.Text = "";

                    break;

                case (int)enUsersFilter.FullName:

                    _dgvUsersFilter("FullName", FilterValue);

                    break;

                case (int)enUsersFilter.IsActive:

                    _dgvUsersFilter((enIsActive)cbIsActive.SelectedIndex);

                    break;

            }
        }

        //! Healper Methods

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //! dgvUsers Filter 

        private void cbUsersFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsersFilter.SelectedIndex == (int)enUsersFilter.None)
            {
                cbIsActive.Visible = false;
                tbFilterValue.Visible = false;
            }
            else if (cbUsersFilter.SelectedIndex == (int)enUsersFilter.IsActive)
            {
                tbFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                tbFilterValue.Visible = true;
                cbIsActive.Visible = false;
            }
        }

        private void tbFilterValue_TextChanged_1(object sender, EventArgs e)
        {
            _ApplyFilter();

            labRecordCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dgvUsersFilter((enIsActive)cbIsActive.SelectedIndex);
        }



        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            MenueItemAddNewUser_Click(null, null);
        }

        //! Context Menue Options Click
    
        private void MenueItemAddNewUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewUserr();

            frm.ShowDialog();

            _RefreashUsersDgv();
        }

        private void MenueItemDelete_Click(object sender, EventArgs e)
        {
            if (clsUsers.IsUserConnectedWithData(_UserID))
            {
                clsUtility.ErorrMessage("User is not delete due to data connected to it");
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete User [{_UserID}]", "Confirm Delelte", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUsers.DeleteUserByID(_UserID))
                {
                    MessageBox.Show("User Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreashUsersDgv();
                }
                else
                    MessageBox.Show("Faild To Delete User", "Failded Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Operation Canceled Successfully", "Canceld Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MenueItemEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewUserr(_UserID, _PersonID);

            frm.ShowDialog();
            _RefreashUsersDgv();

        }

        private void MenueItemCallPhone_Click(object sender, EventArgs e)
        {
            clsUtility.FeatureNotImplementedMessage();
        }

        private void MenueItemSendEmail_Click(object sender, EventArgs e)
        {
            clsUtility.FeatureNotImplementedMessage();
        }

        private void MenueItemShowDetails_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo(_PersonID, _UserID);

            frm.ShowDialog();

        }

        private void MenueItemChangePassword_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePassword(_UserID);

            frm.ShowDialog();
        }

        private void cmsMangeUsers_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
