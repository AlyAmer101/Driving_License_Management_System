using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD___DataAccessLayer
{
    public class clsCountriesData
    {
        public static string GetCountryNameByID(int CountryID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT CountryName FROM Countries WHERE CountryID = @CountryID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            string CountryName = "";

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    CountryName = result.ToString();


                connection.Close();

                return CountryName;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }


            return CountryName;
        }
        
        public static int GetCountryIdByName(string CountryName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT CountryID FROM Countries WHERE CountryName = @CountryName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            int CountryID = -1;

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    CountryID = Convert.ToInt32(result);


                connection.Close();

                return CountryID;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }


            return CountryID;
        }

    }
}
