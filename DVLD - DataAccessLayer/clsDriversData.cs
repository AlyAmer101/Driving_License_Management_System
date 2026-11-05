using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccessLayer
{
    public class clsDriversData
    {
        //! DataAccess Layer 
        public static bool IsUserCreatedAnyDriver(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 1 from Drivers where CreatedByUserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                connection.Close();

                if (result != null && result != DBNull.Value)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return false;
        }
        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Drivers
                            (PersonID, CreatedByUserID, CreatedDate)
                            VALUES 
                            (@PersonID, @CreatedByUserID, @CreatedDate)
                            select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                connection.Open();

                object resutl = command.ExecuteScalar();

                connection.Close();


                if (resutl != System.DBNull.Value && resutl != null)
                    return Convert.ToInt32(resutl);
                else
                    return -1;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return -1;
        }

        public static int GetDriverId(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select DriverID from Drivers_View where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
                else
                    return -1;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return -1;
        }
        public static int GetDriverId(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select DriverID from Drivers_View where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
                else
                    return -1;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return -1;
        }


        public static string GetNationalNoByDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select NationalNo from Drivers_View where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return result.ToString();
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return string.Empty;
        }
    
        public static string GetNameByDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select FullName from Drivers_View where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return result.ToString();
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return string.Empty;
        }

    }

}
