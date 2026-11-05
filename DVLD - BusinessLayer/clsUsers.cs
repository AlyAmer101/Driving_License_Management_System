using DVLD___DataAccessLayer;
using System;
using System.Data.SqlClient;

namespace DVLD___BusinessLayer
{
    public class clsUsers
    {
        public enum enMode { AddNew, Update };

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public enMode Mode { set; get; }
        public clsPeople PersonInfo { set; get; }

        static string _UserName = "";
        static string _Password = "";
        static bool _IsActive = false;

        public clsUsers()
        {
            UserID = -1;
            PersonID = -1;

            UserName = "";
            Password = "";

            IsActive = false;

            Mode = enMode.AddNew;
        }

        public static int CheckUsernameAndPassword(string Username, string Password)
        {
            return clsUsersData.CheckUsernameAndPassword(Username, Password);
        }


        public static bool IsUserActive(int UserID)
        {
            return clsUsersData.IsUserActive(UserID);
        }


        public static int AddNewUser(clsUsers User)
        {
            return clsUsersData.AddNewUser(User.PersonID, User.UserName, User.Password, User.IsActive);
        }
        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            return clsUsersData.UpdateUser(UserID, UserName, Password, IsActive);
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            return clsUsersData.ChangePassword(UserID, NewPassword);
        }

        public static bool DeleteUserByID(int UserID)
        {
            return clsUsersData.DeleteUserByID(UserID);
        }
        public static bool IsUserNameExist(string UserName)
        {
            return clsUsersData.IsUserNameExist(UserName);
        }

        public static clsUsers GetUserByID(int UserID)
        {
            clsUsersData.GetUserByID(UserID, ref _UserName, ref _Password, ref _IsActive);

            clsUsers User = new clsUsers();

            User.UserID = UserID;
            User.UserName = _UserName;
            User.Password = _Password;
            User.IsActive = _IsActive;
            User.Mode = enMode.Update;

            return User;
        }

        public static int GetPersonIdByUserID(int UserID)
        {
            return clsUsersData.GetPersonIdByUserID(UserID);
        }

        public static string GetUserNameByID(int UserID)
        {
            return clsUsersData.GetUserNameByID(UserID);
        }

        public static bool IsUserConnectedWithData(int UserID)
        {
            if (clsApplications.IsUserCreateAnyApplication(UserID))
                return true;

            if (clsDetainedLicenses.IsUserCreatedAnyDetainedLicense(UserID))
                return true;

            if (clsDriver.IsUserCreatedAnyDriver(UserID))
                return true;

            if (clsInternationalLicenses.IsUserCreatedAnyInternationalLicense(UserID))
                return true;

            if (clsLicenses.IsUserCreatedAnyLicense(UserID))
                return true;

            if (clsTestAppointments.IsUserCreatedAnyTestAppointment(UserID))
                return true;

            if (clsTests.IsUserCreatedAnyTest(UserID))
                return true;

            return false;
        }

    }
}
