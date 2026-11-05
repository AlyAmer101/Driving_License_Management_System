using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsDetainedLicenses
    {
        public int DetainID { set; get; }
        public int FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime DetainDate { set; get; }

        static int _DetainID = -1;
        static int _CreatedByUserID = -1;
        static int _FineFees = 0;
        static DateTime _DetainDate = DateTime.MinValue;


        //! Release Info Properties
        public int IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleaseByUserID { set; get; }
        public int ReleaseApplicationID { set; get; }


        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicensesData.IsLicenseDetained(LicenseID);
        }

        public static clsDetainedLicenses GetDetainedLicenseInfo(int LicenseID)
        {
            clsDetainedLicensesData.GetDetainedLicenseInfo(LicenseID, ref _DetainID, ref _CreatedByUserID, ref _FineFees, ref _DetainDate);

            clsDetainedLicenses DetainedLicenseInfo = new clsDetainedLicenses();

            DetainedLicenseInfo.DetainID = _DetainID;
            DetainedLicenseInfo.CreatedByUserID = _CreatedByUserID;
            DetainedLicenseInfo.FineFees = _FineFees;
            DetainedLicenseInfo.DetainDate = _DetainDate;

            return DetainedLicenseInfo;
        }


        public static int AddNewDetainedLicense(int LicenseID, clsDetainedLicenses DetainedLicense)
        {
            return clsDetainedLicensesData.AddNewDetainedLicense(LicenseID, DetainedLicense.DetainDate, DetainedLicense.FineFees, DetainedLicense.CreatedByUserID);
        }

        public static bool ReleaseDetainedLicense(int LicenseID, clsDetainedLicenses ReleaseInfo)
        {
            return clsDetainedLicensesData.ReleaseDetainedLicense(LicenseID, ReleaseInfo.IsReleased, ReleaseInfo.ReleaseDate, ReleaseInfo.ReleaseByUserID, ReleaseInfo.ReleaseApplicationID);
        }

        //! Business Layer
        public static bool IsUserCreatedAnyDetainedLicense(int UserID)
        {
            return clsDetainedLicensesData.IsUserCreatedAnyDetainedLicense(UserID);
        }
    }
}
