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
        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("Select * from AutosaloonTable", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            command.ExecuteNonQuery();

            connection.Close();

            rjComboBox1.DataSource = dataSet.Tables[0];
            rjComboBox1.DisplayMember = "AutoBrand";
            rjComboBox1.ValueMember = "AutoID";
        }

        private void RjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rjComboBox1.SelectedIndex)
            {
                case 0:
                     
                    break;

                case 1:
                    break;

                default: 
                    break;
            }
        }
    }
}
