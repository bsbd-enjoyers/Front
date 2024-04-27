using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Freelance_IT.Classes;
using Freelance_IT.Network;

namespace Freelance_IT.Forms
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

                if (!login_result.result)
                {
                    MessageBox.Show("Не получилось авторизоваться");
                    return;
                }

                var user_info = await backendClient.getMyInfo();

                switch (user_info.role)
                //switch("client")
                {
                    case "admin":
                        _user = new Admin(user_info);
                        break;
                    case "master":
                        _user = new Master(user_info);
                        break;
                    case "client":
                        _user = new Client(user_info);
                        break;
                }
                _user.login = loginBox.Text;

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
