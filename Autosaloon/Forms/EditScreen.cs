using System;
using System.Data;
using System.Windows.Forms;
using Autosaloon.Database;

namespace Autosaloon
{
    // Menu opravy udajů
    public partial class EditScreen : Form, ControlAndReloadFunctions
    {
        // Tabulka pro obnovu
        public DataGridView dataGridView = new DataGridView();
        public EditScreen()
        {
            InitializeComponent();
        }
        // Kontrola prázdných hodnot v pole TextBox
        public bool TextBoxDataChecked()
        {
            bool checker = false;

            if (autoIDTextBoxEdit.Texts != "" &&
                autoBrandTextBoxEdit.Texts != "" &&
                autoModelTextBoxEdit.Texts != "" &&
                autoSeriesTextBoxEdit.Texts != "" &&
                cityLocationTextBoxEdit.Texts != "")
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
            dataGridView.DataSource = dataTable;
        }
        // Schovat menu bez oprav
        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
        // Schovat menu s opravami
        private void EditCarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                if (TextBoxDataChecked())
                {
                    ConnectionDB connectionDB = new ConnectionDB();
                    connectionDB.EditInAutosaloonTable(
                        dataGridView, 
                        ParserAutoIDTextBox(autoIDTextBoxEdit.Texts),
                        autoBrandTextBoxEdit.Texts,
                        autoModelTextBoxEdit.Texts,
                        autoSeriesTextBoxEdit.Texts,
                        cityLocationTextBoxEdit.Texts
                        );
                    ReloadData();
                    Hide();
                }
            }
        }
        // Obnova dat při spuštění
        private void EditScreen_Load(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                autoIDTextBoxEdit.Texts = dataGridView.CurrentRow.Cells["autoIDColumn"].Value.ToString();
                autoBrandTextBoxEdit.Texts = dataGridView.CurrentRow.Cells["autoBrandColumn"].Value.ToString();
                autoModelTextBoxEdit.Texts = dataGridView.CurrentRow.Cells["autoModelColumn"].Value.ToString();
                autoSeriesTextBoxEdit.Texts = dataGridView.CurrentRow.Cells["autoSeriesColumn"].Value.ToString();
                cityLocationTextBoxEdit.Texts = dataGridView.CurrentRow.Cells["cityLocationColumn"].Value.ToString();
            }
        }
    }
}
