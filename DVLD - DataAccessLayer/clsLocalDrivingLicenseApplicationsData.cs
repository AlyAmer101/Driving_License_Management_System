using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD___DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsData
    {
        public static int AddNewLDL_Application(int ApplicationID, int LicenseClassID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications
                            (ApplicationID, LicenseClassID)
                            VALUES 
                            (@ApplicationID, @LicenseClassID);
                            select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);




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

        public static bool UpdateLicenseClassID (int LDL_ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE LocalDrivingLicenseApplications SET
                            LicenseClassID = @LicenseClassID
                            WHERE LocalDrivingLicenseApplicationID = @LDL_ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@LDL_ApplicationID", LDL_ApplicationID);


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
  
        public static bool UpdateApplicationStatus (int LDL_AppID, int NewStatus)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE LocalDrivingLicenseFullApplications_View SET
                            ApplicationStatus = @NewStatus
                            WHERE LocalDrivingLicenseApplicationID = @LDL_AppID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_AppID", LDL_AppID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);


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
       
        public static bool IsApplicationDeletable(int LDL_AppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestAppointmentID from TestAppointments_View
                            where LocalDrivingLicenseApplicationID = @LDL_AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_AppID", LDL_AppID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return false;
                else 
                    return true;
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
       
        public static bool DeleteApplication(int LDL_AppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete from LocalDrivingLicenseApplications 
                            where LocalDrivingLicenseApplicationID = @LDL_AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_AppID", LDL_AppID);


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

        public static int IsPersonHaveNewApplicationOnThisLicenseClass(int ApplicantPersonID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                    SELECT Applications.ApplicationID
                    FROM LocalDrivingLicenseApplications 
                    JOIN Applications 
                    ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                    WHERE Applications.ApplicantPersonID = @ApplicantPersonID 
                    AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                    AND Applications.ApplicationStatus = 1;"; //! 1--> New Application

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


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

        public static int GetAppID_By_LDLAppID(int LDLAppID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);


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
        public static int GetPassedTestsCount(int LDLAppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select PassedTestCount from LocalDrivingLicenseApplications_View
                             where LocalDrivingLicenseApplicationID = @LDLAppID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);


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
        public static string GetLicenseClassName(int LDLAppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ClassName from LocalDrivingLicenseApplications_View
                             where LocalDrivingLicenseApplicationID = @LDLAppID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);


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
        public static int GetLicenseClassID(int LDLAppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select LicenseClassID from LocalDrivingLicenseApplications
                             where LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);


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
        public static int GetLicenseID(int LDLAppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Licenses.LicenseID 
                            from LocalDrivingLicenseFullApplications_View 
                            join Licenses
                            on LocalDrivingLicenseFullApplications_View.ApplicationID = Licenses.ApplicationID
                            where LocalDrivingLicenseFullApplications_View.LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);


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
        public static string GetNationalNoByLDLAppID(int LDLAppID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select NationalNo from LocalDrivingLicenseApplications_View
                            where LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();

                return (result != null ? result.ToString() : string.Empty);

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
