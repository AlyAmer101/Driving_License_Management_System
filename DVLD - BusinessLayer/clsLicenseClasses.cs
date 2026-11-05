using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsLicenseClasses
    {
        public static int GetLicenseFees(int LicenseClassID)
        {
            return clsLicenseClassesData.GetLicenseFees(LicenseClassID);
        }

        public static int GetDefaultValidityLengthOfLicense(int LicenseClassID)
        {
            return clsLicenseClassesData.GetDefaultValidityLengthOfLicense(LicenseClassID);
        }
    }
}
