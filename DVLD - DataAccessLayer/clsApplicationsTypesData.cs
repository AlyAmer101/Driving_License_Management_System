using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccessLayer
{
    public class clsApplicationsTypesData
    {
        public static int GetApplicationFees(int ApplicationTypeID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ApplicationFees from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


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


        public static bool UpdateApplicationTypeByID(int AppTypeID, string NewTitle, double NewFees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE ApplicationTypes SET
                 ApplicationTypeTitle = @NewTitle, ApplicationFees = @NewFees
                WHERE ApplicationTypeID = @AppTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NewTitle", NewTitle);
            command.Parameters.AddWithValue("@NewFees", NewFees);
            command.Parameters.AddWithValue("@AppTypeID", AppTypeID);

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

        public static int GetApplicationTypeFeesByID(int AppTypeID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select ApplicationFees From ApplicationTypes WHERE ApplicationTypeID = @AppTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppTypeID", AppTypeID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null || result != DBNull.Value)
                    return Convert.ToInt32(result);
                else
                    return 0;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return 0;
        }

        public static string GetApplicationTypeNameByID(int AppTypeID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select ApplicationTypeTitle From ApplicationTypes WHERE ApplicationTypeID = @AppTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppTypeID", AppTypeID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null || result != DBNull.Value)
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
