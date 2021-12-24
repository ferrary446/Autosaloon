using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class AddNewCarMenu : Form
    {
        public AddNewCarMenu()
        {
            InitializeComponent();
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            DataTable dataTable = connectionDB.GetDataTableFromQuery("insert into AutosaloonTable " +
                "(AutoID, AutoBrand, AutoModel, AutoSeries, CityLocation) " +
                "values " +
                "('1', 'Audi', 'A3', 'S-Line', 'Prague')");
            tableCarsGridView.DataSource = dataTable;
        }

        private void EditCarButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveCarButton_Click(object sender, EventArgs e)
        {

        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }

        private void ShowAllCarsButton_Click(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            DataTable dataTable = connectionDB.GetDataTableFromQuery("select * from AutosaloonTable");
            tableCarsGridView.DataSource = dataTable;
        }
    }
}
