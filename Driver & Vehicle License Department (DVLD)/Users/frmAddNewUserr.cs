using DVLD.General_Classes;
using DVLD;
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
using static DVLD___BusinessLayer.clsPeople;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.Users
{
    public partial class frmAddNewUserr : Form
    {
        //! Starting Methods
        public frmAddNewUserr()
        {
            InitializeComponent();

            
            clsGlobalSettings.NormalizeForm(this);
            ucPersonInfo1.VisiblingEditPersonalInfoButton(false);
        }

        public frmAddNewUserr(int UserID, int PersonID) : this()
        {

            labFormTitle.Text = "Update User";
            gbSearcher.Enabled = false;
            _canChangeTab = true;

            User = clsUsers.GetUserByID(UserID);
            User.PersonID = PersonID;

            _FillFormFromUserObject();

            ucPersonInfo1.LoadPersonInfo(PersonID);
            tcAddNewUser.SelectTab(1);
            btnSave.Enabled = true;
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            cbPeopleSearcher.SelectedIndex = (int)enPeopleSearcher.NationalNo;
        }


        //! My Methods

        enum enPeopleSearcher { NationalNo, PersonID };

        bool _canChangeTab = false;

        clsUsers User = new clsUsers();
        
        void _FillUserObjectFromForm()
        {
            User.PersonID = ucPersonInfo1.PersonID;

            User.UserName = tbUserName.Text;
            User.Password = tbPassword.Text;

            User.IsActive = cbIsActive.Checked;

            User.Mode = clsUsers.enMode.Update;
        }

        void _FillFormFromUserObject()
        {
            labUserIDValue.Text = User.UserID.ToString();

            tbUserName.Text = User.UserName;
            
            tbPassword.Text = User.Password;
            tbConfirmPassword.Text = User.Password;

            cbIsActive.Checked  = User.IsActive;

        }



        public void Save()
        {
            switch (User.Mode)
            {

                case clsUsers.enMode.AddNew:

                    _FillUserObjectFromForm();
                    User.UserID = clsUsers.AddNewUser(User);

                    if (User.UserID != -1)
                    {
                        MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labUserIDValue.Text = User.UserID.ToString();
                        labFormTitle.Text = "Update User";
                    }
                    else
                        MessageBox.Show("Faild To Save Data", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

                case clsUsers.enMode.Update:

                    _FillUserObjectFromForm();

                    if (clsUsers.UpdateUser(User.UserID ,User.UserName, User.Password, User.IsActive))
                    {
                        MessageBox.Show("Data Updated Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                    }
                    else
                        MessageBox.Show("Faild To Save Data", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

            }
        }

        //! tbUserName_Validating
        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);

            if (clsUsers.IsUserNameExist(tbUserName.Text))
            {
                e.Cancel = true;
                tbUserName.Focus();
                epEmptyTextBox.SetError(tbUserName, "Taken Username, Write Another One");

            }

        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }
        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text != tbPassword.Text)
            {
                e.Cancel = true;
                tbConfirmPassword.Focus();
                epConfirmPassword.SetError(tbConfirmPassword, "Password Confirmation does not match Password");
            }
            else
            {
                e.Cancel = false;
                epEmptyTextBox.SetError(tbConfirmPassword, "");
            }
        }

        //! Healper Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == string.Empty || tbPassword.Text == string.Empty || tbConfirmPassword.Text == string.Empty || tbConfirmPassword.Text != tbPassword.Text)
                MessageBox.Show("Compelet All Your Data", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Save();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _canChangeTab = false;

            switch (cbPeopleSearcher.SelectedIndex)
            {
                case (int)enPeopleSearcher.NationalNo:

                    string NationalNo = tbSearchValue.Text;
                    if (clsPeople.IsNationalNoExist(NationalNo))
                    {
                        btnNext.Enabled = true;
                        ucPersonInfo1.LoadPersonInfo(NationalNo);
                        ucPersonInfo1.VisiblingEditPersonalInfoButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ucPersonInfo1.Clear();
                    }

                    break;

                case (int)enPeopleSearcher.PersonID:

                    ucPersonInfo1.PersonID = Convert.ToInt32(tbSearchValue.Text);
                    if (clsPeople.IsPersonIDExist(ucPersonInfo1.PersonID))
                    {
                        btnNext.Enabled = true;
                        ucPersonInfo1.LoadPersonInfo(ucPersonInfo1.PersonID);
                        ucPersonInfo1.VisiblingEditPersonalInfoButton(true);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ucPersonInfo1.Clear();
                    }

                    break;
            }


        }

        private void cbPeopleSearcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //! Require user to input Numbric Value in tbSearchValue 
            if (cbPeopleSearcher.SelectedIndex == (int)enPeopleSearcher.PersonID)
            {
                tbSearchValue.Text = "";
                if (!int.TryParse(tbSearchValue.Text, out int result))
                    tbSearchValue.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            int PersonID = ucPersonInfo1.PersonID;

            if (!clsPeople.IsPersonSystemUser(PersonID))
            {
                tcAddNewUser.SelectTab(1);
                _canChangeTab = true;
                btnSave.Enabled = true;
            }
            else
                MessageBox.Show("Selected Person already has a user, Choose another one.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddPerson();

            frm.ShowDialog();
        }

        private void tcAddNewUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !(_canChangeTab);
        }



    }
}
