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
    public partial class MainForm : Form
    {
        private User _user;

        public MainForm()
        {
            InitializeComponent();
        }

        private void authenticateUser()
        {
            _user = LoginForm.authenticate();

            if (_user == null)
            {
                MessageBox.Show("Пройдите авторизацию прежде чем работать с сервисом");
                return;
            }

            this.loginLabel.Text = _user.login;
            updateAvatar();
        }

        private void updateAvatar()
        {
            Type user_type = this._user.GetType();
            if (user_type == typeof(Admin))
            {
                avatarPictureBox.Image = Freelance_IT.Properties.Resources.admin;
                return;
            }
            if (user_type == typeof(Client))
            {
                avatarPictureBox.Image = Freelance_IT.Properties.Resources.client;
                return;
            }
            if (user_type == typeof(Master))
            {
                avatarPictureBox.Image = Freelance_IT.Properties.Resources.master;
                return;
            }
        }

        private void logutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _user = null;
            loginLabel.Text = "Логин";
            avatarPictureBox.Image = null;
            authenticateUser();
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                authenticateUser();
            }
            else
            {
                //SHow and update user info
            }
        }
    }

    public class User
    {
        public string login;
        public string fullname;
        public string email;
        public string phone;
    }

    public class Master: User
    {
        public string about_me;
        public SortedDictionary<string, string> skills;
    }

    public class Client: User
    {

    }

    public class Admin : User
    {

    }

}
