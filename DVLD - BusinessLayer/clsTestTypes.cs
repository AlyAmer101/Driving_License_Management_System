using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsTestTypes
    {
        public static int GetTestFeesByTestTypeID(int TestTypeID)
        {
            return clsTestTypesData.GetTestFeesByTestTypeID(TestTypeID);
        }

        public static bool UpdateTestTypesByID(int TestTypeID, string NewTitle, string NewDescription, double NewFees)
        {
            if (TestTypeID == -1 || string.IsNullOrEmpty(NewTitle))
                return false;
            else
                return clsTestTypesData.UpdateTestTypesByID(TestTypeID, NewTitle, NewDescription, NewFees);
        }


    }
}
