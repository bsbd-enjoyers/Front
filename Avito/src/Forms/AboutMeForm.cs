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
                _customer.customer_name = fullnameTextBox.Text;
                _customer.customer_phone = phoneBox.Text;
                _customer.customer_email = emailBox.Text;
                _customer.customer_desc = aboutMeBox.Text;
            }
            else
            {
                _seller.seller_name = fullnameTextBox.Text;
                _seller.seller_phone = phoneBox.Text;
                _seller.seller_email = emailBox.Text;
                _seller.seller_desc = aboutMeBox.Text;
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
                aboutMeWindow.fullnameTextBox.Text = customer.customer_name;
                aboutMeWindow.phoneBox.Text = customer.customer_phone;
                aboutMeWindow.emailBox.Text = customer.customer_email;
                aboutMeWindow.aboutMeBox.Text = customer.customer_desc;
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
                aboutMeWindow.fullnameTextBox.Text = seller.seller_name;
                aboutMeWindow.phoneBox.Text = seller.seller_phone;
                aboutMeWindow.emailBox.Text = seller.seller_email;
                aboutMeWindow.aboutMeBox.Text = seller.seller_desc;
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
