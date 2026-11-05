using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD___DataAccessLayer
{
    public class clsDetainedLicensesData
    {
        //! DataAccess Layer 
        public static bool IsUserCreatedAnyDetainedLicense(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 1 from DetainedLicenses where CreatedByUserID = @UserID";

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
        public static bool IsLicenseDetained(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select LicenseID from DetainedLicenses_View
                            where LicenseID = @LicenseID and IsReleased = 0";

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

        public static void GetDetainedLicenseInfo(int LicenseID, ref int DetainID, ref int CreatedByUserID, ref int FineFees, ref DateTime DetainDate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 * from DetainedLicenses 
                            where LicenseID = @LicenseID
                            order by DetainID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    FineFees = Convert.ToInt32(reader["FineFees"]);
                    DetainDate = Convert.ToDateTime(reader["DetainDate"]);

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


        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses
                            (LicenseID, DetainDate, FineFees, IsFeesPaid ,CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                            VALUES 
                            (@LicenseID, @DetainDate, @FineFees, 0 ,@CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID)
                            select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            command.Parameters.AddWithValue("@IsReleased", 0);
            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);


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


        public static bool ReleaseDetainedLicense(int LicenseID, int IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update DetainedLicenses
                            Set IsFeesPaid = 1, IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                            where DetainID = (select top 1 DetainID from DetainedLicenses where LicenseID = @LicenseID AND IsReleased = 0 order by DetainID desc)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
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
