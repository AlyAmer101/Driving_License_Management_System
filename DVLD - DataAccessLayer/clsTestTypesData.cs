using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD___DataAccessLayer
{
    public class clsTestTypesData
    {
        public static int GetTestFeesByTestTypeID(int TestTypeID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestTypeFees from TestTypes where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();

                connection.Close();

                return (result != null ? Convert.ToInt32(result) : 0);

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


        public static bool UpdateTestTypesByID(int TestTypeID, string NewTitle, string NewDescription, double NewFees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestTypes SET
                TestTypeTitle = @NewTitle, TestTypeDescription = @NewDescription, TestTypeFees = @NewFees
                WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NewTitle", NewTitle);
            command.Parameters.AddWithValue("@NewDescription", NewDescription);
            command.Parameters.AddWithValue("@NewFees", NewFees);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
