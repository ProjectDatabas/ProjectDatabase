using System;
using SomerenLogic;
using SomerenModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class LoginUI : Form
    {
        private LoginLogic loginLogic = new LoginLogic();

        public LoginUI()
        {
            InitializeComponent();
        }

        // Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginSuccess = loginLogic.CheckLogin(emailLabel.Text, passwordLabel.Text);
            Login currentUser = loginLogic.GetCurrentUser(emailLabel.Text, passwordLabel.Text);
            // Check if username and password are correct
            if (loginSuccess)
            {
                // If correct, show the main form
                SomerenUI mainFrame = new SomerenUI(user);
                mainFrame.Show();
                this.Hide();
            }
            else
            {
                // If incorrect, show error message
                MessageBox.Show("Incorrect username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //create instance of new form
            RegistrationForm registerUI = new RegistrationForm();

            //Display the new form
            this.Hide();
            registerUI.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
