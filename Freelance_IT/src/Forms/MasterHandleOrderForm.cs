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
    public partial class MasterHandleOrderForm : Form
    {

        // public
        public static Order masterRespondOrder(Order order)
        {
            MasterHandleOrderForm masterHandleOrderForm = new MasterHandleOrderForm();

            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

            masterHandleOrderForm._order = order;

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

            _order.totalcost = Convert.ToUInt32(masterCostLabel.Text);

            DialogResult = DialogResult.Yes;
            Close();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
