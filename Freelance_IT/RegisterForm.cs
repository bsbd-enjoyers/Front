﻿using System;
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
        public RegisterForm()
        {
            InitializeComponent();
            this.passwordBox.AutoSize = false;
            this.passwordBox.Size = new Size(this.loginBox.Size.Width, this.loginBox.Size.Height);
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void registration_Click(object sender, EventArgs e)
        {

        }
    }
}