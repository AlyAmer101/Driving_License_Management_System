using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___DataAccessLayer
{
    public class clsPersonTestsInfoData
    {

        public static int GetResultOfLastVisionTestByPersonID(int PersonID, int LicenseClassID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                                select top 1 TestResult from PersonTestsInfo_View
                                where PersonID = @PersonID 
                                and TestTypeID = @TestTypeID
                                and LicenseClassID = @LicenseClassID
                                Order by TestAppointmentID DESC
                            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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


    }

}
