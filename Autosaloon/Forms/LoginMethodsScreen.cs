using System;
using System.Windows.Forms;

namespace Autosaloon
{
    // Startové menu vyberu uživatěle
    public partial class LoginMethodsScreen : Form
    {
        public LoginMethodsScreen()
        {
            InitializeComponent();
        }
        // Spuštění menu přihlašovaní
        private void AdminButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }
        // Spuštění menu hledaní aut
        private void CustomerButton_Click(object sender, EventArgs e)
        {
            AutoSearcherScreen autoSearcher = new AutoSearcherScreen();
            autoSearcher.Show();
            Hide();
        }
        // Ukončení programy
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            Application.Exit();
        }
    }
}
