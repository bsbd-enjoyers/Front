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
    public partial class MasterHandleOrderForm : Form
    {

        /*// public
        public static Order masterRespondOrder(Order order)
        {
            MasterHandleOrderForm masterHandleOrderForm = new MasterHandleOrderForm();

            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

            masterHandleOrderForm._order = order;
            masterHandleOrderForm.dateTextBox.Text = order.deadline;
            masterHandleOrderForm.fullnameTextBox.Text = order.product.fullname;
            masterHandleOrderForm.clientCostTextBox.Text = order.client_cost.ToString();
            masterHandleOrderForm.clientTextBox.Text = order.product.client_description;


            if (masterHandleOrderForm.ShowDialog() == DialogResult.Yes)
            {
                return masterHandleOrderForm._order;
            }

            return null;
        }

        // private 
        private MasterHandleOrderForm()
        {
            InitializeComponent();
        }

        private Order _order;

        private void respondButton_Click(object sender, EventArgs e)
        {
            _order.product.type = productTypeBox.Text;
            _order.product.master_specification = masterDecriptionTextBox.Text;

            try
            {
                _order.master_cost = Convert.ToUInt32(masterCostTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно указано поле разработки заказа");
                masterCostTextBox.Text = "";
                return;
            }

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }*/
    }
}
