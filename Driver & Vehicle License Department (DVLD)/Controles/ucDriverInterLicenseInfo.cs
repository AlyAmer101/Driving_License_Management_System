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
    public partial class ucDriverInterLicenseInfo : UserControl
    {
        public ucDriverInterLicenseInfo()
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

        
        public void LoadDriverInterLicenseInfo(int InternationalLicenseID)
        {
            string NationalNo = clsInternationalLicenses.GetNationalNo(InternationalLicenseID);
            int PersonID = clsPeople.GetPersonID(NationalNo);

            clsInternationalLicenses License = clsInternationalLicenses.GetInternationalLicense(InternationalLicenseID);

            //! Info Source : InternationalLicenses
            labInterLicenseIDValue.Text = InternationalLicenseID.ToString();
            labLicenseIDValue.Text = License.IssuedUsingLocalLicenseID.ToString();
            labIssueDateValue.Text = License.IssueDate.ToString(clsUtility.DateFormat);
            labApplicationIDValue.Text = License.ApplicationID.ToString();
            labIsActiveValue.Text = License.IsActive == (int)clsUtility.enLicenseActivityStatus.Active ? "Yes" : "No";
            labDriverIDValue.Text = License.DriverID.ToString();
            labExpirationDateValue.Text = License.ExpirationDate.ToString(clsUtility.DateFormat);
            labNationalNoValue.Text = NationalNo;

            //! Info Source : People
            labNameValue.Text = clsPeople.GetFullName(PersonID);
            labGendorValue.Text = _ConvertGendorIdToName(clsPeople.GetGendorByNationalNo(NationalNo));
            labDateOfBirthValue.Text = clsPeople.GetDateOfBirthByNationalNo(NationalNo).ToString(clsUtility.DateFormat);
            pbPersonImage.ImageLocation = clsPeople.GetImagePathByNationalNo(NationalNo);
            
        
        
        }

    }
}
