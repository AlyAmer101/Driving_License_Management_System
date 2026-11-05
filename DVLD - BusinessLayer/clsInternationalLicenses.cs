using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsInternationalLicenses
    {
        public int InternationalLicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public int IsActive { set; get; }
        public int CreatedByUserID { set; get; }

        static int _InternationalLicenseID = -1;
        static int _ApplicationID = -1;
        static int _DriverID = -1;
        static int _IssuedUsingLocalLicenseID = -1;
        static DateTime _IssueDate = DateTime.MinValue;
        static DateTime _ExpirationDate = DateTime.MinValue;
        static int _IsActive = -1;
        static int _CreatedByUserID = -1;
        
        //! Business Layer
        public static bool IsUserCreatedAnyInternationalLicense(int UserID)
        {
            return clsInternationalLicensesData.IsUserCreatedAnyInternationalLicense(UserID);
        }
        public static int GetInternationalLicenseID(int DriverID)
        {
            return clsInternationalLicensesData.GetInternationalLicenseID(DriverID);
        }
      
        public static clsInternationalLicenses GetInternationalLicense(int InternationalLicenseID)
        {
            clsInternationalLicenses license = new clsInternationalLicenses();

            clsInternationalLicensesData.GetInternationalLicense(InternationalLicenseID, ref _ApplicationID, ref _DriverID, ref _IssuedUsingLocalLicenseID, ref _IssueDate, ref _ExpirationDate, ref _IsActive, ref _CreatedByUserID);

            license.InternationalLicenseID = _InternationalLicenseID;
            license.ApplicationID = _ApplicationID;
            license.DriverID = _DriverID;
            license.IssuedUsingLocalLicenseID = _IssuedUsingLocalLicenseID;
            license.IssueDate = _IssueDate;
            license.ExpirationDate = _ExpirationDate;
            license.IsActive= _IsActive;
            license.CreatedByUserID = _CreatedByUserID;

            return license;
        }

        public static string GetNationalNo(int InternationalLicenseID)
        {
            return clsInternationalLicensesData.GetNationalNo(InternationalLicenseID);
        }

        public static int AddNewLicense(clsInternationalLicenses NewLicense)
        {
            return clsInternationalLicensesData.AddNewLicense(NewLicense.ApplicationID, NewLicense.DriverID, NewLicense.IssuedUsingLocalLicenseID, NewLicense.IssueDate, NewLicense.ExpirationDate, NewLicense.IsActive, NewLicense.CreatedByUserID);
        }


    }

}
