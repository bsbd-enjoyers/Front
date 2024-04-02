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
    public partial class RegisterForm : Form
    {
        private User _user;

        public RegisterForm()
        {
            InitializeComponent();
            passwordBox.AutoSize = false;
            passwordBox.Size = new Size(loginBox.Size.Width, loginBox.Size.Height);
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void client_registration_Click(object sender, EventArgs e)
        {
            _user = AboutMeClientForm.getDetailedInfo((Client)_user);

            if (_user == null)
            {
                MessageBox.Show("Заполните информацию о себе");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void master_registration_Click(object sender, EventArgs e)
        {
            _user = AboutMeMasterForm.getDetailedInfo((Master)_user);

            if (_user == null)
            {
                MessageBox.Show("Заполните информацию о себе");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
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
