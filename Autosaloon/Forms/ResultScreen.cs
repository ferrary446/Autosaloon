using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosaloon.Forms
{
    public partial class ResultScreen : Form
    {
        public ResultScreen()
        {
            InitializeComponent();
        }

        private void CloseButtonInResult_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Exit();
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            autoBrandText.Text = Result.autoBrand;
            autoModelText.Text = Result.autoModel;
            autoSeriesText.Text = Result.autoSeries;
            cityLocationText.Text = Result.cityLocation;
            countText.Text = Result.count.ToString();
        }

        private void BackResultButton_Click(object sender, EventArgs e)
        {
            AutoSearcherScreen autoSearcherScreen = new AutoSearcherScreen();
            autoSearcherScreen.Show();
            Hide();
        }
    }
}
