using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsApplicationsTypes
    {
        public static int GetApplicationFees(int ApplicationTypeID)
        {
            return clsApplicationsTypesData.GetApplicationFees(ApplicationTypeID);
        }

        public static bool UpdateApplicationTypeByID(int AppTypeID, string NewTitle, double NewFees)
        {
            if (AppTypeID == -1 || string.IsNullOrEmpty(NewTitle))
                return false;
            else
                return clsApplicationsTypesData.UpdateApplicationTypeByID(AppTypeID, NewTitle, NewFees);
        }

        public static int GetApplicationTypeFeesByID(int AppTypeID)
        {
            return clsApplicationsTypesData.GetApplicationTypeFeesByID(AppTypeID);
        }

        public static string GetApplicationTypeNameByID(int AppTypeID)
        {
            return clsApplicationsTypesData.GetApplicationTypeNameByID(AppTypeID);
        }

    }
}
