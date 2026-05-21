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
            "http://localhost:5000/auth".PostJsonToUrl(authRequest);
        }
    }
}
