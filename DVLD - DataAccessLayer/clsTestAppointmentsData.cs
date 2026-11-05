using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccessLayer
{
    public class clsTestAppointmentsData
    {
        
        //! DataAccess Layer 
        public static bool IsUserCreatedAnyTestAppointment(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 1 from TestAppointments where CreatedByUserID = @UserID";

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
        public static bool IsLDLAppHasActiveAppointments(int LDLAppID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select 1 from TestAppointments_View 
                             where LocalDrivingLicenseApplicationID = @LDLAppID
                             and IsLocked = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();

                return (result != null && Convert.ToInt32(result) == 1 ? true : false);

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


        public static int GetRetakeTestAppId(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select RetakeTestApplicationID from TestAppointments
                            where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

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

        public static int GetTestTriesCountByLDLAppID(int LDLAppID, int TestTypeID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select COUNT(TestAppointmentID) from TestAppointments
                             where LocalDrivingLicenseApplicationID = @LDLAppID
                             and TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

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

        public static int AddNewTestAppointment(int TestTypeID, int LDLAppID, DateTime TestAppointmentDate, int PaidFees, int CreatedUserID, int IsLocked, int RetakeTestAppID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments
                            (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                            VALUES 
                            (@TestTypeID, @LDLAppID, @TestAppointmentDate, @PaidFees, @CreatedUserID, @IsLocked, @RetakeTestAppID)
                            select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestAppointmentDate", TestAppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedUserID", CreatedUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestAppID != -1)
                command.Parameters.AddWithValue("@RetakeTestAppID", RetakeTestAppID);
            else
                command.Parameters.AddWithValue("@RetakeTestAppID", DBNull.Value);

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

        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime NewTestDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments SET
                            AppointmentDate = @NewTestDate
                            WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@NewTestDate", NewTestDate);

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

        public static bool LockTestAppointment(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments SET
                                    IsLocked = 1
                            WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

        public static bool UpdateTestAppointmentWithRetakeTestAppID(int TestAppointmentID, int RetakeTestAppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments SET
                            RetakeTestApplicationID = @RetakeTestAppID
                            WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@RetakeTestAppID", RetakeTestAppID);

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




    }

}
