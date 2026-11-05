using DVLD.General_Classes;
using DVLD___BusinessLayer;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsGlobalSettings.NormalizeForm(this);

            Directory.CreateDirectory(@"C:\DVLD-Files");

            if (File.Exists(RemeberMe_FilePath))
                _FillLoginScreenFromFile();
        }

        //! My Methods

        string RemeberMe_FilePath = @"C:\DVLD-Files\Remeberme.txt";
        char LoginRecordSeparator = '.';

        void _SaveLoginInfoInRemeberMeFile()
        {
            string LoginRecord = tbUsername.Text + LoginRecordSeparator + tbPassword.Text;
        
            File.WriteAllText(RemeberMe_FilePath, LoginRecord);
        }
 
        void _DeleteRemeberMeFile()
        {
            File.Delete(RemeberMe_FilePath);
        }

        void _FillLoginScreenFromFile()
        {
            string LoginRecord = File.ReadAllText(RemeberMe_FilePath);
            string[] LoginInfo = LoginRecord.Split(LoginRecordSeparator);

            tbUsername.Text = LoginInfo[0];
            tbPassword.Text = LoginInfo[1];
            cbRememberMe.Checked = true;

        }

        void _OpenMainFormScreen()
        {
            this.Hide();

            Form frm = new frmMain(this);
            frm.ShowDialog();
            
        }
       

        //! Validating 
        private void tbUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }
        private void tbPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsUtility.TextBoxEmptyValidation(sender, e, epEmptyTextBox);
        }

        
        //! Helper Methods  (On Clicks, On Changed, etc..)
        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbRememberMe.Checked)
                _SaveLoginInfoInRemeberMeFile();
            else
                _DeleteRemeberMeFile();

            int UserID = clsUsers.CheckUsernameAndPassword(tbUsername.Text, tbPassword.Text);

            if (UserID != -1)
            {
                if (clsUsers.IsUserActive(UserID))
                {
                    clsGlobalSettings.CurrentUser = clsUsers.GetUserByID(UserID);
                    clsGlobalSettings.CurrentUser.PersonInfo = clsPeople.GetPersonByID(clsUsers.GetPersonIdByUserID(UserID));

                    _OpenMainFormScreen();
                }
                else
                    MessageBox.Show("Your Account De-Activeted Please Contact Your Admin", "Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
                MessageBox.Show("Not Found, Invalid Username or Password", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }


    }
}
