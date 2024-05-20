using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Avito.Classes;
using Avito.Network;

namespace Avito.Forms
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

        private async void enter_Click(object sender, EventArgs e)
        {
            try
            {
                BackendClient backendClient = BackendClient.getInstance();

                var login_result = await backendClient.login(this.loginBox.Text, this.passwordBox.Text);

                if (login_result == null)
                {
                    MessageBox.Show("Не получилось авторизоваться");
                    return;
                }

                _user = new User();
                _user.login = loginBox.Text;
                _user.role = login_result.role;
                _user.wallet = login_result.wallet;

                DialogResult = DialogResult.OK;
                Close();

            }
            catch (Exception){
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
            }
            return;
        }

        // Public
        public static User authenticate()
        {
            LoginForm loginWindow = new LoginForm();

            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                return loginWindow._user;
            }

            return null;
        }
    }
}
