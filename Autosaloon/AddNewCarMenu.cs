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

        private bool textBoxDataChecked()
        {
            bool checker = false;

            if (autoIDTextBox.Texts != "" && 
                autoBrandTextBox.Texts != "" &&
                autoModelTextBox.Texts != "" &&
                autoSeriesTextBox.Texts != "" &&
                cityLocationTextBox.Texts != "")
            {
                checker = true;
            }
            else
            {
                MessageBox.Show("All fields must be filled!");
            }

            return checker;
        }

        private int parserAutoIDTextBox(string parseText)
        {
            int id = 0;

            try
            {
                id = Int32.Parse(parseText);
            }
            catch (FormatException)
            {
                MessageBox.Show("Auto ID must be number!");
            }

            return id;
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            if (textBoxDataChecked())
            {
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.InsertIntoAutosaloonTable(
                                                    parserAutoIDTextBox(autoIDTextBox.Texts),
                                                    autoBrandTextBox.Texts,
                                                    autoModelTextBox.Texts,
                                                    autoSeriesTextBox.Texts,
                                                    cityLocationTextBox.Texts
                                                    );
            }
        }

        private void EditCarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveCarButton_Click(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.RemoveFromAutosaloonTable(tableCarsGridView);
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
            DataTable dataTable = connectionDB.GetDataTableFromQuery("AutosaloonTable");
            tableCarsGridView.DataSource = dataTable;
        }
    }
}
