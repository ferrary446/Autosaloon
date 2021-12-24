using System;
using System.Data;
using System.Data.SqlClient;

namespace Autosaloon
{
    public class ConnectionDB
    {
        private SqlConnection connection = new SqlConnection($"Data Source=.;Initial Catalog=AutosaloonDB;User ID={LoginData.adminID};Password={LoginData.adminPassword}");

        public DataTable GetDataTableFromQuery(string query)
        {
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();

            connection.Close();

            return dataTable;
        }
    }
}
