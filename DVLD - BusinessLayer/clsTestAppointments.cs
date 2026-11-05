using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsTestAppointments
    {
        public enum enMode { AddNew, Update }


        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public int IsLocked { set; get; }
        public DateTime AppointmentDate { set; get; }
        public enMode Mode  { set; get; }

        public clsTestAppointments()
        {
            this.Mode = enMode.AddNew;
        }

        //! Business Layer
        public static bool IsUserCreatedAnyTestAppointment(int UserID)
        {
            return clsTestAppointmentsData.IsUserCreatedAnyTestAppointment(UserID);
        }
        public static bool IsLDLAppHasActiveAppointments(int LDLAppID)
        {
            return clsTestAppointmentsData.IsLDLAppHasActiveAppointments(LDLAppID);
        }

        public static int GetRetakeTestAppId(int TestAppointmentID)
        {
            return clsTestAppointmentsData.GetRetakeTestAppId(TestAppointmentID);
        }

        public static int GetTestTriesCountByLDLAppID(int LDLAppID,int TestTypeID)
        {
            return clsTestAppointmentsData.GetTestTriesCountByLDLAppID(LDLAppID, TestTypeID);
        }

        public static int AddNewTestAppointment(clsTestAppointments TestAppointment)
        {
            return clsTestAppointmentsData.AddNewTestAppointment(TestAppointment.TestTypeID, TestAppointment.LocalDrivingLicenseApplicationID, TestAppointment.AppointmentDate, TestAppointment.PaidFees, TestAppointment.CreatedByUserID, TestAppointment.IsLocked, TestAppointment.RetakeTestApplicationID);
        }
        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime NewTestDate)
        {
            return clsTestAppointmentsData.UpdateTestAppointment(TestAppointmentID, NewTestDate);
        }

        public static bool UpdateTestAppointmentWithRetakeTestAppID(int TestAppointmentID, int RetakeTestAppID)
        {
            return clsTestAppointmentsData.UpdateTestAppointmentWithRetakeTestAppID(TestAppointmentID, RetakeTestAppID);
        }


        public static bool LockTestAppointment(int TestAppointmentID)
        {
           return clsTestAppointmentsData.LockTestAppointment(TestAppointmentID);
        }



    }

}
