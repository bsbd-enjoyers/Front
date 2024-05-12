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

namespace Avito.Forms
{
    public partial class AboutMeClientForm : Form
    {
        // private
        private Client _client;

        private AboutMeClientForm()
        {
            InitializeComponent();
        }

        // public
        public static Client getDetailedInfo(Client client)
        {
            AboutMeClientForm aboutClientWindow = new AboutMeClientForm();

            if (client != null)
            {
                aboutClientWindow._client = client;
                aboutClientWindow.fullnameTextBox.Text = client.fullname;
                aboutClientWindow.phoneBox.Text = client.phone;
                aboutClientWindow.emailBox.Text = client.email;
            }
            else
            {
                aboutClientWindow._client = new Client();
            }

            if (aboutClientWindow.ShowDialog() == DialogResult.OK)
            {
                return aboutClientWindow._client;
            }

            return null;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            _client.fullname = fullnameTextBox.Text;
            _client.phone = phoneBox.Text;
            _client.email = emailBox.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
