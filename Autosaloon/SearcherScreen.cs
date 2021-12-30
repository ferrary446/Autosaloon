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

            ConnectionDB countConnectionDB = new ConnectionDB();
            countProgressBar.Value = countConnectionDB.GetCountModelsFromQuery();

            if (countProgressBar.Maximum == countProgressBar.Value)
            {
                countProgressBar.ForeBackColor = System.Drawing.Color.Red;
            }
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

                ConnectionDB countConnectionDB = new ConnectionDB();
                countProgressBar.Value = countConnectionDB.GetCountModelsByRange("AutoModel", "AutoBrand", autoBrand);

                if (countProgressBar.Value < countProgressBar.Maximum)
                {
                    countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
                }
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

                ConnectionDB countConnectionDB = new ConnectionDB();
                countProgressBar.Value = countConnectionDB.GetCountModelsByRange("AutoSeries", "AutoModel", autoModel);

                if (countProgressBar.Value < countProgressBar.Maximum)
                {
                    countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
                }
            }
        }

        private void seriesComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedModel = ((DataRowView)modelComboBox.SelectedItem);
            string? autoModel = selectedModel.Row["AutoModel"].ToString();

            DataRowView selectedSeries = ((DataRowView)seriesComboBox.SelectedItem);
            string? autoSeries = selectedSeries.Row["AutoSeries"].ToString();

            if (autoModel != null && autoSeries != null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                locationComboBox.DataSource =  connectionDB.GetCityLocationFromQuery(autoModel, autoSeries);
                locationComboBox.DisplayMember = "CityLocation";

                ConnectionDB countConnectionDB = new ConnectionDB();
                countProgressBar.Value = countConnectionDB.GetCountModelsByRange("CityLocation", "AutoModel", autoModel, $"and AutoSeries = '{autoSeries}'");

                if (countProgressBar.Value < countProgressBar.Maximum)
                {
                    countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
                }
            }
        }
    }
}
