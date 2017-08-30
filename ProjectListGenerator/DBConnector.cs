using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics;

namespace ProjectListGenerator
{
    public class DBConnector
    {
        private SqlConnection connection;

        public DBConnector()
        {
            try
            {
                this.connection = new SqlConnection();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Connect(String connectionString)
        {
            try
            {
                Debug.WriteLine(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionString].ConnectionString);
                this.connection.Open();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void Disconnect()
        {
           Debug.WriteLine(connection.State);
           if (this.connection.State != ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }


        public SqlDataReader Query(string query)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, this.connection))
                {
                    return command.ExecuteReader();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

    }
}
