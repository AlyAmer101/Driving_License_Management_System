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
using DVLD.Properties;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_TestTypes
{
    public partial class frmUpdateTestType : Form
    {
        
        int TestTypeID = -1;

        public frmUpdateTestType(int TestTypeID, string TestTypeTitle, string DescriptionTypeTitle, double TestTypeFees)
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);

            this.TestTypeID = TestTypeID;

            //! Load App Type Data
            labIdValue.Text = TestTypeID.ToString();
            tbTitle.Text = TestTypeTitle;
            tbDescription.Text = DescriptionTypeTitle;
            tbFees.Text = TestTypeFees.ToString();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            bool SavingResult = clsTestTypes.UpdateTestTypesByID(TestTypeID, tbTitle.Text, tbDescription.Text, Convert.ToDouble(tbFees.Text));

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
                tbFees.Text = "";
                clsUtility.InvalidDatadNotifycation(notifyInvalidDataType);
            }


        }

      
    }
}
