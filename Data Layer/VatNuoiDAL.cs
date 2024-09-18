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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VatNuoi", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Update(dt);
            }
        }

    }
}
