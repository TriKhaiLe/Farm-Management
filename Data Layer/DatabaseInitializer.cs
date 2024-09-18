using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer
{
    public class DatabaseInitializer
    {
        private readonly string connectionString;
        private readonly string dbName;

        public DatabaseInitializer(string connStr, string dbName)
        {
            connectionString = connStr;
            this.dbName = dbName;
        }

        public void InitializeDatabase()
        {
            string tableName = "VatNuoi";
            if (DoesTableExist(tableName))
                ClearTable("VatNuoi");
            else 
                CreateTables();

            SeedData();
        }

        public void ClearTable(string tableName)
        {
            string query = $"TRUNCATE TABLE {tableName}";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"All data from table {tableName} has been cleared.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error clearing table data: " + ex.Message);
            }
        }


        public bool DoesTableExist(string tableName)
        {
            string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @TableName";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the table name as a parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@TableName", tableName);

                        int count = (int)command.ExecuteScalar();

                        // If count is greater than 0, the table exists
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking for table existence: " + ex.Message);
                return false;
            }
        }


        private void SeedData()
        {
            string insertDataQuery = $@"
            USE {dbName};
            INSERT INTO VatNuoi (LoaiVat, SoLuong, LuongSua)
            VALUES 
            ('Bo', 2, 0),
            ('Cuu', 2, 0),
            ('De', 2, 0);
            ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(insertDataQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CreateTables()
        {
            string createTableQuery = $@"
            USE {dbName};
            CREATE TABLE VatNuoi (
                Id INT PRIMARY KEY IDENTITY(1,1),
                LoaiVat NVARCHAR(50),
                SoLuong INT,
                LuongSua DECIMAL
            );";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(createTableQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
