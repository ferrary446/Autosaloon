using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Autosaloon
{
    public class ConnectionDB
    {
        private SqlConnection connection = new SqlConnection(
            $"Data Source=.;" +
            $"Initial Catalog=AutosaloonDB;" +
            $"User ID={LoginData.adminID};" +
            $"Password={LoginData.adminPassword}"
            );

        public DataTable GetDataTableFromQuery(string tableName)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand();

                connection.Open();

                command.CommandText = $"SELECT * FROM {tableName}";
                command.Connection = connection;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();

                return dataTable;
            }
        }

        public void InsertIntoAutosaloonTable(
            int autoID, 
            string autoBrand, 
            string autoModel, 
            string autoSeries, 
            string cityLocation
            )
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand();

                connection.Open();

                command.CommandText = "INSERT INTO AutosaloonTable " +
                "(AutoID, AutoBrand, AutoModel, AutoSeries, CityLocation) " +
                "values " + 
                $"('{autoID}', '{autoBrand}', '{autoModel}', '{autoSeries}', '{cityLocation}')";

                command.Connection = connection;

                command.ExecuteNonQuery();
                MessageBox.Show("Data has been saved in database!");

                connection.Close();
            }
        }

        public void RemoveFromAutosaloonTable(DataGridView dataGridView)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand();
                connection.Open();

                command.CommandText = "AutoRemove";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView.CurrentRow.Cells["idColumn"].Value));
                command.Connection = connection;
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
