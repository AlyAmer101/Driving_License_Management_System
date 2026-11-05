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

namespace DVLD.Applications.Driving_Licenses_Services.New_Driving_Licenses
{
    public partial class frmAddNewLocalDrivingLicense : Form
    {
        public frmAddNewLocalDrivingLicense()
        {
            InitializeComponent();

            clsGlobalSettings.NormalizeForm(this);
            ucPersonInfo1.VisiblingEditPersonalInfoButton(false);

            HandleFormWithCurrentMode();

        }

        public frmAddNewLocalDrivingLicense(int PersonID, int LDLAppID, clsApplications.enMode AppMode = clsApplications.enMode.Update, bool EnableSearcher = false) : this()
        {
            ucPersonInfo1.LoadPersonInfo(PersonID);

            gbSearcher.Enabled = EnableSearcher;
            Application.Mode = AppMode;

            btnNext.Enabled = true;
            btnSave.Enabled = true;
            _canChangeTab = true;

            LDL_ApplicationID = LDLAppID;

            labLDL_AppID.Text = LDLAppID.ToString();
        }

        private void frmLocalLicense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsLicenseClasses.LicenseClasses' table. You can move, or remove it, as needed.
            this.licenseClassesTableAdapter.Fill(this.dsLicenseClasses.LicenseClasses);

            cbLicenseClasses.SelectedIndex = 2;
            cbPeopleSearcher.SelectedIndex = (int)enPeopleSearcher.NationalNo;


            LoadAppInfo();
        }



        //! My Methods

        enum enPeopleSearcher { NationalNo, PersonID };
        

        bool _canChangeTab = false;

        int ApplicationID = -1; 
        int LDL_ApplicationID = -1;


        clsApplications Application = new clsApplications();


        void LoadAppInfo()
        {
            int AppTypeID = (int)clsUtility.enApplicationTypes.New_Local_Driving_License_Service;
            int AppFees = clsApplicationsTypes.GetApplicationTypeFeesByID(AppTypeID);

            labAppDate.Text = DateTime.Today.ToShortDateString();
            labAppFees.Text = AppFees.ToString();
            labCreatedBy.Text = clsGlobalSettings.CurrentUser.UserName;
        }

        void FillApplicationObject(clsApplications Applicaton)
        {
            Applicaton.ApplicationPersonID = clsGlobalSettings.CurrentPersonId;
            Applicaton.ApplicationTypeID = (int)clsUtility.enApplicationTypes.New_Local_Driving_License_Service;
            Applicaton.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            Applicaton.ApplicationDate = DateTime.Today;
            Applicaton.LastStatusDate = DateTime.Today;
            Applicaton.ApplicationStatus = (int)clsUtility.enApplicationStatus.New;
            Applicaton.PaidFees = Convert.ToInt32(labAppFees.Text);
        }

        void FillLDL_ApplicatonObject(clsLocalDrivingLicenseApplications LDL_Applicaton)
        {
            LDL_Applicaton.ApplicationID = ApplicationID;
            LDL_Applicaton.LicenseClassID = (int)cbLicenseClasses.SelectedValue;
        }

        void AddNewApplication()
        {
            FillApplicationObject(Application);
            ApplicationID = clsApplications.AddNewApplication(Application);
        }

        void AddNewLDL_Application()
        {
            clsLocalDrivingLicenseApplications LDL_Applicaton = new clsLocalDrivingLicenseApplications();
            FillLDL_ApplicatonObject(LDL_Applicaton);
            LDL_ApplicationID = clsLocalDrivingLicenseApplications.AddNewLDL_Application(LDL_Applicaton);
        }

        void HandleFormWithCurrentMode()
        {
            switch (Application.Mode)
            {
                case clsApplications.enMode.AddNew:
                    labFormTitle.Text = "New Local Driving License Application";
                    break;

                case clsApplications.enMode.Update:
                    labFormTitle.Text = "Update Local Driving License Application";
                    break;
            } 
        }


        void Save()
        {

            if (clsLicenses.IsPersonHaveLicenseInThisClass(clsGlobalSettings.CurrentPersonId, (int)cbLicenseClasses.SelectedValue))
            {
                clsUtility.ErorrMessage($"Person already have a license with the same applied driving class, Choose diffrent driving class.");
                return;
            }


            switch (Application.Mode)
            {
                case clsApplications.enMode.AddNew:

                    int ValidatingResult = clsLocalDrivingLicenseApplications.IsPersonHaveNewApplicationOnThisLicenseClass(clsGlobalSettings.CurrentPersonId, (int)cbLicenseClasses.SelectedValue);

                    if (ValidatingResult != -1)
                    {
                        clsUtility.ErorrMessage($"Choose Another License Class, Because The Selected Person Already Have an Active (Un-Compeleted, Un-Canceled) Application for the selected class with id = {ValidatingResult}.");
                        return;
                    }

                    AddNewApplication();

                    if (ApplicationID != -1)
                    {
                        AddNewLDL_Application();

                        if (LDL_ApplicationID != -1)
                        {
                            clsUtility.InfoMessage("Data Saved Successfully.");

                            labLDL_AppID.Text = LDL_ApplicationID.ToString();
                            Application.Mode = clsApplications.enMode.Update;
                        }
                        else
                            clsUtility.ErorrMessage("Failed To Save The Local Driving License Application.");

                    }
                    else
                        clsUtility.ErorrMessage("Failed To Save The Application.");

                    break;


                case clsApplications.enMode.Update:

                    ValidatingResult = clsLocalDrivingLicenseApplications.IsPersonHaveNewApplicationOnThisLicenseClass(clsGlobalSettings.CurrentPersonId, (int)cbLicenseClasses.SelectedValue);

                    if (ValidatingResult != -1)
                    {
                        clsUtility.ErorrMessage($"Choose Another License Class, The Selected Person Already Have an Active Application for the selected class with id = {ValidatingResult}.");
                        return;
                    }

                    if (clsLocalDrivingLicenseApplications.UpdateLicenseClassID(LDL_ApplicationID, (int)cbLicenseClasses.SelectedValue))
                    {
                        clsUtility.InfoMessage("Updated Data Successfully");
                        this.Close();
                    }
                    else
                        clsUtility.ErorrMessage("Failed To Update Data.");

                    break;

            }

            HandleFormWithCurrentMode();
        }


        //! Healper Methods

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
                return;

            _canChangeTab = false;

            Application.Clear();
            HandleFormWithCurrentMode();


            labLDL_AppID.Text = "??";
            cbLicenseClasses.SelectedIndex = 2;

            switch (cbPeopleSearcher.SelectedIndex)
            {
                case (int)enPeopleSearcher.NationalNo:

                    string NationalNo = tbSearchValue.Text;
                    if (clsPeople.IsNationalNoExist(NationalNo))
                    {
                        btnNext.Enabled = true;
                        ucPersonInfo1.LoadPersonInfo(NationalNo);
                        ucPersonInfo1.VisiblingEditPersonalInfoButton(true);
                        clsGlobalSettings.CurrentPersonId = ucPersonInfo1.PersonID;
                    }
                    else
                    {
                        btnNext.Enabled = false;
                        ucPersonInfo1.VisiblingEditPersonalInfoButton(false);
                        ucPersonInfo1.Clear();

                        MessageBox.Show("Not Found", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case (int)enPeopleSearcher.PersonID:

                    ucPersonInfo1.PersonID = Convert.ToInt32(tbSearchValue.Text);
                    if (clsPeople.IsPersonIDExist(ucPersonInfo1.PersonID))
                    {
                        btnNext.Enabled = true;
                        ucPersonInfo1.LoadPersonInfo(ucPersonInfo1.PersonID);
                        ucPersonInfo1.VisiblingEditPersonalInfoButton(true);
                        clsGlobalSettings.CurrentPersonId = ucPersonInfo1.PersonID;
                    }
                    else
                    {
                        btnNext.Enabled = false;
                        ucPersonInfo1.VisiblingEditPersonalInfoButton(false);
                        ucPersonInfo1.Clear();

                        MessageBox.Show("Not Found", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }


        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddPerson();

            frm.ShowDialog();

            if (clsGlobalSettings.LastAddedPersonId != -1 && clsGlobalSettings.LastAddedPersonId != 0)
            {
                ucPersonInfo1.LoadPersonInfo(clsGlobalSettings.LastAddedPersonId);

                btnNext.Enabled = true;
            }

        }


        private void cbPeopleSearcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //! Require user to input Numbric Value in tbSearchValue 
            if (cbPeopleSearcher.SelectedIndex == (int)enPeopleSearcher.PersonID)
            {
                tbSearchValue.Text = "";
                if (!int.TryParse(tbSearchValue.Text, out int result))
                {
                    tbSearchValue.Text = "";
                    ucPersonInfo1.Clear();
                }
            }


        }


        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
                return;

            if (cbPeopleSearcher.SelectedIndex == (int)enPeopleSearcher.PersonID)
            {
                if (!int.TryParse(tbSearchValue.Text, out int result))
                {
                    tbSearchValue.Text = "";
                    clsUtility.InvalidDatadNotifycation(notifyInvalidDataType);
                }
            }

        }

        private void tcAddNewDrivingLicense_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !(_canChangeTab);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcAddNewDrivingLicense.SelectTab(1);
            _canChangeTab = true;
            btnSave.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }


    }
}
