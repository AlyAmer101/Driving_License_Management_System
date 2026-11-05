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

namespace DVLD.User_Controles
{
    public partial class ucDriverLicenseInfo : UserControl
    {
        public ucDriverLicenseInfo()
        {
            InitializeComponent();
        }


        string _ConvertGendorIdToName(short Gendor)
        {
            switch (Gendor)
            {
                case 0:
                    return "Male";
                
                case 1:
                    return "Female";
            }

            return string.Empty;
        }
    
        string _ConvertIssueReasonIdToName(short IssueReasonID)
        {
            switch ((clsUtility.enIssueLicenseReasons)IssueReasonID)
            {
                case clsUtility.enIssueLicenseReasons.FirstTime:
                    return "First Time";

                case clsUtility.enIssueLicenseReasons.Renew:
                    return "Renew";

                case clsUtility.enIssueLicenseReasons.ReplacementForDamaged:
                    return "Replacement For Damaged";

                case clsUtility.enIssueLicenseReasons.ReplacementForLost:
                    return "Replacement For Lost";
            }

            return string.Empty;
        }

        public void LoadDriverInfo(int DriverID, int LicenseID)
        {
            string NationalNo = clsDriver.GetNationalNoByDriverID(DriverID);
            string LicenseNotes = clsLicenses.GetLicenseNotesByLicenseID(LicenseID);
            short IssueReasonID = (short)clsLicenses.GetIssueReasonByLicenseID(LicenseID);

            //! Info Source : Constractor
            labDriverIDValue.Text = DriverID.ToString();
            labLicenseIDValue.Text = LicenseID.ToString();

            //! Info Source : Drivers_View
            labNameValue.Text = clsDriver.GetNameByDriverID(DriverID);
            labNationalNoValue.Text = clsDriver.GetNationalNoByDriverID(DriverID);

            //! Info Source : People
            labGendorValue.Text = _ConvertGendorIdToName(clsPeople.GetGendorByNationalNo(NationalNo));
            labDateOfBirthValue.Text = clsPeople.GetDateOfBirthByNationalNo(NationalNo).ToString(clsUtility.DateFormat);
            pbPersonImage.ImageLocation = clsPeople.GetImagePathByNationalNo(NationalNo);

            //! Info Source : Licenses
            labClassValue.Text = clsLicenses.GetLicenseClassByLicenseID(LicenseID);
            labIssueDateValue.Text = clsLicenses.GetIssueDateByLicenseID(LicenseID).ToString(clsUtility.DateFormat);
            labExpirationDateValue.Text = clsLicenses.GetExpirationDateByLicenseID(LicenseID).ToString(clsUtility.DateFormat);
            labIsActiveValue.Text = (clsLicenses.IsLicenseActive(LicenseID) == (short)clsUtility.enLicenseActivityStatus.Active ? "Yes" : "False");
            labIsueeReasonValue.Text = _ConvertIssueReasonIdToName(IssueReasonID);
            labNotesValue.Text = LicenseNotes == String.Empty ? labNotesValue.Tag.ToString() : LicenseNotes;

            //! Info Source : DetainedLicenses
            labIsDetainedValue.Text = (clsDetainedLicenses.IsLicenseDetained(LicenseID) == true ? "Yes" : "False");

        }

        public void LoadDriverInfo(int LicenseID)
        {
            int DriverID = clsLicenses.GetDriverID(LicenseID);

            LoadDriverInfo(DriverID, LicenseID);
        }


    }
}
