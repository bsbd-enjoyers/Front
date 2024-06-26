﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Avito.Classes;
using Avito.Network;

namespace Avito.Forms
{
    public partial class OrderForm : Form
    {
        public static void checkAdminOrder(Order order)
        {
            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

            OrderForm orderForm = new OrderForm();
            orderForm.actionButton.Hide();
            orderForm.cancelButton.Hide();
            orderForm.customerLinkLabel.Hide();
            orderForm.sellerLinkLabel.Hide();

            orderForm.initOrder(order);

            orderForm._order_id = (uint)order.order_id;

            orderForm.ShowDialog();
        }

        // Функция демонстрации всей информации о заказе
        public static async void checkCustomerOrder(Order order)
        {
            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

            OrderForm orderForm = new OrderForm();
            orderForm.customerLinkLabel.Hide();

            if(order.status == "delivery")
            {
                orderForm.actionButton.Text = "Подтвердить получение";
            }
            else
            {
                orderForm.actionButton.Hide();
                orderForm.cancelButton.Hide();
            }

            orderForm._order_id = (uint)order.order_id;

            orderForm.initOrder(order);

            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var create_result = await BackendClient.getInstance().updateOrderStatus((uint)order.order_id, "received");
                    if (create_result.result)
                    {
                        return;
                    }
                    MessageBox.Show("Не получилось обновить статус заказа");

                }
                catch (Exception)
                {
                    MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                }
            }
            
            return;
        }

        public static async void checkSellerOrder(Order order)
        {
            if (order == null)
            {
                throw new Exception("Заказ пуст, показывать нечего");
            }

            OrderForm orderForm = new OrderForm();
            orderForm.sellerLinkLabel.Hide();

            if (order.status == "created")
            {
                orderForm.actionButton.Text = "Подтвердить отправку";
            }
            else
            {
                orderForm.actionButton.Hide();
                orderForm.cancelButton.Hide();
            }            

            orderForm._order_id = (uint)order.order_id;

            orderForm.initOrder(order);

            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var create_result = await BackendClient.getInstance().updateOrderStatus((uint)order.order_id, "delivery");
                    if (create_result.result)
                    {
                        return;
                    }
                    MessageBox.Show("Не получилось обновить статус заказа");

                }
                catch (Exception)
                {
                    MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                }
            }
            
            return;
        }

        // private
        private uint _order_id;

        private OrderForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
        }

        private void initOrder(Order order)
        {
            statusLabel.Text = order.status;

            dateTextBox.Text = order.delivery_date;
            fullnameTextBox.Text = order.name;
            numberTextBox.Text = order.quantity.ToString();
            costTextBox.Text = order.price.ToString();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void customerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var customer = await BackendClient.getInstance().getCustomerInfoByOrder(_order_id);
                AboutMeForm.getDetailedInfoCustomer(customer);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось получить информацию о покупателе(");
            }
        }

        private async void sellerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var seller = await BackendClient.getInstance().getSellerInfoByOrder(_order_id);
                AboutMeForm.getDetailedInfoSeller(seller);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось получить информацию о продавце(");
            }
        }
    }
}
