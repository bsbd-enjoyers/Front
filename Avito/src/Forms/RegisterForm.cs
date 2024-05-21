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
    public partial class RegisterForm : Form
    {
        private User _user;

        public RegisterForm()
        {
            InitializeComponent();
            passwordBox.AutoSize = false;
            passwordBox.Size = new Size(loginBox.Size.Width, loginBox.Size.Height);
        }

        private async void registerCutomerOrSeller(string role)
        {
            BackendClient backendClient = BackendClient.getInstance();

            try
            {
                var check_result = await backendClient.checkLoginOccupied(this.loginBox.Text);

                if (check_result.result)
                {
                    MessageBox.Show("Логин занят, придумайте другой");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                return;
            }

            switch (role)
            {
                case "seller":
                    _user = AboutMeForm.getDetailedInfoSeller();
                    if (_user == null)
                    {
                        MessageBox.Show("Заполните информацию о себе");
                        return;
                    }
                    _user.role = "seller";
                    break;
                case "customer":
                    _user = AboutMeForm.getDetailedInfoCustomer();
                    if (_user == null)
                    {
                        MessageBox.Show("Заполните информацию о себе");
                        return;
                    }
                    _user.role = "customer";
                    break;
            }            

            _user.login = loginBox.Text;

            try
            {
                RequestResult register_result;

                switch (role)
                {
                    case "seller":
                        register_result = await backendClient.registerSeller((Seller)_user, passwordBox.Text);
                        break;
                    case "customer":
                        register_result = await backendClient.registerCustomer((Customer)_user, passwordBox.Text);
                        break;
                    default:
                        throw new Exception("Неизвестная роль");
                }

                if (!register_result.result)
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
                return;
            }
            return;
        }

        private void client_registration_Click(object sender, EventArgs e)
        {
            registerCutomerOrSeller("customer");
        }

        private void master_registration_Click(object sender, EventArgs e)
        {
            registerCutomerOrSeller("seller");
        }

        // Public
        public static User registerUser()
        {
            var registerWindow = new RegisterForm();

            if (registerWindow.ShowDialog() == DialogResult.OK)
            {
                return registerWindow._user;
            }

            return null;
        }
    }
}
