using System;
using System.Windows.Forms;

namespace Autosaloon
{
    // Menu přihlašení
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        // Kontrola přihlašovacích udajů
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
                    AddNewCarScreen addNewCarMenu = new AddNewCarScreen();
                    addNewCarMenu.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter user and password!");
            }
        }
        // Možnost vyčištění přihlašovacích pole
        private void ClearButton_Click(object sender, EventArgs e)
        {
            userIDTextBox.Texts = "";
            passwordTextBox.Texts = "";
        }
        // Spuštění menu práce s tabulkou aut 
        private void SignInButton_Click(object sender, EventArgs e)
        {
            LoginChecked();
        }
        // Skryvaní symbolů hesla
        private void Login_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = true;
        }
        // Vráceni v menu vyberu uživatěle
        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginMethodsScreen loginMethodsScreen = new LoginMethodsScreen();
            loginMethodsScreen.Show();
            Hide();
        }
    }
}
