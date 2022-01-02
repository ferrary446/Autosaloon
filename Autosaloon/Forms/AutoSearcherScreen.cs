using Autosaloon.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Autosaloon
{
    // Menu hledaní aut
    public partial class AutoSearcherScreen : Form
    {
        public AutoSearcherScreen()
        {
            InitializeComponent();
        }
        // Obnova dat v menu při spuštění
        private void AutoSearcher_Load(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
            brandComboBox.DataSource = connectionDB.GetSelectDistinctValueFromQuery(
                "AutoBrand", 
                "AutosaloonTable",
                "Select brand");
            brandComboBox.DisplayMember = "AutoBrand";

            ConnectionDB maximumCountConnectionDB = new ConnectionDB();
            countProgressBar.Maximum = maximumCountConnectionDB.GetCountModelsFromQuery();

            ConnectionDB countConnectionDB = new ConnectionDB();
            countProgressBar.Value = countConnectionDB.GetCountModelsFromQuery();

            if (countProgressBar.Maximum == countProgressBar.Value)
            {
                countProgressBar.ForeBackColor = System.Drawing.Color.Red;
            }
        }
        // Vráceni v menu vyberu uživatěle
        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            LoginMethodsScreen loginMethodsScreen = new LoginMethodsScreen();
            loginMethodsScreen.Show();
            Hide();
        }
        // Ukončení programy
        private void CloseButtonInSearcher_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Exit();
        }
        // Obnova comboboxu AutoModel při vyberu brandu v comboboxu AutoBrand
        private void BrandComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedItem = ((DataRowView)brandComboBox.SelectedItem);
            string? autoBrand = selectedItem.Row["AutoBrand"].ToString();

            if (autoBrand != null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                modelComboBox.DataSource = connectionDB.GetSelectDistinctValueFromQuery(
                    "AutoModel",
                    "AutosaloonTable",
                    "Select model",
                    $"WHERE AutoBrand = '{autoBrand}'");
                modelComboBox.DisplayMember = "AutoModel";

                ConnectionDB countConnectionDB = new ConnectionDB();
                countProgressBar.Value = countConnectionDB.GetCountModelsByRange(
                    "AutoModel", 
                    "AutoBrand", 
                    autoBrand);

                if (countProgressBar.Value < countProgressBar.Maximum)
                {
                    countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
                }

                Result.autoBrand = autoBrand;
            }
        }
        // Obnova comboboxu AutoSeries při vyberu modelu v comboboxu AutoModel
        private void ModelComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedItem = ((DataRowView)modelComboBox.SelectedItem);
            string? autoModel = selectedItem.Row["AutoModel"].ToString();

            if (autoModel != null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                seriesComboBox.DataSource = connectionDB.GetSelectDistinctValueFromQuery(
                    "AutoSeries",
                    "AutosaloonTable",
                    "Select series",
                    $"WHERE AutoModel = '{autoModel}'");
                seriesComboBox.DisplayMember = "AutoSeries";

                ConnectionDB countConnectionDB = new ConnectionDB();
                countProgressBar.Value = countConnectionDB.GetCountModelsByRange(
                    "AutoSeries", 
                    "AutoModel", 
                    autoModel);

                if (countProgressBar.Value < countProgressBar.Maximum)
                {
                    countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
                }

                Result.autoModel = autoModel;
            }
        }
        /* 
        Obnova comboboxu CityLocation při vyberu modelu v comboboxu AutoModel
        a serie v comboboxu AutoSeries
        */
        private void SeriesComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedModel = ((DataRowView)modelComboBox.SelectedItem);
            string? autoModel = selectedModel.Row["AutoModel"].ToString();

            DataRowView selectedSeries = ((DataRowView)seriesComboBox.SelectedItem);
            string? autoSeries = selectedSeries.Row["AutoSeries"].ToString();

            if (autoModel != null && autoSeries != null)
            {
                ConnectionDB connectionDB = new ConnectionDB();
                locationComboBox.DataSource =  connectionDB.GetSelectDistinctValueFromQuery(
                    "CityLocation",
                    "AutosaloonTable",
                    "Select city",
                    $"WHERE AutoModel = '{autoModel}'",
                    $"AND AutoSeries = '{autoSeries}'");
                locationComboBox.DisplayMember = "CityLocation";

                ConnectionDB countConnectionDB = new ConnectionDB();
                countProgressBar.Value = countConnectionDB.GetCountModelsByRange(
                    "CityLocation", 
                    "AutoModel", 
                    autoModel, 
                    $"and AutoSeries = '{autoSeries}'");

                if (countProgressBar.Value < countProgressBar.Maximum)
                {
                    countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
                }

                Result.autoSeries = autoSeries;
            }
        }

        private void LocationComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedModel = ((DataRowView)modelComboBox.SelectedItem);
            string? autoModel = selectedModel.Row["AutoModel"].ToString();

            DataRowView selectedSeries = ((DataRowView)seriesComboBox.SelectedItem);
            string? autoSeries = selectedSeries.Row["AutoSeries"].ToString();

            DataRowView selectedLocation = ((DataRowView)locationComboBox.SelectedItem);
            string? cityLocation = selectedLocation.Row["CityLocation"].ToString();

            if (autoModel != null && 
                autoSeries != null &&
                cityLocation != null)
            {
                ConnectionDB countConnectionDB = new ConnectionDB();
                countProgressBar.Value = countConnectionDB.GetCountModelsByRange(
                    "CityLocation",
                    "AutoModel",
                    autoModel,
                    $"and AutoSeries = '{autoSeries}' " +
                    $"and CityLocation = '{cityLocation}'");

                if (countProgressBar.Value < countProgressBar.Maximum)
                {
                    countProgressBar.ForeBackColor = System.Drawing.Color.Gold;
                }

                Result.cityLocation = cityLocation;
                Result.count = countProgressBar.Value;
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (brandComboBox.SelectedIndex != 0 &&
                modelComboBox.SelectedIndex != 0 &&
                seriesComboBox.SelectedIndex != 0 &&
                locationComboBox.SelectedIndex != 0)
            {
                ResultScreen resultScreen = new ResultScreen();
                resultScreen.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please select all positions");
            }
        }
    }
}
