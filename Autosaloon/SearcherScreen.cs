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

            countProgressBar.Value = 15;
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
                ConnectionDB connectionDB = new ConnectionDB();
                seriesComboBox.DataSource = connectionDB.GetAutoSeriesFromQuery(autoModel);
                seriesComboBox.DisplayMember = "AutoSeries";
            }
        }

        private void seriesComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedBrand = ((DataRowView)brandComboBox.SelectedItem);
            string? autoBrand = selectedBrand.Row["AutoBrand"].ToString();

            DataRowView selectedSeries = ((DataRowView)seriesComboBox.SelectedItem);
            string? autoSeries = selectedSeries.Row["AutoSeries"].ToString();

            if (autoBrand != null && autoSeries != null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                locationComboBox.DataSource =  connectionDB.GetCityLocationFromQuery(autoBrand, autoSeries);
                locationComboBox.DisplayMember = "CityLocation";
            }
        }
    }
}
