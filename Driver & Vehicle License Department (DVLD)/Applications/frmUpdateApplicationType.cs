using DVLD.General_Classes;
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

namespace DVLD.Applications.Manage_Applications
{
    public partial class frmUpdateApplicationType : Form
    {

        int AppTypeID = -1;

        void InvalidDatadNotifycation()
        {
            notifyInvalidDataType.Icon = Properties.Resources.FormIcon;
            notifyInvalidDataType.BalloonTipIcon = ToolTipIcon.Error;
            notifyInvalidDataType.BalloonTipTitle = "You Are Setting Invlid Data";
            notifyInvalidDataType.BalloonTipText = "Set a Numerical Value In Test Fees TextBox, Not Anything Else.";
            notifyInvalidDataType.ShowBalloonTip(1000);
        }

        public frmUpdateApplicationType(int AppTypeID, string AppTypeTitle, double AppTypeFees)
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);
            
            this.AppTypeID = AppTypeID;

            //! Load App Type Data
            labIdValue.Text = AppTypeID.ToString();
            tbTitle.Text = AppTypeTitle;
            tbFees.Text = AppTypeFees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool SavingResult = clsApplicationsTypes.UpdateApplicationTypeByID(AppTypeID, tbTitle.Text, Convert.ToDouble(tbFees.Text));

            if (SavingResult)
            {
                clsUtility.InfoMessage("Data Updated Successfully.");
                this.Close();
            }
            else
                clsUtility.ErorrMessage("Falid To Update Data.");

        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(tbFees.Text, out double TestFees))
            {
                clsUtility.InvalidDatadNotifycation(notifyInvalidDataType);
                tbFees.Text = "";
            }
        }


    }
}
