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
            // Check if username and password are correct
            if (loginLogic.CheckLogin(emailTextBox.Text, passwordTextBox.Text))
            {
                // If correct, show the main form
                SomerenUI mainFrame = new SomerenUI();
                mainFrame.Show();
                this.Hide();
            }
            else
            {
                // If incorrect, show error message
                MessageBox.Show("Incorrect username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
