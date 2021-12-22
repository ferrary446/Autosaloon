using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class LoginScreen : Form
    {

        private const string userID = "sa";
        private const string password = "sa";

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginChecked()
        {
            if (userIDTextBox.Texts != "" && passwordTextBox.Texts != "")
            {
                if (userIDTextBox.Texts != userID || passwordTextBox.Texts != password)
                {
                    MessageBox.Show("Login or password is wrong!");
                }
                else
                {
                    AutoSearcher searcher = new AutoSearcher();
                    searcher.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter user and password!");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            userIDTextBox.Texts = "";
            passwordTextBox.Texts = "";
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            LoginChecked();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = true;
        }
    }
}
