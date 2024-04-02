using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_IT
{
    public partial class LoginForm : Form
    {
        // Private

        private User _user;

        private LoginForm()
        {
            InitializeComponent();
            this.passwordBox.AutoSize = false;
            this.passwordBox.Size = new Size(this.loginBox.Size.Width, this.loginBox.Size.Height);
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            // Check authentication thorugh back
            // back_res == null
            if (false)
            {
                MessageBox.Show("Невалидная попытка входа");
                return;
            }
            else
            {
                string temp_role = "admin";
                switch (temp_role)
                {
                    case "admin":
                        _user = new Admin();
                        break;
                    case "master":
                        _user = new Master();
                        break;
                    case "client":
                        _user = new Client();
                        break;
                }
                
                _user.login = this.loginBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        // Public
        public static User authenticate()
        {
            var loginWindow = new LoginForm();

            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                return loginWindow._user;
            }

            return null;
        }
    }
}
