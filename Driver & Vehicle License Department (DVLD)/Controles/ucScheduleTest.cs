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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.User_Controles
{
    public partial class ucScheduleTest : UserControl
    {
        public int PaidFees = -1;
        public  bool IsFormLocked { set; get; }

        public clsUtility.enVisionTestMode TestMode { set; get; }

        public DateTime TestDate 
        {
            get { return dtpDate.Value; }
        }
        
        public void SetTestDate(DateTime Value)
        {
            dtpDate.Value = Value;
            labDateValue.Text = Value.ToString(clsUtility.DateFormat, System.Globalization.CultureInfo.InvariantCulture);
        }

        public ucScheduleTest()
        {
            InitializeComponent();

            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = clsUtility.DateFormat;

            clsUtility.HandleFormWithActiveTestType(pbFormLogo, FormTitle);
        }


        public void HandleFormUiWithCurrentMode()
        {
            switch (TestMode)
            {
                case clsUtility.enVisionTestMode.Normal:

                    FormTitle.Text = "Schedule Test";
                    labSubTitle.Visible = false;
                    dtpDate.Enabled = true;

                    //! Aligning Header
                    pbFormLogo.Location = new Point(200, 25);
                    FormTitle.Location = new Point(179, 195);
                    labSubTitle.Location = new Point(102, 243);

                    break;

                case clsUtility.enVisionTestMode.Retake:
                    
                    FormTitle.Text = "Schedule Retake Test";

                    dtpDate.Enabled = true;
                    labSubTitle.Visible = false;
                    
                    //! Aligning Header
                    pbFormLogo.Location = new Point(181, 25);
                    FormTitle.Location = new Point(100, 195);

                    break;

                case clsUtility.enVisionTestMode.Locked:
                    
                    FormTitle.Text = "Schedule Retake Test";

                    dtpDate.Enabled = false;
                    labSubTitle.Visible = true;
                    
                    //! Aligning Header
                    pbFormLogo.Location = new Point(181, 25);
                    labSubTitle.Location = new Point(83, 243);
                    FormTitle.Location = new Point(100, 195);

                    break;



            }

        }

        public void LoadInfo(int LDLAppID ,string ClassName)
        {
            int Fees = clsTestTypes.GetTestFeesByTestTypeID((int)clsGlobalSettings.CurrentActiveTestType);
            int AppID = clsLocalDrivingLicenseApplications.GetAppID_By_LDLAppID(LDLAppID);
            int PersonID = clsApplications.GetPersonIdByAppID(AppID);

            labLDLAppIDValue.Text = LDLAppID.ToString();
            labClassValue.Text = ClassName;
            labNameValue.Text = clsPeople.GetFullName(PersonID);
            labTrialValue.Text = clsTestAppointments.GetTestTriesCountByLDLAppID(LDLAppID, (int)clsGlobalSettings.CurrentActiveTestType).ToString();
            labFeesValue.Text = Fees.ToString();

            this.PaidFees = Fees;
        }

        public void EnableReadOnlyMode()
        {
            dtpDate.Visible = false;
            labDateValue.Visible = true;
        }

        void Clear()
        {
            labLDLAppIDValue.Text = "";
            labClassValue.Text = "";
            labNameValue.Text = "";
            labTrialValue.Text = "";
            labFeesValue.Text = "";

            dtpDate.Value = DateTime.Today;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            SetTestDate(dtpDate.Value);
        }

        private void dtpDate_Enter(object sender, EventArgs e)
        {
            dtpDate.MinDate = DateTime.Today;
        }

        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            //dtpDate.MinDate = DateTime.MinValue;
        }

        private void labTrialValue_Click(object sender, EventArgs e)
        {

        }
    }
}
