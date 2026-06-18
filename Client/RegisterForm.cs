using ServiceStack;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void passwordMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void passwordMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.passwordMaskedTextBox.Text == "" && this.repeatPasswordMaskedTextBox.Text == "")
            {
                this.registerButton.Enabled = false;
            }
            else if (this.passwordMaskedTextBox.Text == this.repeatPasswordMaskedTextBox.Text)
            {
                this.registerButton.Enabled = true;
            }
            else
            {
                this.registerButton.Enabled = false;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterRequest registerRequest = new RegisterRequest
            {
                Name = this.loginTextBox.Text,
                Password = this.passwordMaskedTextBox.Text,
            };

            string sessionId = "http://localhost:5000/register".PostJsonToUrl(registerRequest);
            if (sessionId == "")
            {
                MessageBox.Show("Невозможно создать такого пользователя");
                return;
            }

            this.Visible = false;
            new MainForm(sessionId).ShowDialog();
            this.Close();
        }
    }
}
