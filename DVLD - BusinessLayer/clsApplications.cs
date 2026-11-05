using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___BusinessLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew, Update}

        public int ApplicationID { set; get; }
        public int ApplicationPersonID { set; get; }
        public clsPeople PersonInfo { set; get; }
        public int ApplicationTypeID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public DateTime LastStatusDate { set; get; }
        public int ApplicationStatus { set; get; }
        public int PaidFees { set; get; }
        public enMode Mode { set; get; }


        static int _ApplicationPersonID = -1;
        static int _ApplicationTypeID  = -1;
        static int _CreatedByUserID = -1;
        static int _ApplicationStatus = -1;
        static int _PaidFees = -1;
        static DateTime _ApplicationDate = DateTime.Today;
        static DateTime _LastStatusDate = DateTime.Today;

        public clsApplications()
        {
            this.Mode = enMode.AddNew;
        }

        public static int AddNewApplication(clsApplications Application)
        {
            return clsApplicationsData.AddNewApplication(Application.ApplicationPersonID, Application.ApplicationTypeID, Application.CreatedByUserID, Application.ApplicationDate, Application.LastStatusDate, Application.ApplicationStatus, Application.PaidFees);
        }

        public void Clear()
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationTypeID = -1;
            this.CreatedByUserID = -1;

            this.ApplicationDate = DateTime.Today;
            this.LastStatusDate = DateTime.Today;

            this.ApplicationStatus = 1; // 1 --> new
            this.PaidFees = 0;

            this.Mode = enMode.AddNew;
        }

        public static clsApplications GetApplicationByID(int AppID)
        {
            clsApplicationsData.GetApplicationByID(AppID, ref _ApplicationPersonID, ref _ApplicationTypeID, ref _CreatedByUserID, ref _ApplicationDate, ref _LastStatusDate, ref _ApplicationStatus, ref _PaidFees);

            clsApplications Application = new clsApplications();

            Application.ApplicationID = AppID;
            Application.ApplicationPersonID = _ApplicationPersonID;
            Application.ApplicationTypeID = _ApplicationTypeID;
            Application.CreatedByUserID = _CreatedByUserID;
            Application.ApplicationStatus = _ApplicationStatus;
            Application.PaidFees = _PaidFees;

            Application.ApplicationDate = _ApplicationDate;
            Application.LastStatusDate = _LastStatusDate;

            Application.Mode = enMode.Update;

            return Application;
        }
        
        public static int GetPersonIdByAppID(int AppID)
        {
            return clsApplicationsData.GetPersonIdByAppID(AppID);
        }

        public static bool DeleteApplication(int AppID)
        {
            return clsApplicationsData.DeleteApplication(AppID);
        }
        public static int  GetTopAppIdByPersonID(int PersonID)
        {
            return clsApplicationsData.GetTopAppIdByPersonID(PersonID);
        }

        public static bool IsUserCreateAnyApplication(int UserID)
        {
            return clsApplicationsData.IsUserCreateAnyApplication(UserID);
        }

    }

}
