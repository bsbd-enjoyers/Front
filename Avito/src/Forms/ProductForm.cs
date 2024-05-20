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
using Avito.Network;

namespace Avito.Forms
{
    public partial class ProductForm : Form
    {
        public static int createProduct()
        {
            ProductForm productForm = new ProductForm();

            productForm.sellerLinkLabel.Hide();
            productForm.dateLabel.Hide();
            productForm.monthCalendar.Hide();

            if (productForm.ShowDialog() == DialogResult.OK)
            {
                Product product = new Product();
                product.name = productForm.fullNameBox.Text;
                product.price = Convert.ToUInt32(productForm.costTextBox.Text);
                product.desc = productForm.descriptionTextBox.Text;
                product.quantity = (uint)productForm.numberNumericUpDown.Value;

                try
                {
                    var create_result = BackendClient.getInstance().createProduct(product);
                    if (create_result.Result.result)
                    {
                        return 0;
                    }
                    MessageBox.Show("Не получилось создать заказ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                }
            }

            return -1;
        }

        public static int buyProduct(Product product)
        {
            ProductForm productForm = new ProductForm();

            productForm._product_id = (uint)product.product_id;

            productForm.fullNameBox.Text = product.name;
            productForm.costTextBox.Text = product.price.ToString();
            productForm.numberNumericUpDown.Value = (decimal)product.quantity;
            productForm.descriptionTextBox.Text = product.desc;

            if (productForm.ShowDialog() == DialogResult.OK)
            {
                Order order = new Order();
                order.delivery_date = productForm.monthCalendar.SelectionStart.ToShortDateString();
                order.quantity = (uint)productForm.numberNumericUpDown.Value;

                try
                {
                    var buy_result = BackendClient.getInstance().createOrder((uint)product.product_id, order);
                    if (buy_result.Result.result)
                    {
                        return 0;
                    }
                    MessageBox.Show("Не получилось создать заказ");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                }
            }

            return -1;
        }

        public static void checkProduct(Product product)
        {
            ProductForm productForm = new ProductForm();

            productForm.fullNameBox.Text = product.name;
            productForm.costTextBox.Text = product.price.ToString();
            productForm.numberNumericUpDown.Value = (decimal)product.quantity;
            productForm.descriptionTextBox.Text = product.desc;

            productForm.sellerLinkLabel.Hide();
            productForm.dateLabel.Hide();
            productForm.monthCalendar.Hide();

            productForm.ShowDialog();
        }

        // private
        private uint _product_id;

        private ProductForm()
        {
            InitializeComponent();
            monthCalendar.MinDate = DateTime.Now;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void sellerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var seller = BackendClient.getInstance().getSellerInfoByProduct(_product_id);

                AboutMeForm.getDetailedInfoSeller(seller.Result);
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
            }
        }
    }
}
