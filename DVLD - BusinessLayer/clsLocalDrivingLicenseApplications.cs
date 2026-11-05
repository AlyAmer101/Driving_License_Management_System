using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsLocalDrivingLicenseApplications
    {
        public int LocalDrivingLicenseApplicationsID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID { set; get; }

        public static int AddNewLDL_Application(clsLocalDrivingLicenseApplications LDL_Application)
        {
            return clsLocalDrivingLicenseApplicationsData.AddNewLDL_Application(LDL_Application.ApplicationID, LDL_Application.LicenseClassID);
        }
        public static bool UpdateLicenseClassID(int LDL_ApplicationID, int NewLicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateLicenseClassID(LDL_ApplicationID, NewLicenseClassID);
        }

        public static bool UpdateApplicationStatus(int LDL_AppID, int NewStatus)
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateApplicationStatus(LDL_AppID, NewStatus);
        }

        public static int IsPersonHaveNewApplicationOnThisLicenseClass(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsPersonHaveNewApplicationOnThisLicenseClass(ApplicantPersonID, LicenseClassID);
        }

        public static string GetNationalNoByLDLAppID(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.GetNationalNoByLDLAppID(LDLAppID);
        }
        public static int GetAppID_By_LDLAppID(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.GetAppID_By_LDLAppID(LDLAppID);
        }

        public static int GetPassedTestsCountByLDLAppID(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.GetPassedTestsCount(LDLAppID);
        }
        public static string GetLicenseClassName(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.GetLicenseClassName(LDLAppID);
        }
        public static int GetLicenseClassID (int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.GetLicenseClassID(LDLAppID);
        }
   
        public static int GetLicenseID(int LDLAppID)
        {
            return clsLocalDrivingLicenseApplicationsData.GetLicenseID(LDLAppID);
        }

        public static bool IsApplicationDeletable(int LDL_AppID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsApplicationDeletable(LDL_AppID);
        }

        public static bool DeleteApplication(int LDL_AppID)
        {
            return clsLocalDrivingLicenseApplicationsData.DeleteApplication(LDL_AppID);
        }




    }

}
