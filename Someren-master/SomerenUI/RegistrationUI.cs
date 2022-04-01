using System;
using SomerenLogic;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace SomerenUI
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        const string RegisterCodeConst = "XsZAb - tgz3PsD - qYh69un - WQCEx";

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
                MessageBox.Show("Please fill in license key field before pressing 'register'");
                emailTextBox.Clear();
                passwordTextBox.Clear();
                return;
            }

            string registerCode = registerCodeTextBox.Text;
            if (registerCode != RegisterCodeConst)
            {
                MessageBox.Show("Wrong license key");
                emailTextBox.Clear();
                passwordTextBox.Clear();
                registerCodeTextBox.Clear();
                return;
            }

            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            LoginLogic loginLogic = new LoginLogic();
            try
            {
                loginLogic.AddNewUser(email, password);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                emailTextBox.Clear();
                passwordTextBox.Clear();
                registerCodeTextBox.Clear();
                return;
            }
            
            // If correct, show the main form
            SomerenUI mainFrame = new SomerenUI();
            mainFrame.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginUI loginUI = new LoginUI();
            loginUI.Show();
            this.Hide();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
