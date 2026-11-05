using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace DVLD___BusinessLayer
{
    public class clsPeople
    {
        public enum enGendor { Male, Female};
        public enum enMode { AddNew, Update};
        
        public int ID { set; get; }
        public int Phone { set; get; }
        public int Country { set; get; }

        public string CountryName
        {
            get
            {
                return clsCountries.GetCountryNameByID(Country);
            }
        }

        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {SecondName} {ThirdName} {LastName}";
            }
        }

        public string Email { set; get; }
        public string Address { set; get; }
        public string ImagePath { set; get; }
        public DateTime DateOfBirth { set; get; }
        public enMode Mode { set; get; }
        public enGendor Gendor { set; get; }

        static int _PersonID = 0;
        static string _NationalNo = "";
        static string _FirstName = "";
        static string _SecondName = "";
        static string _ThirdName = "";
        static string _LastName = "";
        static DateTime _DateOfBirth = DateTime.Now;
        static int _Gendor = 0;
        static string _Address = "";
        static int _Phone = 0;
        static string _Email = "";
        static int _Country = 0;
        static string _ImagePath = "";

        public clsPeople()
        {
            ID = -1;
            Country = -1;
            Phone = 0;
            Gendor = enGendor.Male;

            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";  
            Email = "";
            Address  = ""; 
            ImagePath = "";

            DateOfBirth = new DateTime();

            Mode = enMode.AddNew;

        }

        public static DataTable ListPeople()
        {
            return DVLD___DataAccessLayer.clsPeopleData.ListPeople();
        }

        public static int PeopleCount()
        {
            return ListPeople().Rows.Count;
        }

        public static bool IsNationalNoExist(string NationalNo)
        {
            return clsPeopleData.IsNationalNoExist(NationalNo);
        }

        public static bool IsPersonIDExist(int PersonID)
        {
            return clsPeopleData.IsPersonIDExist(PersonID);
        }

        public static bool IsPersonSystemUser(int PersonID)
        {
            return clsUsersData.IsPersonSystemUser(PersonID);
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
        public static int AddNewPeron(clsPeople Person)
        {
            return clsPeopleData.AddNewPeron(Person.NationalNo, Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.DateOfBirth, (int)Person.Gendor, Person.Address, Person.Phone, Person.Email, Person.Country, Person.ImagePath);
        }

        public static bool UpdatePerson(clsPeople Person)
        {
            return clsPeopleData.UpdatePeron(Person.ID ,Person.NationalNo, Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.DateOfBirth, (int)Person.Gendor, Person.Address, Person.Phone, Person.Email, Person.Country, Person.ImagePath);
        }

        public static clsPeople GetPersonByID(int PersonID)
        {
            clsPeople Person = new clsPeople();

            clsPeopleData.GetPersonByID(PersonID, ref _NationalNo, ref _FirstName, ref _SecondName, ref _ThirdName, ref _LastName, ref _DateOfBirth, ref _Gendor, ref _Address, ref _Phone, ref _Email, ref _Country, ref _ImagePath);

            Person.ID = PersonID;
            Person.NationalNo = _NationalNo;
            Person.FirstName = _FirstName;
            Person.SecondName = _SecondName;
            Person.ThirdName = _ThirdName;
            Person.LastName = _LastName;
            Person.DateOfBirth = _DateOfBirth;
            Person.Gendor = (enGendor)_Gendor;
            Person.Address = _Address;
            Person.Phone = _Phone;
            Person.Email = _Email;
            Person.Country = _Country;
            Person.ImagePath = _ImagePath;
            Person.Mode = enMode.Update;

            return Person;
        }
        public static clsPeople GetPersonByNationalNo(string NationalNo)
        {
            clsPeople Person = new clsPeople();

            clsPeopleData.GetPersonByNationalNo(NationalNo, ref _PersonID, ref _FirstName, ref _SecondName, ref _ThirdName, ref _LastName, ref _DateOfBirth, ref _Gendor, ref _Address, ref _Phone, ref _Email, ref _Country, ref _ImagePath);

            Person.NationalNo = NationalNo;
            Person.ID = _PersonID;
            Person.FirstName = _FirstName;
            Person.SecondName = _SecondName;
            Person.ThirdName = _ThirdName;
            Person.LastName = _LastName;
            Person.DateOfBirth = _DateOfBirth;
            Person.Gendor = (enGendor)_Gendor;
            Person.Address = _Address;
            Person.Phone = _Phone;
            Person.Email = _Email;
            Person.Country = _Country;
            Person.ImagePath = _ImagePath;
            Person.Mode = enMode.Update;

            return Person;
        }
        public static bool DeletePersonByID(int PersonID)
        {
            //if (!IsPersonConnectedWithOperations(PersonID))
            if (!clsPeople.IsPersonSystemUser(PersonID))
                return clsPeopleData.DeletePersonByID(PersonID);
            else
                return false;

        }

        public static string GetFullName(int PersonID)
        {
            return clsPeopleData.GetFullName(PersonID);
        }

        public static int GetPersonIdBy_LDLAppID(int LDLAppID)
        {
            return clsPeopleData.GetPersonIdBy_LDLAppID(LDLAppID);
        }


        public static short GetGendorByNationalNo(string NationalNo)
        {
            return clsPeopleData.GetGendorByNationalNo(NationalNo);
        }
        public static int GetPersonID(string NationalNo)
        {
            return clsPeopleData.GetPersonID(NationalNo);
        }

        public static DateTime GetDateOfBirthByNationalNo(string NationalNo)
        {
            return clsPeopleData.GetDateOfBirthByNationalNo(NationalNo);

        }
        public static string GetImagePathByNationalNo(string NationalNo)
        {
            return clsPeopleData.GetImagePathByNationalNo(NationalNo);
        }


        public static bool IsPersonLinkedWithData(int PersonID)
        {
            int AppId = clsApplications.GetTopAppIdByPersonID(PersonID);
           
            if (AppId != -1) //! Person Has Application
                return true;

            
            if (clsDriver.IsPersonAlreadyDriver(PersonID)) //! Person Is Driver
                return true;
            

            if (clsDriver.IsPersonAlreadyDriver(PersonID)) //! Person Is Driver
                return true;

            
            
            return false;
        }


    }
}
