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

namespace Freelance_IT.Forms
{
    public partial class ClientCreateOrderForm : Form
    {

        public ClientCreateOrderForm()
        {
            InitializeComponent();
            monthCalendar.MinDate = DateTime.Now;
        }

        public static Order createOrder()
        {
            ClientCreateOrderForm createOrderWindow = new ClientCreateOrderForm();

            if (createOrderWindow.ShowDialog() == DialogResult.OK)
            {
                return createOrderWindow._order;
            }

            return null;
        }

        // private
        private Order _order;

        private void enter_Click(object sender, EventArgs e)
        {
            _order = new Order();

            _order.product = new Product();
            _order.product.client_description = descriptionTextBox.Text;
            _order.product.fullname = fullNameBox.Text;
            _order.product.client_description = descriptionTextBox.Text;


            _order.deadline = monthCalendar.SelectionStart.ToShortDateString();

            try
            {
                _order.totalcost = Convert.ToUInt32(costTextBox.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Неправильно указано поле стоимости заказа");
                costTextBox.Text = "";
                return;
            }

            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
