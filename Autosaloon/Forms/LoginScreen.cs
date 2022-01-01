using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autosaloon
{
    public partial class LoginScreen : Form
    {

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginChecked()
        {
            if (userIDTextBox.Texts != "" && passwordTextBox.Texts != "")
            {
                if (userIDTextBox.Texts != LoginData.adminID || passwordTextBox.Texts != LoginData.adminPassword)
                {
                    MessageBox.Show("Login or password is wrong!");
                }
                else
                {
                    AddNewCarMenu addNewCarMenu = new AddNewCarMenu();
                    addNewCarMenu.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter user and password!");
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            userIDTextBox.Texts = "";
            passwordTextBox.Texts = "";
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            LoginChecked();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginMethodsScreen loginMethodsScreen = new LoginMethodsScreen();
            loginMethodsScreen.Show();
            Hide();
        }
    }
}
