﻿using System;
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
            _searchedClients = new List<Client>();
            _searchedMasters = new List<Master>();
            _searchedOrders = new List<Order>();

            deinitializeUser();
        }

        // private 
        private User _user;

        private List<Order> _searchedOrders;
        private List<Client> _searchedClients;
        private List<Master> _searchedMasters;


        private DataTable _dataTable = new DataTable();
        private int _selectedRow = -1;

        private MainFormTabs _selectedTab;

        private void initializeAdmin()
        {
            avatarPictureBox.Image = Freelance_IT.Properties.Resources.admin;

            initializeOrderTable();
            updateOrderTable();

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
            updateOrderTable();

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
            updateOrderTable();

            orderButton.Show();
            masterButton.Hide();
            clientButton.Hide();

            DataGridView.Show();

            createButton.Show();
            deleteButton.Show();
            checkButton.Show();
            feedbackButton.Show();

            searchButton.Hide();
            searchTextBox.Hide();
        }

        private void deinitializeUser()
        {
            DataGridView.Hide();
            createButton.Hide();
            deleteButton.Hide();
            checkButton.Hide();
            feedbackButton.Hide();

            _searchedClients.Clear();
            _searchedMasters.Clear();
            _searchedOrders.Clear();
            _user = null;
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

        private void updateClientTable()
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Client client in _searchedClients)
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

        private void updateMasterTable()
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Master master in _searchedMasters)
            {
                _dataTable.Rows.Add(master.id, master.fullname, master.email, master.phone);
            }
        }

        private async void initializeOrderTable()
        {
            _selectedTab = MainFormTabs.Orders;

            _dataTable.Columns.Clear();
            _dataTable.Columns.Add("ID заказа", typeof(string));
            _dataTable.Columns.Add("Тип продукта", typeof(string));
            _dataTable.Columns.Add("Полное название продукта", typeof(string));
            _dataTable.Columns.Add("Статус заказа", typeof(string));


            _searchedOrders.Clear();
            _searchedOrders.AddRange(await BackendClient.getInstance().getOrders());

            _selectedRow = -1;
        }

        private void updateOrderTable()
        {
            _dataTable.Rows.Clear();
            _selectedRow = -1;

            foreach (Order order in _searchedOrders)
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

        private void logOrShowUser()
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
                switch (_user.GetType().ToString())
                {
                    case "Freelance_IT.Classes.Admin":
                        break;
                    case "Freelance_IT.Classes.Master":
                        AboutMeMasterForm.getDetailedInfo((Master)_user);
                        // Возможно, тут надо заапдейтить инфо о мастере запросом
                        break;
                    case "Freelance_IT.Classes.Client":
                        AboutMeClientForm.getDetailedInfo((Client)_user);
                        // Возможно, тут надо заапдейтить инфо о клиенте запросом
                        break;
                }
            }
        }

        private async void logutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _user = null;
            loginLabel.Text = "Логин";
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

            logOrShowUser();
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            logOrShowUser();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            initializeOrderTable();
            updateOrderTable();
        }

        private void masterButton_Click(object sender, EventArgs e)
        {
            initializeMasterTable();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            initializeClientTable();
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            Order order = ClientCreateOrderForm.createOrder();

            if (order == null)
            {
                MessageBox.Show("Заказ не был создан");
                return;
            }

            order.status = "created";
            order.id_client = _user.id;

            try
            {
                BackendClient backendClient = BackendClient.getInstance();

                var create_order_result = await backendClient.createOrder(order);

                if (!create_order_result.result)
                {
                    MessageBox.Show("Заказ не был создан");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ой, что-то пошло не так...\nПопробуйте еще раз");
                return;
            }
            return;
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            if (_selectedRow == -1)
            {
                MessageBox.Show("Ничего не было выбрано");
                return;
            }

            Feedback feedback = new Feedback();
            feedback.id_order = _searchedOrders[_selectedRow].id_order;

            feedback = FeedbackForm.getFeedback(feedback);

            _selectedRow = -1;

            if (feedback == null)
            {
                MessageBox.Show("Отзыв не был оставлен");
                return;
            }
            // Послать запрос на создание отзыва
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
                case MainFormTabs.Clients:
                    AboutMeClientForm.getDetailedInfo(_searchedClients[_selectedRow]);
                    break;
                case MainFormTabs.Masters:
                    AboutMeMasterForm.getDetailedInfo(_searchedMasters[_selectedRow]);
                    break;
                case MainFormTabs.Orders:

                    if (_user.GetType().ToString() == "Freelance_IT.Classes.Master" &&
                        _searchedOrders[_selectedRow].status == "created")
                    {
                        Order order = MasterHandleOrderForm.masterRespondOrder(_searchedOrders[_selectedRow]);
                        if(order != null)
                        {
                            order.status = "responded";
                            order.id_master = _user.id;
                            // Обновить инфу о заказе через запрос
                        }
                        break;
                    }

                    if (_user.GetType().ToString() == "Freelance_IT.Classes.Client" &&
                        _searchedOrders[_selectedRow].status == "responded")
                    {
                        switch (HandleOrderForm.lastStepAcceptingOrder(_searchedOrders[_selectedRow]))
                        {
                            case DialogResult.Yes:
                                _searchedOrders[_selectedRow].status = "agreed";
                                // Обновить инфу о заказе, клиент согласен
                                break;
                            case DialogResult.No:
                                _searchedOrders[_selectedRow].status = "created";
                                // Обновить инфу о заказе, клиент не согласен
                                break;
                        }
                        break;
                    }

                    HandleOrderForm.showOrderInfo(_searchedOrders[_selectedRow]);
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

            switch (_selectedTab)
            {
                case MainFormTabs.Clients:
                    MessageBox.Show("Пока клиентов удалять нельзя!");
                    break;
                case MainFormTabs.Masters:
                    MessageBox.Show("Пока исполнителей удалять нельзя!");
                    break;
                case MainFormTabs.Orders:
                    if (_searchedOrders[_selectedRow].status == "created" ||
                        _searchedOrders[_selectedRow].status == "responded"
                        )
                    {
                        // Послать запрос на удаление заказа
                    }
                    break;
            }
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
                        _searchedClients.Clear();
                        _searchedClients.AddRange(await backendClient.searchClients(searchTextBox.Text));
                        
                        updateClientTable();

                        break;
                    case MainFormTabs.Masters:
                        _searchedMasters.Clear();
                        _searchedMasters.AddRange(await backendClient.searchMasters(searchTextBox.Text));

                        updateMasterTable();

                        break;
                    case MainFormTabs.Orders:
                        _searchedOrders.Clear();
                        _searchedOrders.AddRange(await backendClient.searchOrders(searchTextBox.Text));

                        updateOrderTable();
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
