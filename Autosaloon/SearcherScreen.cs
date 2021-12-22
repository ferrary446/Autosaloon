using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class AutoSearcher : Form
    {

        private const string userID = "sa";
        private const string password = "sa";

        public AutoSearcher()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection($"Data Source=.;Initial Catalog=AutosaloonDB;User ID={userID};Password={password}");

        public DataSet GetDataSetFromQuery()
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

        private void AutoSearcher_Load(object sender, EventArgs e)
        {
            rjComboBox1.DataSource = GetDataSetFromQuery().Tables[0];
            rjComboBox1.DisplayMember = "AutoBrand";
            rjComboBox1.ValueMember = "AutoID";
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginMethodsScreen loginMethodsScreen = new LoginMethodsScreen();
            loginMethodsScreen.Show();
            Hide();
        }

        private void CloseButtonInSearcher_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
