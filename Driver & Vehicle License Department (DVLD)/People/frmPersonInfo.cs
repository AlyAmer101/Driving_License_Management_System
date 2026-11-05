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
using DVLD.General_Classes;
using DVLD.Properties;

namespace DVLD
{
    public partial class frmPersonInfo : Form
    {
        public frmPersonInfo(int PersonID)
        {
            InitializeComponent();

            ucPersonInfoInPersonalDetailsForm.LoadPersonInfo(PersonID);
            clsGlobalSettings.NormalizeForm(this);
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
