using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace Olympic_stats_xamarin.Helpers
{
    internal class ServerDB
    {
        private static ServerDB uniqueInstance;
        public static ServerDB Instance
        {
            get
            {
                if (uniqueInstance != null) return uniqueInstance;
                uniqueInstance = new ServerDB();
                return uniqueInstance;
            }
        }

        public SqlConnection Connection { get; set; }
        public ServerDB()
        {
            SetDBConnection();
        }
        private void SetDBConnection()
        {
            string server = "192.168.100.9";
            //string @default = "192.168.56.1";
            string sqlConnectionString = $"Data Source={server};Initial Catalog=Olympic-stats;User ID=nikawak-olympic;Password=1cTdJGV6vE25GHkZ";
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                connection.Close();
                foreach (SqlError e in ex.Errors)
                    Debug.WriteLine("Sql-ошибка со строкой подключения: " + e.Message);
                throw;
            }
            catch (Exception ex)
            {
                connection.Close();
                Debug.WriteLine("Другая ошибка со строкой подключения: " + ex.Message);
                throw;
            }
            Connection = connection;
        }
    }
}
