using System;
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
        public LoginUI()
        {
            InitializeComponent();
        }

        // Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if username and password are correct
            if (emailTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                // Show the main screen
                SomerenUI mainFrame = new SomerenUI();
                mainFrame.Show();
                this.Hide();
            }
            else
            {
                // Show error message
                MessageBox.Show("Incorrect username or password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
