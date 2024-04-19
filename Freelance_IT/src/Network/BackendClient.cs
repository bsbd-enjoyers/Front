using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;

using Freelance_IT.Classes;

namespace Freelance_IT.Network
{

    public class BackendClient
    {
        // look ma, no client!
        private readonly string _baseUrl;
        // JWT token????

        public BackendClient()
        {
            _baseUrl = "http://127.0.0.1:5555";
        }


        public async Task<RequestResult> checkLoginFree()
        {
            return await _baseUrl
                .AppendPathSegment("")
                .GetJsonAsync<RequestResult>();
        }

        public async Task<RequestResult> registerMaster()
        {
            return await _baseUrl
                .AppendPathSegment("")
                .GetJsonAsync<RequestResult>();
        }

        public async Task<RequestResult> registerClient()
        {
            return await _baseUrl
                .AppendPathSegment("")
                .GetJsonAsync<RequestResult>();
        }

        public async Task<RequestResult> login(string login)
        {
            return await _baseUrl
                .AppendPathSegment("")
                .GetJsonAsync<RequestResult>();
        }

        public async Task<RequestResult> logout()
        {
            return await _baseUrl
                .AppendPathSegment("")
                .GetJsonAsync<RequestResult>();
        }



        public async Task bullshit()
        {
            var result = await _baseUrl
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
