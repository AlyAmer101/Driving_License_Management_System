using DVLD___DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___BusinessLayer
{
    public class clsCountries
    {
        public static string GetCountryNameByID(int CountryID)
        {
            return clsCountriesData.GetCountryNameByID(CountryID);
        }
        public static int GetCountryIdByName(string CountryName)
        {
            return clsCountriesData.GetCountryIdByName(CountryName);
        }
    
    
    }
}
