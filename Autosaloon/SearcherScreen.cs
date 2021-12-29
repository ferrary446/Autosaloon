using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class AutoSearcher : Form
    {
        public AutoSearcher()
        {
            InitializeComponent();
        }

        private void AutoSearcher_Load(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            brandComboBox.DataSource = connectionDB.GetAutoBrandsFromQuery();
            brandComboBox.DisplayMember = "AutoBrand";
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginMethodsScreen loginMethodsScreen = new LoginMethodsScreen();
            loginMethodsScreen.Show();
            Hide();
        }

        private void CloseButtonInSearcher_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Exit();
        }
    }
}
