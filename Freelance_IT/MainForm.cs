using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_IT
{
    public partial class MainForm : Form
    {
        // public
        public MainForm()
        {
            InitializeComponent();

            DataGridView.DataSource = DataTable;
            deinitializeUser();
        }

        // private 
        private User _user;

        private DataTable DataTable = new DataTable();
        private int _selectedRow = -1;

        private MainFormTabs _selectedTab;
        private List<Order> _searchedOrders;
        private List<Client> _searchedClients;
        private List<Master> _searchedMasters;

        private void initializeAdmin()
        {
            avatarPictureBox.Image = Freelance_IT.Properties.Resources.admin;

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
            DataTable.Columns.Clear();
            DataTable.Columns.Add("ID мастера", typeof(string));
            DataTable.Columns.Add("ФИО", typeof(string));
            DataTable.Columns.Add("Адрес эл почты", typeof(string));
            DataTable.Columns.Add("Номер телефона", typeof(string));

            _selectedRow = -1;
        }

        private void updateClientTable()
        {

        }

        private void initializeMasterTable()
        {
            DataTable.Columns.Clear();
            DataTable.Columns.Add("ID исполнителя", typeof(string));
            DataTable.Columns.Add("ФИО", typeof(string));
            DataTable.Columns.Add("Адрес эл почты", typeof(string));
            DataTable.Columns.Add("Номер телефона", typeof(string));

            _selectedRow = -1;
        }

        private void updateMasterTable()
        {

        }

        private void initializeOrderTable()
        {
            DataTable.Columns.Clear();
            DataTable.Columns.Add("ID заказа", typeof(string));
            DataTable.Columns.Add("Тип продукта", typeof(string));
            DataTable.Columns.Add("Полное название продукта", typeof(string));
            DataTable.Columns.Add("Статус заказа", typeof(string));

            _selectedRow = -1;
        }

        private void updateOrderTable()
        {

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
                    case "Freelance_IT.Admin":
                        initializeAdmin();
                        break;
                    case "Freelance_IT.Master":
                        initializeMaster();
                        break;
                    case "Freelance_IT.Client":
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
            _selectedTab = MainFormTabs.Orders;
            initializeOrderTable();
        }

        private void masterButton_Click(object sender, EventArgs e)
        {
            _selectedTab = MainFormTabs.Masters;
            initializeMasterTable();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            _selectedTab = MainFormTabs.Clients;
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
                MessageBox.Show("Не выбран заказ");
                return;
            }

            // Открыть окно просмотра заказа, тут зависить от роли, кнопка перегружена
            _selectedRow = -1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Не выбран заказ");
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Отправить запрос, используя _selectedTab
        }
    }


    public enum MainFormTabs
    {
        Clients,
        Masters,
        Orders
    }

    public class User
    {
        public string login;
        public string fullname;
        public string email;
        public string phone;
    }

    public class Master: User
    {
        public string about_me;
        public SortedDictionary<string, string> skills;
    }

    public class Client: User
    {

    }

    public class Admin : User
    {

    }

    public class Product
    {
        public uint id_product;
        public string type;
        public string fullname;
        public string client_description;
        public string master_specification;

    }

    public class Order
    {
        public uint id_order;
        public uint id_client;
        public uint id_master;

        public Product product;
        public string deadline;
        public uint totalcost;
        public string status;
    }

}
