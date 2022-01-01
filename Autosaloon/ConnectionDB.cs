using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Autosaloon
{
    // Class pro použiti databáze
    public class ConnectionDB
    {
        // Instalujeme připojení k databáze
        private readonly SqlConnection connection = new SqlConnection(
            $"Data Source=.;" +
            $"Initial Catalog=AutosaloonDB;" +
            $"User ID={LoginData.adminID};" +
            $"Password={LoginData.adminPassword}"
            );
        // Získávame celou tabulku z databáze
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
        // Získávame filtrovanou tabulku pro použití v comboboxu
        public DataTable GetSelectDistinctValueFromQuery(
            string selectParametr,
            string tableName,
            string topRowName,
            string? firstOptionalParametr = null,
            string? secondOptionalParametr = null)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand();

                connection.Open();

                command.CommandText = $"SELECT DISTINCT {selectParametr} " +
                    $"FROM {tableName}" +
                    $" {firstOptionalParametr}" +
                    $" {secondOptionalParametr}";
                command.Connection = connection;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                DataRow topRow = dataTable.NewRow();
                topRow[0] = topRowName;
                dataTable.Rows.InsertAt(topRow, 0);
                command.ExecuteNonQuery();

                connection.Close();

                return dataTable;
            }
        }
        // Získávame množství všech aut skladem pro zobrazení v ProgressView
        public int GetCountModelsFromQuery()
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand();

                connection.Open();

                command.CommandText = "SELECT AutoModel FROM AutosaloonTable";
                command.Connection = connection;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();

                return dataTable.Rows.Count;
            }
        }
        // Získávame množství filtrovaných comboboxem aut skladem pro zobrazení v ProgressView
        public int GetCountModelsByRange(
            string selectParametr, 
            string whereParametr,
            string valueForWhere,
            string? optionalParametr = null
            )
        {
            SqlCommand command = new SqlCommand();

            connection.Open();

            command.CommandText = $"SELECT {selectParametr} FROM AutosaloonTable " +
                $"WHERE {whereParametr} = '{valueForWhere}'" +
                optionalParametr;
            command.Connection = connection;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            command.ExecuteNonQuery();

            connection.Close();

            return dataTable.Rows.Count;
        }
        // Funkce pro možnost přidat nové auto do tabulky
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
        // Funkce pro možnost vymazat nové auto z tabulky
        public void RemoveFromAutosaloonTable(DataGridView dataGridView)
        {
            using (connection)
            {
                if (dataGridView.CurrentRow != null) 
                {
                    SqlCommand command = new SqlCommand();

                    connection.Open();

                    command.CommandText = "AutoRemove";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView.CurrentRow.Cells["idColumn"].Value));
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data has been removed!");

                    connection.Close();
                }
                else 
                {
                    MessageBox.Show("The table is empty!");
                }
            }
        }
        // Funkce pro možnost opravit udaje o existujícím aute v tabulce
        public void EditInAutosaloonTable(
            DataGridView dataGridView,
            int autoID,
            string autoBrand,
            string autoModel,
            string autoSeries,
            string cityLocation
            )
        {
            using (connection)
            {
                if (dataGridView.CurrentRow != null)
                {
                    SqlCommand command = new SqlCommand();

                    connection.Open();

                    command.CommandText = "AutoAddOrEdit";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView.CurrentRow.Cells["idColumn"].Value));
                    command.Parameters.AddWithValue("@AutoID", autoID);
                    command.Parameters.AddWithValue("@AutoBrand", autoBrand);
                    command.Parameters.AddWithValue("@AutoModel", autoModel);
                    command.Parameters.AddWithValue("@AutoSeries", autoSeries);
                    command.Parameters.AddWithValue("@CityLocation", cityLocation);
                    command.Connection = connection;
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                else
                {
                    MessageBox.Show("The table is empty!");
                }
            }
        }
    }
}
