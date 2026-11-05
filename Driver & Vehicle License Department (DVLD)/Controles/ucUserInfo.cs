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

namespace DVLD.User_Controles
{
    public partial class ucUserInfo : UserControl
    {
        public ucUserInfo()
        {
            InitializeComponent();

        }

        public clsUsers User = new clsUsers();


        //! My Methods

        private void _FillLoginInfoCardFromObject(clsUsers User)
        {
            labUserIDValue.Text = User.UserID.ToString();
            labUsernameValue.Text = User.UserName;
            labIsActiveValue.Text = (User.IsActive == true ? "Yes" : "No");
        }

        public void LoadUserInfo(int UserID)
        {
            User = clsUsers.GetUserByID(UserID);

            _FillLoginInfoCardFromObject(User);

        }



        private void gbLogInInfo_Enter(object sender, EventArgs e)
        {

        }


    }
}
