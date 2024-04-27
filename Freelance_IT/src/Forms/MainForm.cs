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
using Freelance_IT.Network;

namespace Freelance_IT.Forms
{
    public enum MainFormTabs
    {
        Clients,
        Masters,
        Orders,

        Unknown
    }

    public partial class MainForm : Form
    {
        // public
        public MainForm()
        {
            InitializeComponent();

            DataGridView.DataSource = _dataTable;
            deinitializeUser();
        }

        // private 
        private User _user;

        private DataTable _dataTable = new DataTable();
        private int _selectedRow = -1;

        private MainFormTabs _selectedTab;

        private void initializeAdmin()
        {
            avatarPictureBox.Image = Freelance_IT.Properties.Resources.admin;

            initializeOrderTable();

            orderButton.Show();
            masterButton.Show();
            clientButton.Show();

            DataGridView.Show();

            deleteButton.Show();
            checkButton.Show();
        }

        private void initializeMaster()
        {
            avatarPictureBox.Image = Freelance_IT.Properties.Resources.master;

            initializeOrderTable();
            orderButton.Show();
            masterButton.Hide();
            clientButton.Hide();

            DataGridView.Show();

            checkButton.Show();
        }

        private void initializeClient()
        {
            avatarPictureBox.Image = Freelance_IT.Properties.Resources.client;

            initializeOrderTable();
            orderButton.Show();
            masterButton.Hide();
            clientButton.Hide();

            DataGridView.Show();

            createButton.Show();
            deleteButton.Show();
            checkButton.Show();
        }

        private void deinitializeUser()
        {
            DataGridView.Hide();
            createButton.Hide();
            deleteButton.Hide();
            checkButton.Hide();
        }

        private void initializeClientTable()
        {
            _selectedTab = MainFormTabs.Clients;

            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("ID клиента", typeof(string));
            _dataTable.Columns.Add("ФИО", typeof(string));
            _dataTable.Columns.Add("Адрес эл почты", typeof(string));
            _dataTable.Columns.Add("Номер телефона", typeof(string));

            _selectedRow = -1;
        }

        private void updateClientTable(List<Client> searchedClients)
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Client client in searchedClients)
            {
                _dataTable.Rows.Add(client.id, client.fullname, client.email, client.phone);
            }
        }

        private void initializeMasterTable()
        {
            _selectedTab = MainFormTabs.Masters;

            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("ID исполнителя", typeof(string));
            _dataTable.Columns.Add("ФИО", typeof(string));
            _dataTable.Columns.Add("Адрес эл почты", typeof(string));
            _dataTable.Columns.Add("Номер телефона", typeof(string));

            _selectedRow = -1;
        }

        private void updateMasterTable(List<Master> searchedMasters)
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Master master in searchedMasters)
            {
                _dataTable.Rows.Add(master.id, master.fullname, master.email, master.phone);
            }
        }

        private void initializeOrderTable()
        {
            _selectedTab = MainFormTabs.Orders;

            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("ID заказа", typeof(string));
            _dataTable.Columns.Add("Тип продукта", typeof(string));
            _dataTable.Columns.Add("Полное название продукта", typeof(string));
            _dataTable.Columns.Add("Статус заказа", typeof(string));

            _selectedRow = -1;
        }

        private void updateOrderTable(List<Order> searchedOrders)
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Order order in searchedOrders)
            {
                _dataTable.Rows.Add(order.id_order, order.product.type, order.product.fullname, order.status);
            }
        }

        private int authenticateUser()
        {
            _user = LoginForm.authenticate();

            if (_user == null)
            {
                MessageBox.Show("Пройдите авторизацию прежде чем работать с сервисом");
                return -1;
            }

            this.loginLabel.Text = _user.login;

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

                switch (_user.GetType().ToString())
                {
                    case "Freelance_IT.Classes.Admin":
                        initializeAdmin();
                        break;
                    case "Freelance_IT.Classes.Master":
                        initializeMaster();
                        break;
                    case "Freelance_IT.Classes.Client":
                        initializeClient();
                        break;
                }
            }
            else
            {
                //SHow and update user info
            }
        }

        private void logutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _user = null;
            loginLabel.Text = "Логин";
            avatarPictureBox.Image = null;
            deinitializeUser();

            logUser();
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            logUser();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            initializeOrderTable();
        }

        private void masterButton_Click(object sender, EventArgs e)
        {
            initializeMasterTable();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            initializeClientTable();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Order order = ClientCreateOrderForm.createOrder();

            if (order == null)
            {
                MessageBox.Show("Заказ не был создан");
                return;
            }

            // Отправить запрос на создание заказа
            return;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Ничего не было выбрано");
                return;
            }

            // Открыть окно просмотра заказа, тут зависит от роли, кнопка перегружена
            _selectedRow = -1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Ничего не было выбрано");
                return;
            }

            // Удалить заказ, тут зависит от статуса заказа, его не всегда можно удалить
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

        // Дописать десериализацию классов Master, Client, Orders и протестировать
        private async void searchButton_Click(object sender, EventArgs e)
        {            
            try
            {
                BackendClient backendClient = BackendClient.getInstance();

                switch (_selectedTab)
                {
                    case MainFormTabs.Clients:
                        var search_clients_result = await backendClient.searchClients(searchTextBox.Text);
                        
                        updateClientTable(search_clients_result);

                        break;
                    case MainFormTabs.Masters:
                        var search_masters_result = await backendClient.searchMasters(searchTextBox.Text);

                        updateMasterTable(null);

                        break;
                    case MainFormTabs.Orders:
                        var search_orders_result = await backendClient.searchOrders(searchTextBox.Text);

                        updateOrderTable(search_orders_result);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                return;
            }
            return;
        }
    }
}
