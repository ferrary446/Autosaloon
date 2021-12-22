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
    public partial class LoginMethodsScreen : Form
    {
        public LoginMethodsScreen()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            AutoSearcher autoSearcher = new AutoSearcher();
            autoSearcher.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
