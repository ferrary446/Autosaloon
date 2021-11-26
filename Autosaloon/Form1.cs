using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AutoDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from autoTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            rjComboBox1.DataSource = ds.Tables[0];
            rjComboBox1.DisplayMember = "AutoBrand";
            rjComboBox1.ValueMember = "AutoID";
        }

        private void RjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rjComboBox1.SelectedIndex)
            {
                case 0:
                    rjComboBox2.Items.Clear();
                    rjComboBox2.Items.Add("A1");
                    break;

                case 1:
                    rjComboBox2.Items.Clear();
                    rjComboBox2.Items.Add("330i");
                    break;

                default: 
                    rjComboBox2.Items.Clear();
                    break;
            }
        }
    }
}
