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
        private MasterHandleOrderForm()
        {
            InitializeComponent();
        }

        // public
        /*public static Order masterRespondOrder(Order order)
        {
            MasterHandleOrderForm masterHandleOrderForm = new MasterHandleOrderForm();

            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

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

            if (masterHandleOrderForm.ShowDialog() == DialogResult.OK)
            {
                return masterHandleOrderForm._order;
            }

            return null;
        }*/

    }
}
