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

        private void reloadData()
        {
            
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void editCarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                MessageBox.Show("Not null!");
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
