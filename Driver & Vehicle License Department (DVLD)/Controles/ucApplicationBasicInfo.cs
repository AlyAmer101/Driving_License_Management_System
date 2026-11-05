using DVLD.General_Classes;
using DVLD.Properties;
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
    public partial class ucApplicationBasicInfo : UserControl
    {
        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }

        //! My Methods
        public int ApplicationID { set; get; }
        public int ApplicationPersonID { set; get; }

        clsApplications Application = new clsApplications();


        private void FillAppInfoCardFromObject(clsApplications Application)
        {
            labIDValue.Text = Application.ApplicationID.ToString();
            labStatusValue.Text = clsUtility.GetStatusName(Application.ApplicationStatus);
            labFeesValue.Text = Application.PaidFees.ToString();
            labTypeValue.Text = clsApplicationsTypes.GetApplicationTypeNameByID(Application.ApplicationTypeID); 
            labDateValue.Text = Application.ApplicationDate.ToShortDateString();
            labStatusDateValue.Text = Application.LastStatusDate.ToShortDateString();
            labApplicantValue.Text = clsPeople.GetFullName(Application.ApplicationPersonID);
            labCreatedByValue.Text = clsUsers.GetUserNameByID(Application.CreatedByUserID);
        }


        public void LoadApplicationInfo(int ApplicationID)
        {
            Application = clsApplications.GetApplicationByID(ApplicationID);

            FillAppInfoCardFromObject(Application);

            ApplicationPersonID = Application.ApplicationPersonID;
            clsGlobalSettings.CurrentPersonId = Application.ApplicationPersonID;
        }

        public void Clear()
        {
            labIDValue.Text = "-1";
            labStatusValue.Text = "??";
            labFeesValue.Text = "??";
            labTypeValue.Text = "??";
            labApplicantValue.Text = "??";
            labDateValue.Text = "??";
            labStatusDateValue.Text = "??";
            labCreatedByValue.Text = "??";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = Application.ApplicationPersonID;

            Form frm = new frmPersonInfo(PersonID);

            frm.ShowDialog();
        }

    }
}
