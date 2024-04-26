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
    public partial class RegisterForm : Form
    {
        private User _user;

        public RegisterForm()
        {
            InitializeComponent();
            passwordBox.AutoSize = false;
            passwordBox.Size = new Size(loginBox.Size.Width, loginBox.Size.Height);
        }

        private void client_registration_Click(object sender, EventArgs e)
        {
            _user = AboutMeClientForm.getDetailedInfo((Client)_user);

            if (_user == null)
            {
                MessageBox.Show("Заполните информацию о себе");
                return;
            }

            _user.login = loginBox.Text;

            try
            {
                BackendClient backendClient = BackendClient.getInstance();

                var result = backendClient.registerClient((Client)_user, passwordBox.Text);

                if (!result.Result.result)
                {
                    MessageBox.Show("Регистрация не прошла, попробуйте еще раз");
                    return;
                }

                MessageBox.Show("Вы зарегестрированы, поздравляем");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
            }
            return;
        }

        private void master_registration_Click(object sender, EventArgs e)
        {
            _user = AboutMeMasterForm.getDetailedInfo((Master)_user);

            if (_user == null)
            {
                MessageBox.Show("Заполните информацию о себе");
                return;
            }

            _user.login = loginBox.Text;

            try
            {
                BackendClient backendClient = BackendClient.getInstance();

                var result = backendClient.registerMaster((Master)_user, passwordBox.Text);

                if (!result.Result.result)
                {
                    MessageBox.Show("Регистрация не прошла, попробуйте еще раз");
                    return;
                }

                MessageBox.Show("Вы зарегестрированы, поздравляем");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
            }
            return;
        }

        // Public
        public static User registerOrUpdate(User user)
        {
            var registerWindow = new RegisterForm();

            if (user != null)
            {
                registerWindow._user = user;
                registerWindow.loginBox.Text = user.login;
            }
            
            if (registerWindow.ShowDialog() == DialogResult.OK)
            {
                return registerWindow._user;
            }

            return null;
        }
    }
}
