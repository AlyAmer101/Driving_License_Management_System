using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccessLayer
{
    public class clsLicensesData
    {
        //! DataAccess Layer 
        public static bool IsUserCreatedAnyLicense(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 1 from Licenses where CreatedByUserID = @UserID";

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
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, int IsActive, int IssueReason, int CreatedByUserID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Licenses
                            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                            VALUES 
                            (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID)
                            select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);


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
        public static DateTime CalcExpirationDate(DateTime IssueDate, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select DefaultValidityLength from LicenseClasses
                            where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();


                object result = command.ExecuteScalar();

                connection.Close();

                if (result != null)
                    return (IssueDate).AddYears(Convert.ToInt32(result));
                else
                    return DateTime.MaxValue;
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return DateTime.MaxValue;
        }
        public static string GetLicenseClassByLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select LicenseClasses.ClassName from Licenses
                            join LicenseClasses
                            on LicenseClasses.LicenseClassID = Licenses.LicenseClass
                            where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
        public static int GetLicenseClassIdByLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select LicenseClass from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
        public static DateTime GetIssueDateByLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select IssueDate from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return Convert.ToDateTime(result);
                else
                    return DateTime.MinValue;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return DateTime.MinValue;
        }
        public static DateTime GetExpirationDateByLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ExpirationDate from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return Convert.ToDateTime(result);
                else
                    return DateTime.MinValue;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return DateTime.MinValue;
        }
        public static int GetIssueReasonByLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select IssueReason from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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

        public static int GetPersonID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Applications.ApplicantPersonID from Licenses
                            join Applications
                            on Applications.ApplicationID = Licenses.ApplicationID
                            where Licenses.LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
        public static int GetDriverID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select DriverID from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
        public static string GetLicenseNotesByLicenseID(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Notes from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
        public static short IsLicenseActive(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"select IsActive from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return Convert.ToInt16(result);
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
        public static bool IsLicenseExist(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"select 1 from Licenses
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

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
        public static DateTime GetLicenseExpirationDate(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"select ExpirationDate from Licenses
                            where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();


                if (result != null && result != DBNull.Value)
                    return Convert.ToDateTime(result);
                else
                    return DateTime.MinValue;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Erorr : " + ex);

            }
            finally
            {
                connection.Close();
            }

            return DateTime.MinValue;
        }
        public static bool IsPersonHasLicenseClassThree(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = @"select 1 from Licenses
                            where LicenseID = @LicenseID and LicenseClass = 3;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

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
        public static bool IsPersonHaveLicenseInThisClass(int PersonID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Licenses.LicenseID 
                            from Licenses
                            join Applications
                            on Applications.ApplicationID = Licenses.ApplicationID
                            where Licenses.LicenseClass = @LicenseClassID 
                            and Applications.ApplicantPersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

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

        public static bool UpdateLicenseStatus(int LicenseID, int Status)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Licenses
                            Set IsActive = @Status
                            where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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
