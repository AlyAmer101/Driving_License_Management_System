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

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {
        int UserID = -1;
        clsUsers User = new clsUsers();
       
        public frmChangePassword( int UserID)
        {
            InitializeComponent();

            this.UserID = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            ucLoginInfo.LoadUserInfo(clsGlobalSettings.CurrentUser.UserID);
            ucPersonalnfo.LoadPersonInfo(clsGlobalSettings.CurrentUser.PersonInfo.ID);
        }


        //! Validating
        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }

        private void tbConfirmPasswrod_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);


            //! Validating if Password Matching or not 
            
            btnSave.Enabled = true;

            if (tbConfirmPasswrod.Text != tbNewPassword.Text)
            {
                e.Cancel = true;
                tbConfirmPasswrod.Focus();
                epEmptyTextBox.SetError(tbConfirmPasswrod, "Password Not Matching");

                btnSave.Enabled = false;
            }
            else
            {
                e.Cancel = false;
                epEmptyTextBox.SetError(tbConfirmPasswrod, "");

                btnSave.Enabled = true;
            }
        }

        //! Healper Methods

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ucLoginInfo.User.Password != tbCurrentPassword.Text)
            {
                clsUtility.ErorrMessage("Invalid Current Passowrd, Try Again.");
                return;
            }
            else
            {
                if (clsUsers.ChangePassword(UserID, tbNewPassword.Text))
                    clsUtility.InfoMessage("Password Changed Successfully.");
                else
                    clsUtility.ErorrMessage("Faild To Change Password");
            }


            User = clsUsers.GetUserByID(UserID);
        }

     
    }
}
