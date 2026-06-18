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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AuthRequest authRequest = new AuthRequest
            {
                Name = this.loginTextBox.Text,
                Password = this.passwordMaskedTextBox.Text,
            };

            string sessionId = "http://localhost:5000/auth".PostJsonToUrl(authRequest);
            if (sessionId == "")
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль");
                return;
            }

            this.Visible = false;
            new MainForm(sessionId).ShowDialog();
            this.Close();
        }

        private void passwordMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.loginButton_Click(sender, e);
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            new RegisterForm().ShowDialog();
            this.Visible = true;
        }
    }
}
