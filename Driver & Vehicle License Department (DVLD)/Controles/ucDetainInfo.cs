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

namespace DVLD.User_Controles
{
    public partial class ucDetainInfo : UserControl
    {
        public ucDetainInfo()
        {
            InitializeComponent();

            LoadBasicInfo();
        }

        public int FineFees
        {
            get
            {
                if (!string.IsNullOrEmpty(tbFineFees.Text))
                    return Convert.ToInt32(tbFineFees.Text);

                return -1;
            }
        }


        void LoadBasicInfo()
        {
            labCreatedByValue.Text = clsGlobalSettings.CurrentUser.UserName;
            labDetainDateValue.Text = DateTime.Today.ToString(clsUtility.DateFormat);
        }
        public void LoadLicenseID(int LicenseId)
        {
            labLicenseIDValue.Text = LicenseId.ToString();
        }
        public void LoadDetainID(int DetainId)
        {
            labDetainIDValue.Text = DetainId.ToString();
        }


        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            clsUtility.TextBoxNumuberValidation(sender, e, epEmptyTextBox);
        }

        private void tbFineFees_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tbFineFees.Text, out int result))
                tbFineFees.Text = "";
        }
    }
}
