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

        private void brandComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedItem = ((DataRowView)brandComboBox.SelectedItem);
            string? autoBrand = selectedItem.Row["AutoBrand"].ToString();

            if (autoBrand != null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                modelComboBox.DataSource = connectionDB.GetAutoModelsFromQuery(autoBrand);
                modelComboBox.DisplayMember = "AutoModel";
            }
        }

        private void modelComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedItem = ((DataRowView)modelComboBox.SelectedItem);
            string? autoModel = selectedItem.Row["AutoModel"].ToString();

            if (autoModel != null)
            {
                ConnectionDB connectionModelDB = new ConnectionDB();
                seriesComboBox.DataSource = connectionModelDB.GetAutoSeriesFromQuery(autoModel);
                seriesComboBox.DisplayMember = "AutoSeries";

                ConnectionDB connectionLocationDB = new ConnectionDB();
                locationComboBox.DataSource = connectionLocationDB.GetCityLocationFromQuery(autoModel);
                locationComboBox.DisplayMember = "CityLocation";
            }
        }
    }
}
