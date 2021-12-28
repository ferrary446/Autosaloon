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
    public partial class EditScreen : Form
    {
        public DataGridView dataGridView = new DataGridView();
        public EditScreen()
        {
            InitializeComponent();
        }
        private bool TextBoxDataChecked()
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
        private int ParserAutoIDTextBox(string parseText)
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
        private void ReloadData()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            DataTable dataTable = connectionDB.GetDataTableFromQuery("AutosaloonTable");
            dataGridView.DataSource = dataTable;
        }
        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
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
