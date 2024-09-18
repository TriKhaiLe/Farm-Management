using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project.Data_Layer
{
    public class ConnectionManager
    {
        public string GetDatabaseName(string connectionString)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                return builder.InitialCatalog;  // Retrieves the database name
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving database name: " + ex.Message);
                return null;
            }
        }

        public bool IsConnectionStringValid(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);
                return false;
            }
        }

        public string GetCurrentConnectionString()
        {
            string connStr = ConfigurationManager.ConnectionStrings["NongTraiDB"].ConnectionString.Trim();
            return connStr;
        }

        public void SaveConnectionString(string connStr)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["NongTraiDB"].ConnectionString = connStr;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
