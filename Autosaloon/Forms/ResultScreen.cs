using System;
using System.Windows.Forms;

namespace Autosaloon.Forms
{
    // Okno Result
    public partial class ResultScreen : Form
    {
        public ResultScreen()
        {
            InitializeComponent();
        }
        // Ukončení applikace
        private void CloseButtonInResult_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Exit();
        }
        // Zobrazení konečných dat
        private void ResultScreen_Load(object sender, EventArgs e)
        {
            autoBrandText.Text = Result.autoBrand;
            autoModelText.Text = Result.autoModel;
            autoSeriesText.Text = Result.autoSeries;
            cityLocationText.Text = Result.cityLocation;
            countText.Text = Result.count.ToString();

            autoImage.ImageLocation = @$"C:\Users\ponom\Desktop\Autosaloon_Ilya_Yushkov\Autosaloon\Autosaloon\Resources\Cars\" +
                @$"{autoBrandText.Text}\{autoModelText.Text}.jpg";
        }
        // Navrát v menu hledaní aut
        private void BackResultButton_Click(object sender, EventArgs e)
        {
            AutoSearcherScreen autoSearcherScreen = new AutoSearcherScreen();
            autoSearcherScreen.Show();
            Hide();
        }
    }
}
