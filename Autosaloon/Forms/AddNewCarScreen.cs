using System;
using System.Data;
using System.Windows.Forms;

namespace Autosaloon
{
    // Menu práce s tabulkou aut
    public partial class AddNewCarScreen : Form, ControlAndReloadFunctions
    {
        public AddNewCarScreen()
        {
            InitializeComponent();
        }
        // Kontrola prázdných hodnot v pole TextBox 
        public bool TextBoxDataChecked()
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
        // Kontrola pole AutoID na obsah čísla
        public int ParserAutoIDTextBox(string parseText)
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
        // Obnova tabulky
        public void ReloadData()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            DataTable dataTable = connectionDB.GetDataTableFromQuery("AutosaloonTable");
            tableCarsGridView.DataSource = dataTable;
        }
        // Tlačitko přidaní nového auta
        private void AddCarButton_Click(object sender, EventArgs e)
        {
            if (TextBoxDataChecked())
            {
                ConnectionDB connectionDB = new ConnectionDB();
                connectionDB.InsertIntoAutosaloonTable(
                                                    ParserAutoIDTextBox(autoIDTextBox.Texts),
                                                    autoBrandTextBox.Texts,
                                                    autoModelTextBox.Texts,
                                                    autoSeriesTextBox.Texts,
                                                    cityLocationTextBox.Texts
                                                    );
            }
            ReloadData();
        }
        // Tlačitko vymazaní auta z tabulky
        private void RemoveCarButton_Click(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            connectionDB.RemoveFromAutosaloonTable(tableCarsGridView);
            try
            {
                ReloadData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        // Vráceni v okno přihlašení 
        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }
        // Obnova dat při spuštění
        private void AddNewCarMenu_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        // Volaní menu opravy udajů
        private void TableCarsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditScreen editScreen = new EditScreen();
            editScreen.dataGridView = tableCarsGridView;
            editScreen.Show();
        }
    }
}
