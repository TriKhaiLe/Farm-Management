using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer
{
    internal class VatNuoiDAL
    {
        private string connectionString = "your_connection_string_here";

        public VatNuoiDAL(string connStr)
        {
            connectionString = connStr;
        }

        public DataTable LayDSVatNuoi()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VatNuoi", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void CapNhatDSVatNuoi(DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Delete all existing records
                using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM VatNuoi", conn))
                {
                    deleteCommand.ExecuteNonQuery();
                }

                // Step 2: Re-insert the new data from the DataTable
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VatNuoi", conn))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);

                    // This will insert only the rows present in the DataTable after the deletion
                    da.Update(dt);
                }
            }
        }

    }
}
