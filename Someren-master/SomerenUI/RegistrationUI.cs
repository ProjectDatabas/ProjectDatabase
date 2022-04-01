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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please fill in email field before pressing 'register'");
                passwordTextBox.Clear();
                registerCodeTextBox.Clear();
                return;
            }
            else if(string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Please fill in password field before pressing 'register'");
                emailTextBox.Clear();
                registerCodeTextBox.Clear();
                return;
            }
            else if (string.IsNullOrWhiteSpace(registerCodeTextBox.Text))
            {
                MessageBox.Show("Please fill in registerCode field before pressing 'register'");
                emailTextBox.Clear();
                passwordTextBox.Clear();
                return;
            }



            // If correct, show the main form
            SomerenUI mainFrame = new SomerenUI();
            mainFrame.Show();
            this.Hide();
        }
    }
}
