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
    public partial class HandleOrderForm : Form
    {
        // Функция для принятия/отказа заказа клиентом на последнем (третьем) этапе согласования 
        public static DialogResult lastStepAcceptingOrder(Order order)
        {
            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

            HandleOrderForm handleOrderWindow = new HandleOrderForm();
            handleOrderWindow._order = order;

            handleOrderWindow.fillOrderFileds();

            return handleOrderWindow.ShowDialog();
        }

        // Функция демонстрации всей информации о заказе
        public static void showOrderInfo(Order order)
        {
            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

            HandleOrderForm handleOrderWindow = new HandleOrderForm();
            handleOrderWindow._order = order;

            handleOrderWindow.prepareOnlyShowing();

            handleOrderWindow.ShowDialog();
            return;
        }

        // private
        private Order _order;

        private HandleOrderForm()
        {
            InitializeComponent();
        }

        private void prepareOnlyShowing()
        {
            declineButton.Hide();
            orderButton.Hide();
            // В зависимости от статуса тут что-то можно понаписать в виджеты

            fillOrderFileds();
        }

        private void fillOrderFileds()
        {
            statusLabel.Text = _order.status;

            masterIDLinkLabel.Text = _order.id_master.ToString();
            clientIDLinkLabel.Text = _order.id_client.ToString();
            dateTextBox.Text = _order.deadline;
            masterCostTextBox.Text = _order.totalcost.ToString();

            fullnameTextBox.Text = _order.product.fullname;
            clientDescriptionTextBox.Text = _order.product.client_description;
            productTypeBox.Text = _order.product.type;
            masterDescriptionTextBox.Text = _order.product.master_specification;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
