using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD___DataAccessLayer
{
    public class clsApplicationsData
    {
        public static int AddNewApplication(int ApplicationPersonID, int ApplicationTypeID, int CreatedByUserID, DateTime ApplicationDate, DateTime LastStatusDate, int ApplicationStatus, int PaidFees)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications
                            (ApplicantPersonID, ApplicationTypeID, CreatedByUserID, ApplicationDate, LastStatusDate, ApplicationStatus, PaidFees)
                            VALUES 
                            (@ApplicationPersonID, @ApplicationTypeID, @CreatedByUserID, @ApplicationDate, @LastStatusDate, @ApplicationStatus, @PaidFees);
                            select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);




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

        public static void GetApplicationByID(int AppID, ref int ApplicationPersonID, ref int ApplicationTypeID, ref int CreatedByUserID, ref DateTime ApplicationDate, ref DateTime LastStatusDate, ref int ApplicationStatus, ref int PaidFees)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Applications WHERE ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    ApplicationStatus = Convert.ToInt32(reader["ApplicationStatus"]);
                    PaidFees = Convert.ToInt32(reader["PaidFees"]);
                    ApplicationPersonID = Convert.ToInt32(reader["ApplicantPersonID"]);

                    ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]);
                    LastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]);


                }

                reader.Close();
                connection.Close();

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

        }

        public static int GetPersonIdByAppID(int AppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT ApplicantPersonID FROM Applications WHERE ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                connection.Close();

                return (result != null ? Convert.ToInt32(result) : -1);

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


        public static bool DeleteApplication(int AppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete from Applications 
                            where ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);


            try
            {
                connection.Open();

                int AffectedRows = command.ExecuteNonQuery();

                connection.Close();


                if (AffectedRows > 0)
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


        public static int GetTopAppIdByPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 ApplicationID from Applications where ApplicantPersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

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

        public static bool IsUserCreateAnyApplication(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 1 from Applications where CreatedByUserID = @UserID";

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



    }

}
