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

                command.CommandText = $"select * from {tableName}";
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
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow removeRow = dataGridView.Rows[i];
                    if (removeRow.Selected == true)
                    {
                        try
                        {
                            dataGridView.Rows.RemoveAt(i);
                        }
                        catch (System.InvalidOperationException)
                        {
                            MessageBox.Show("The row is empty!");
                        }
                        try
                        {
                            command.CommandText = "DELETE FROM AutosaloonTable WHERE AutoID=" + i + "";
                            command.Connection = connection;
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
