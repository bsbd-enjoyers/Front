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
    public partial class AboutMeForm : Form
    {
        // private
        private Customer _customer = null;
        private Seller _seller = null;

        private AboutMeForm()
        {
            InitializeComponent();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_seller == null)
            {
                _customer.name = fullnameTextBox.Text;
                _customer.phone = phoneBox.Text;
                _customer.email = emailBox.Text;
                _customer.desc = aboutMeBox.Text;
            }
            else
            {
                _seller.name = fullnameTextBox.Text;
                _seller.phone = phoneBox.Text;
                _seller.email = emailBox.Text;
                _seller.desc = aboutMeBox.Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        // public
        public static Customer getDetailedInfoCustomer(Customer customer = null)
        {
            AboutMeForm aboutMeWindow = new AboutMeForm();

            if (customer != null)
            {
                aboutMeWindow._customer = customer;
                aboutMeWindow.fullnameTextBox.Text = customer.name;
                aboutMeWindow.phoneBox.Text = customer.phone;
                aboutMeWindow.emailBox.Text = customer.email;
                aboutMeWindow.aboutMeBox.Text = customer.desc;
            }
            else
            {
                aboutMeWindow._customer = new Customer();
            }

            if (aboutMeWindow.ShowDialog() == DialogResult.OK)
            {
                return aboutMeWindow._customer;
            }

            return null;
        }

        public static Seller getDetailedInfoSeller(Seller seller = null)
        {
            AboutMeForm aboutMeWindow = new AboutMeForm();

            if (seller != null)
            {
                aboutMeWindow._seller = seller;
                aboutMeWindow.fullnameTextBox.Text = seller.name;
                aboutMeWindow.phoneBox.Text = seller.phone;
                aboutMeWindow.emailBox.Text = seller.email;
                aboutMeWindow.aboutMeBox.Text = seller.desc;
            }
            else
            {
                aboutMeWindow._customer = new Customer();
            }

            if (aboutMeWindow.ShowDialog() == DialogResult.OK)
            {
                return aboutMeWindow._seller;
            }

            return null;
        }
    }
}
