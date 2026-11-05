using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsPersonTestsInfo
    {
        public static int GetResultOfLastVisionTestByPersonID(int PersonID, int LicenseClassID, int TestTypeID)
        {
            return clsPersonTestsInfoData.GetResultOfLastVisionTestByPersonID(PersonID, LicenseClassID, TestTypeID);
        }

    }

}
