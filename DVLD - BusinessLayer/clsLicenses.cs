using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsLicenses
    {
        public int LicensesID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClassID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public int PaidFees { set; get; }
        public int IsActive { set; get; }
        public int IssueReason { set; get; }
        public int CreatedByUserID { set; get; }
       
        //! Business Layer
        public static bool IsUserCreatedAnyLicense(int UserID)
        {
            return clsLicensesData.IsUserCreatedAnyLicense(UserID);
        }

        public static DateTime CalcExpirationDate(DateTime IssueDate, int LicenseClassID)
        {
            return clsLicensesData.CalcExpirationDate(IssueDate, LicenseClassID);
        }
        public static int AddNewLicense(clsLicenses Licenses)
        {
            return clsLicensesData.AddNewLicense(Licenses.ApplicationID, Licenses.DriverID, Licenses.LicenseClassID, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.Notes, Licenses.PaidFees, Licenses.IsActive, Licenses.IssueReason, Licenses.CreatedByUserID);
        }
        public static string GetLicenseClassByLicenseID(int LicenseID)
        {
            return clsLicensesData.GetLicenseClassByLicenseID(LicenseID);
        }
        public static int GetLicenseClassIdByLicenseID(int LicenseID)
        {
            return clsLicensesData.GetLicenseClassIdByLicenseID(LicenseID);
        }
        public static bool IsPersonHasLicenseClassThree(int LicenseID)
        {
            return clsLicensesData.IsPersonHasLicenseClassThree(LicenseID);
        }
        public static DateTime GetIssueDateByLicenseID(int LicenseID)
        {
            return clsLicensesData.GetIssueDateByLicenseID(LicenseID);

        }
        public static DateTime GetExpirationDateByLicenseID(int LicenseID)
        {
            return clsLicensesData.GetExpirationDateByLicenseID(LicenseID);

        }
        public static int GetIssueReasonByLicenseID(int LicenseID)
        {
            return clsLicensesData.GetIssueReasonByLicenseID(LicenseID);
        }
        public static int GetDriverID(int LicenseID)
        {
            return clsLicensesData.GetDriverID(LicenseID);
        }
        public static int GetPersonID(int LicenseID)
        {
            return clsLicensesData.GetPersonID(LicenseID);
        }
        public static string GetLicenseNotesByLicenseID(int LicenseID)
        {
            return clsLicensesData.GetLicenseNotesByLicenseID(LicenseID);
        }
   
        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicensesData.IsLicenseExist(LicenseID);

        }
        public static short IsLicenseActive(int LicenseID)
        {
            return clsLicensesData.IsLicenseActive(LicenseID);
        }
        public static bool IsPersonHaveLicenseInThisClass(int PersonID, int LicenseClassID)
        {
            return clsLicensesData.IsPersonHaveLicenseInThisClass(PersonID, LicenseClassID);
        }
        public static bool IsLicenseExpired(int LicenseID)
        {
            DateTime ExpirationDate = clsLicensesData.GetLicenseExpirationDate(LicenseID);


            return ExpirationDate <= DateTime.Today;
        }
    
        public static bool UpdateLicenseStatus(int LicenseID, int Status)
        {
            return clsLicensesData.UpdateLicenseStatus(LicenseID, Status);
        }


    
    }
}
