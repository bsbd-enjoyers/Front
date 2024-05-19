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
    public enum MainFormTabs
    {
        Sellers,
        Customers,
        Orders,
        Products,

        Unknown
    }

    public partial class MainForm : Form
    {
        // public
        public MainForm()
        {
            InitializeComponent();

            DataGridView.DataSource = _dataTable;
            _searchedCustomers = new List<Customer>();
            _searchedSellers = new List<Seller>();
            _searchedOrders = new List<Order>();
            _searchedProducts = new List<Product>();

            deinitializeUser();
        }

        // private 
        private User _user;

        private List<Order> _searchedOrders;
        private List<Customer> _searchedCustomers;
        private List<Seller> _searchedSellers;
        private List<Product> _searchedProducts;


        private DataTable _dataTable = new DataTable();
        private int _selectedRow = -1;

        private MainFormTabs _selectedTab;

        private void initializeAdmin()
        {
            avatarPictureBox.Image = Avito.Properties.Resources.admin;

            initializeOrderTable();
            //updateOrderTable();

            orderButton.Show();
            sellerButton.Show();
            customerButton.Show();
            productButton.Hide();

            DataGridView.Show();
        }

        private void initializeSeller()
        {
            avatarPictureBox.Image = Avito.Properties.Resources.seller;

            initializeOrderTable();
            //updateOrderTable();

            orderButton.Show();
            productButton.Show();
            sellerButton.Hide();
            customerButton.Hide();

            DataGridView.Show();
        }

        private void initializeCustomer()
        {
            avatarPictureBox.Image = Avito.Properties.Resources.customer;

            initializeOrderTable();
            //updateOrderTable();

            orderButton.Show();
            sellerButton.Hide();
            customerButton.Hide();

            DataGridView.Show();
        }

        private void deinitializeUser()
        {
            DataGridView.Hide();
            createButton.Hide();
            deleteButton.Hide();
            checkButton.Hide();
            buyButton.Hide();
            searchTextBox.Text = "";
            loginLabel.Text = "Нажми сюда";
            walletLabel.Text = "Баланс";

            _searchedCustomers.Clear();
            _searchedProducts.Clear();
            _searchedSellers.Clear();
            _searchedOrders.Clear();
            _user = null;

        }

        private void initializeCustomerTable()
        {
            _selectedTab = MainFormTabs.Customers;

            deleteButton.Show();
            checkButton.Show();
            buyButton.Hide();
            createButton.Hide();


            searchButton.Show();
            searchTextBox.Show();

            _dataTable.Rows.Clear();
            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("ФИО", typeof(string));
            _dataTable.Columns.Add("Номер телефона", typeof(string));
            _dataTable.Columns.Add("Адрес эл почты", typeof(string));

            _selectedRow = -1;
        }

        private void updateCustomerTable()
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Customer customer in _searchedCustomers)
            {
                _dataTable.Rows.Add(customer.name, customer.phone, customer.email);
            }
        }

        private void initializeSellerTable()
        {
            _selectedTab = MainFormTabs.Sellers;

            deleteButton.Show();
            checkButton.Show();
            buyButton.Hide();
            createButton.Hide();


            searchButton.Show();
            searchTextBox.Show();

            _dataTable.Rows.Clear();

            _dataTable.Rows.Clear();
            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("ФИО", typeof(string));
            _dataTable.Columns.Add("Номер телефона", typeof(string));
            _dataTable.Columns.Add("Адрес эл почты", typeof(string));

            _selectedRow = -1;
        }

        private void updateSellerTable()
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Seller seller in _searchedSellers)
            {
                _dataTable.Rows.Add(seller.name, seller.phone, seller.email);
            }
        }

        private void initializeOrderTable()
        {
            _selectedTab = MainFormTabs.Orders;
      
            checkButton.Show();
            buyButton.Hide();
            createButton.Hide();

            switch (_user.role)
            {
                case "customer":
                case "seller":
                    deleteButton.Hide();

                    searchButton.Hide();
                    searchTextBox.Hide();
                    break;
                case "admin":
                    deleteButton.Show();

                    searchButton.Show();
                    searchTextBox.Show();
                    break;
            }
            
            _dataTable.Rows.Clear();


            _dataTable.Rows.Clear();
            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("Наименование", typeof(string));
            _dataTable.Columns.Add("Количество", typeof(string));
            _dataTable.Columns.Add("Стоимость", typeof(string));

            _selectedRow = -1;

/*            if (_user.GetType().ToString() == "Freelance_IT.Classes.Admin")
            {
                return;
            }

            try
            {
                _searchedOrders.Clear();
                var orders_task = BackendClient.getInstance().getOrders();
                _searchedOrders.AddRange(orders_task);
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
            }*/
        }

        private void updateOrderTable()
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Order order in _searchedOrders)
            {
                _dataTable.Rows.Add(order.name, order.quantity, order.price);
            }
        }

        private void initializeProductTable()
        {
            _selectedTab = MainFormTabs.Products;

            switch (_user.role)
            {
                case "customer":
                    buyButton.Show();
                    checkButton.Hide();
                    deleteButton.Hide();
                    createButton.Hide();

                    searchButton.Show();
                    searchTextBox.Show();
                    break;
                case "seller":
                    buyButton.Hide();
                    checkButton.Show();
                    deleteButton.Show();
                    createButton.Show();

                    searchButton.Hide();
                    searchTextBox.Hide();
                    break;
                case "admin":
                    buyButton.Hide();
                    checkButton.Hide();
                    deleteButton.Hide();
                    createButton.Hide();

                    searchButton.Hide();
                    searchTextBox.Hide();
                    break;
            }


            _dataTable.Rows.Clear();
            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("Наименование", typeof(string));
            _dataTable.Columns.Add("Количество доступных", typeof(string));
            _dataTable.Columns.Add("Цена за шт.", typeof(string));

            _selectedRow = -1;
        }

        private void updateProductTable()
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Product product in _searchedProducts)
            {
                _dataTable.Rows.Add(product.name, product.quantity, product.price);
            }
        }


        private int authenticateUser()
        {
            // _user = LoginForm.authenticate();

            _user = new User();
            _user.login = "seller";
            _user.role = "seller";
            _user.wallet = 300;


            if (_user == null)
            {
                MessageBox.Show("Пройдите авторизацию прежде чем работать с сервисом");
                return -1;
            }

            this.loginLabel.Text = _user.login;

            if (_user.role != "admin")
            {
                this.walletLabel.Text = _user.wallet.ToString();
            }
            else
            {
                this.walletLabel.Text = "";
            }

            return 0;
        }

        private void logUser()
        {
            if (_user == null)
            {
                int result = authenticateUser();
                if (result != 0)
                {
                    return;
                }

                switch (_user.role)
                {
                    case "admin":
                        initializeAdmin();
                        break;
                    case "seller":
                        initializeSeller();
                        break;
                    case "customer":
                        initializeCustomer();
                        break;
                }
            }
        }

        private async void logutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginLabel.Text = "Нажми сюда";
            avatarPictureBox.Image = null;
            deinitializeUser();

            try
            {
                await BackendClient.getInstance().logout();
            }
            catch (Exception)
            {
                // Без понятия, должно ли тут быть что-то
            }

            logUser();
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            logUser();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            initializeOrderTable();
            //updateOrderTable();
        }

        private void sellerButton_Click(object sender, EventArgs e)
        {
            initializeSellerTable();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            initializeCustomerTable();
        }
        private void productButton_Click(object sender, EventArgs e)
        {
            initializeProductTable();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Ничего не было выбрано");
                return;
            }

            ProductForm.createProduct();

            _selectedRow = -1;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Ничего не было выбрано");
                return;
            }


            ProductForm.buyProduct(_searchedProducts[_selectedRow]);

            _selectedRow = -1;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Ничего не было выбрано");
                return;
            }

            switch (_selectedTab)
            {
                case MainFormTabs.Customers:
                    AboutMeForm.getDetailedInfoCustomer(_searchedCustomers[_selectedRow]);
                    break;
                case MainFormTabs.Sellers:
                    AboutMeForm.getDetailedInfoSeller(_searchedSellers[_selectedRow]);
                    break;
                case MainFormTabs.Orders:
                    //OrderForm.checkOrder(_searchedOrders[_selectedRow]);
                    break;
                case MainFormTabs.Products:
                    ProductForm.checkProduct(_searchedProducts[_selectedRow]);
                    break;
            }
            _selectedRow = -1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Ничего не было выбрано");
                return;
            }

            /*switch (_selectedTab)
            {
                case MainFormTabs.Customers:
                    try
                    {
                        var ban_result = await BackendClient.getInstance().banUser(_searchedCustomers[_selectedRow].login, "client");
                        if (!ban_result.result)
                        {
                            MessageBox.Show("Не получилось заблокировать клиента!\nСделайте это через поддержку");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                    }
                    break;
                case MainFormTabs.Sellers:
                    try
                    {
                        var ban_result = await BackendClient.getInstance().banUser(_searchedSellers[_selectedRow].login, "master");
                        if (!ban_result.result)
                        {
                            MessageBox.Show("Не получилось заблокировать исполнителя!\nСделайте это через поддержку");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                    }
                    break;
                case MainFormTabs.Orders:
                    try
                    {
                        var delete_result = await BackendClient.getInstance().banOrder(_searchedOrders[_selectedRow].order_id);
                        if (!delete_result.result)
                        {
                            MessageBox.Show("Не получилось удалить заказ!\nУдалять можно заказы только со статусами \"created\" и \"updated\"");
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                    }
                    break;
                case MainFormTabs.Products:
                    try
                    {
                        var delete_result = await BackendClient.getInstance().deleteProduct(_searchedProducts[_selectedRow].product_id);
                        if (!delete_result.result)
                        {
                            MessageBox.Show("Не получилось удалить заказ!\nУдалять можно заказы только со статусами \"created\" и \"updated\"");
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                    }
                    break;
            }*/
            _selectedRow = -1;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;

            if (_selectedRow == -1)
            {
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {            
            try
            {
                BackendClient backendClient = BackendClient.getInstance();

                switch (_selectedTab)
                {
                    case MainFormTabs.Customers:
                        _searchedCustomers.Clear();
                        _searchedCustomers.AddRange(backendClient.searchCustomers(searchTextBox.Text));
                        
                        updateCustomerTable();

                        break;
                    case MainFormTabs.Sellers:
                        _searchedSellers.Clear();
                        _searchedSellers.AddRange(backendClient.searchSellers(searchTextBox.Text));

                        updateSellerTable();

                        break;
                    case MainFormTabs.Orders:
                        _searchedOrders.Clear();
                        _searchedOrders.AddRange(backendClient.searchOrders(searchTextBox.Text));

                        updateOrderTable();
                        break;
                    case MainFormTabs.Products:
                        _searchedProducts.Clear();
                        _searchedProducts.AddRange(backendClient.searchProducts(searchTextBox.Text));

                        updateProductTable();

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
            }

            searchTextBox.Text = "";
            return;
        }
    }
}
