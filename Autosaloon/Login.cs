using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class Login : Form
    {

        const string userID = "sa";
        const string password = "sa";

        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection($"Data Source=.;Initial Catalog=AutosaloonDB;User ID={userID};Password={password}");

        private DataSet GetDataSetFromQuery()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("Select * from AutosaloonTable", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            command.ExecuteNonQuery();

            connection.Close();

            return dataSet;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userIDTextBox.Texts = "";
            passwordTextBox.Texts = "";
        }
    }
}
