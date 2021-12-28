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

        public void reloadData()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            DataTable dataTable = connectionDB.GetDataTableFromQuery("AutosaloonTable");
            tableCarsGridView.DataSource = dataTable;
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
            reloadData();
        }

        private void RemoveCarButton_Click(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.RemoveFromAutosaloonTable(tableCarsGridView);
            try
            {
                reloadData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }

        private void AddNewCarMenu_Load(object sender, EventArgs e)
        {
            reloadData();
        }

        private void tableCarsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditScreen editScreen = new EditScreen();
            editScreen.dataGridView = tableCarsGridView;
            
            editScreen.Show();
            //MessageBox.Show($"{e.RowIndex},{e.ColumnIndex}");
        }
    }
}
