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

namespace DVLD.Applications.Manage_Local_Driving_Licenses_Applications.Show_Person_License_History
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);
            
            ucPersonInfo1.LoadPersonInfo(PersonID);
        }


    }
}
