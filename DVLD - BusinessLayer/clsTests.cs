using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsTests
    {
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public int TestResult { set; get; }
        public int CreatedByUserID { set; get; }
        public string Notes { set; get; }

        public static int AddNewTest(clsTests Test)
        {
            return clsTestsData.AddNewTest(Test.TestAppointmentID, Test.TestResult, Test.CreatedByUserID, Test.Notes);
        }

        public static bool UpdateApplicationStatus(int LDLAppID, int NewStatus)
        {
            return clsTestsData.UpdateApplicationStatus(LDLAppID, NewStatus);
        }

        //! Business Layer
        public static bool IsUserCreatedAnyTest(int UserID)
        {
            return clsTestsData.IsUserCreatedAnyTest(UserID);
        }
    }
}
