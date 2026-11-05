using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccessLayer
{
    public class clsTestsData
    {
        //! DataAccess Layer 
        public static bool IsUserCreatedAnyTest(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 1 from Tests where CreatedByUserID = @UserID";

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
        public static int AddNewTest(int TestAppointmentID, int TestResult, int CreatedByUserID, string Notes)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Tests
                            (TestAppointmentID, TestResult, CreatedByUserID, Notes)
                            VALUES 
                            (@TestAppointmentID, @TestResult, @CreatedByUserID, @Notes)
                            select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (Notes == string.Empty)
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);




            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                connection.Close();

                if (result != DBNull.Value && result != null)
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

        public static bool UpdateApplicationStatus(int LDLAppID, int NewStatus)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update AllApplicationsStatus_View
                            Set ApplicationStatus = @NewStatus
                            where LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);

            try
            {
                connection.Open();

                int result = command.ExecuteNonQuery();

                connection.Close();

                if (result != 0)
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
