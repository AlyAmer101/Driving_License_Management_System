using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsDriver
    {
        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            return clsDriversData.AddNewDriver(PersonID, CreatedByUserID, CreatedDate);
        }
        public static int GetDriverIdByNationalNo(string NationalNo)
        {
            return clsDriversData.GetDriverId(NationalNo);
        }

        public static bool IsPersonAlreadyDriver(string NationalNo)
        {
            int DriverID = clsDriversData.GetDriverId(NationalNo);

            if (DriverID != -1)
                return true;
            else
                return false;
        }

        public static bool IsPersonAlreadyDriver(int PersonID)
        {
            int DriverID = clsDriversData.GetDriverId(PersonID);

            if (DriverID != -1)
                return true;
            else
                return false;
        }

        public static string GetNationalNoByDriverID(int DriverID)
        {
            return clsDriversData.GetNationalNoByDriverID(DriverID);
        }

        public static string GetNameByDriverID(int DriverID)
        {
            return clsDriversData.GetNameByDriverID(DriverID);
        }

        //! Business Layer
        public static bool IsUserCreatedAnyDriver(int UserID)
        {
            return clsDriversData.IsUserCreatedAnyDriver(UserID);
        }
    }

}
