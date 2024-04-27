using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;

using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;

using Freelance_IT.Classes;

namespace Freelance_IT.Network
{

    public class BackendClient
    {
        private string _baseUrl;
        private FlurlCookie _cookie;


        // У вас синглтон воняет, в курсе?
        private static BackendClient backendClient = new BackendClient();

        public static BackendClient getInstance()
        {
            return backendClient;
        }

        public BackendClient()
        {
            _baseUrl = "http://127.0.0.1:5000";
            _cookie = null;
        }


        public async Task<RequestResult> checkLoginOccupied(string login)
        {
            var response_bytes =  await _baseUrl
                .AppendPathSegment("check_login")
                .PostJsonAsync(new
                {
                    login = login
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> registerMaster(Master master, string password)
        {
            var response_bytes = await _baseUrl
                .AppendPathSegment("register")
                .PostJsonAsync(new
                {
                    login = master.login,
                    password = password,
                    fullname = master.fullname,
                    email = master.email,
                    phone = master.phone,
                    about_me = master.about_me,
                    skills = master.skills,
                    role = "master"
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> registerClient(Client client, string password)
        {
            var response_bytes = await _baseUrl
                .AppendPathSegment("register")
                .PostJsonAsync(new
                {
                    login = client.login,
                    password = password,
                    fullname = client.fullname,
                    email = client.email,
                    phone = client.phone,
                    role = "client"
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);
            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public async Task<RequestResult> login(string login, string password)
        {
            var response =  await _baseUrl
                .AppendPathSegment("login")
                .PostJsonAsync(new
                {
                    login = login,
                    password = password
                });

            // Shitted
            if (response.Cookies.Count() > 0)
            {
                _cookie = response.Cookies.First();
            }

            var json_body = Encoding.UTF8.GetString(await response.GetBytesAsync());

            return JsonSerializer.Deserialize<RequestResult>(json_body);
        }

        public bool isAuthorized()
        {
            return _cookie != null;
        }


        // not implemented
        public async Task<RequestResult> logout()
        {
            return await _baseUrl
                .AppendPathSegment("")
                .GetJsonAsync<RequestResult>();
            
        }

        public async Task<UserInfo> getMyInfo()
        {
            var response_bytes = await _baseUrl
                .AppendPathSegment("login")
                .WithCookie("AuthTokenJWT", _cookie)
                .GetBytesAsync();

            var json_body = Encoding.UTF8.GetString(response_bytes);

            return JsonSerializer.Deserialize<UserInfo>(json_body);
        }

        // Нужно создать еще контрактов для клиента, мастера и заказа
        public async Task<List<Client>> searchClients(string search_info)
        {
            var response_bytes = await _baseUrl
                .AppendPathSegment("")
                .WithCookie("AuthTokenJWT", _cookie)
                .PostJsonAsync(new
                {
                    search_info = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);

            return JsonSerializer.Deserialize<List<Client>>(json_body);
        }

        public async Task<List<Master>> searchMasters(string search_info)
        {
            var response_bytes = await _baseUrl
                .AppendPathSegment("")
                .WithCookie("AuthTokenJWT", _cookie)
                .PostJsonAsync(new
                {
                    search_info = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);

            return JsonSerializer.Deserialize<List<Master>>(json_body);
        }

        public async Task<List<Order>> searchOrders(string search_info)
        {
            var response_bytes = await _baseUrl
                .AppendPathSegment("")
                .WithCookie("AuthTokenJWT", _cookie)
                .PostJsonAsync(new
                {
                    search_info = search_info
                })
                .ReceiveBytes();

            var json_body = Encoding.UTF8.GetString(response_bytes);

            return JsonSerializer.Deserialize<List<Order>>(json_body);
        }


        public async Task bullshit()
        {
            var result = await _baseUrl
                .WithCookie("AuthTokenJWT", _cookie)
                .PostJsonAsync(new
                {
                    first_name = "Claire",
                    last_name = "Underwood"
                });

            Console.WriteLine("###############################");
            Console.WriteLine(result.ResponseMessage);

        }
    }

}
