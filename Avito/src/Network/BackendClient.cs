using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;
using System.Net.Http;

using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;

using Avito.Classes;

namespace Avito.Network
{

    public class BackendClient
    {
        private FlurlCookie _cookie;
        private FlurlClient _client;


        // У вас синглтон воняет, в курсе?
        private static BackendClient backendClient = new BackendClient();


        public static BackendClient getInstance()
        {
            return backendClient;
        }

        public BackendClient()
        {
            _cookie = null;
            _client = new FlurlClient(new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain,
                                                             errors) => true
            }));
            _client.BaseUrl = new Url("https://127.0.0.1:5000");
        }

        public async Task<RequestResult> checkLoginOccupied(string login)
        {
            var response_bytes =  await _client.Request()
                .AppendPathSegment("check_login")
                .PostJsonAsync(new
                {
                    login = login
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> registerCustomer(Customer customer, string password)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("register")
                .PostJsonAsync(new
                {
                    login = customer.login,
                    password = password,
                    name = customer.name,
                    email = customer.email,
                    phone = customer.phone,
                    desc = customer.desc,
                    role = "customer"
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> registerSeller(Seller seller, string password)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("register")
                .PostJsonAsync(new
                {
                    login = seller.login,
                    password = password,
                    name = seller.name,
                    email = seller.email,
                    phone = seller.phone,
                    desc = seller.desc,
                    role = "seller"
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }


        public async Task<User> login(string login, string password)
        {
            var response =  await _client.Request()
                .AppendPathSegment("login")
                .PostJsonAsync(new
                {
                    login = login,
                    password = password
                });

            if (response.Cookies.Count() == 0)
            {
                return null;
            }

            _cookie = response.Cookies.First();

            var json_body = Encoding.UTF8.GetString(await response.GetBytesAsync());

            return JsonSerializer.Deserialize<User>(json_body);
        }

        public bool isAuthorized()
        {
            return _cookie != null;
        }


        // not Checked
        public async Task<RequestResult> logout()
        {

            var response_bytes = await _client.Request()
                .AppendPathSegment("")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .GetBytesAsync();

            _cookie = null;

            var json_body = Encoding.UTF8.GetString(response_bytes);

            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        // not Checked
        public List<Product> getMyProducts()
        {
            var task_response_bytes = _client.Request()
                .AppendPathSegment("orders")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .GetBytesAsync();

            var json_body = Encoding.UTF8.GetString(task_response_bytes.Result);

            return JsonSerializer.Deserialize<ProductList>(json_body).products;
        }

        // not Checked
        public async Task<RequestResult> createProduct(Product product)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("products")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    action="create",
                    price = product.price,
                    desc = product.desc,
                    quantity = product.quantity,
                    name = product.name
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        // not Checked
        public async Task<RequestResult> createOrder(uint product_id, Order order)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("orders")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    action = "create",
                    product_id = product_id,
                    quantity = order.quantity,
                    delivery_date = order.delivery_date
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        // not Checked
        public List<Order> getMyOrders()
        {
            var task_response_bytes = _client.Request()
                .AppendPathSegment("orders")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .GetBytesAsync();

            var json_body = Encoding.UTF8.GetString(task_response_bytes.Result);

            return JsonSerializer.Deserialize<OrderList>(json_body).orders;
        }

        // not Checked
        public async Task<Seller> getSellerInfoByOrder(uint order_id)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("info")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    order_id = order_id
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<Seller>(json_body);
        }

        // not Checked
        public async Task<Seller> getSellerInfoByProduct(uint product_id)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("info")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    product_id = product_id
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<Seller>(json_body);
        }

        // not Checked
        public async Task<Customer> getCustomerInfoByOrder(uint order_id)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("info")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    order_id = order_id
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<Customer>(json_body);
        }

        // not Checked
        public async Task<RequestResult> updateOrderStatus(uint order_id, string new_status)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("orders")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    action = "update",
                    order_id = order_id,
                    status=new_status
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        // not Checked
        public List<Product> searchProducts(string search_info)
        {
            var response_bytes = _client.Request()
                .AppendPathSegment("/search")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    entity = "product",
                    query = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes.Result);

            return JsonSerializer.Deserialize<ProductList>(json_body).products;
        }

        // not Checked
        public List<Order> searchOrders(string search_info)
        {
            var response_bytes = _client.Request()
                .AppendPathSegment("/search")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    entity = "order",
                    query = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes.Result);

            return JsonSerializer.Deserialize<OrderList>(json_body).orders;
        }

        // not Checked
        public List<Customer> searchCustomers(string search_info)
        {
            var response_bytes = _client.Request()
                .AppendPathSegment("/search")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    entity = "customer",
                    query = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes.Result);

            return JsonSerializer.Deserialize<CustomerList>(json_body).users;
        }

        // not Checked
        public List<Seller> searchSellers(string search_info)
        {
            var response_bytes = _client.Request()
                .AppendPathSegment("/search")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    entity = "seller",
                    query = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes.Result);

            return JsonSerializer.Deserialize<SellerList>(json_body).users;
        }




















        /*public async Task<UserInfo> getMyInfo()
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("session")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .GetBytesAsync();

            var json_body = Encoding.UTF8.GetString(response_bytes);

            return JsonSerializer.Deserialize<UserInfo>(json_body);
        }

        public async Task<List<Client>> searchClients(string search_info)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("search")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    entity = "client",
                    query = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);

            List<Client> client_list = new List<Client>();

            foreach (UserInfo client_data in JsonSerializer.Deserialize<ClientList>(json_body).users)
            {
                client_list.Add(new Client(client_data));
            }

            return client_list;
        }

        public async Task<List<Master>> searchMasters(string search_info)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("search")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    entity = "master",
                    query = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);

            List<Master> master_list = new List<Master>();

            foreach (UserInfo master_data in JsonSerializer.Deserialize<MasterList>(json_body).users)
            {
                master_list.Add(new Master(master_data));
            }

            return master_list;
        }



        public async Task<RequestResult> deleteOrder(uint order_id)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("delete")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    entity = "order",
                    id = order_id
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> masterRespondOrder(Order order)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("orders")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    action = "update",
                    id_order = order.id_order,
                    type = order.product.type,
                    cost = order.master_cost,
                    master_desc = order.product.master_specification
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> clientHandleOrder(uint order_id, bool submit_or_refuse)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("orders")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    id_order = order_id,
                    action = "submit",
                    submit = submit_or_refuse
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> banUser(string login, string role)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("manage")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    id = login,
                    entity = role
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        // not Checked
        public async Task<RequestResult> leaveFeedback(Feedback feedback)
        {
            var response_bytes = await _client.Request()
                .AppendPathSegment("reviews")
                .WithCookie("AuthTokenJWT", _cookie.Value)
                .PostJsonAsync(new
                {
                    order_id = feedback.id_order,
                    score = feedback.score,
                    comment = feedback.comment
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }*/
    }
}
