using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=AutosaloonDB;User ID=sa;Password=sa");

        public Form1()
        {
            InitializeComponent();
        }

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
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataTable dataTable in GetDataSetFromQuery().Tables)
            {
                rjComboBox1.DataSource = dataTable;
                rjComboBox1.DisplayMember = "AutoBrand";
                rjComboBox1.ValueMember = "AutoID";
            }

            
        }
    }
}
