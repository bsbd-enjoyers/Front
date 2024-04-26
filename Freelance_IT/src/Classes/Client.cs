using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Freelance_IT.Network;

namespace Freelance_IT.Classes
{
    public class Client : User
    {

        public string fullname;
        public string email;
        public string phone;

        public Client() { }

        public Client(UserInfo user_info)
        {
            login = user_info.login;
            fullname = user_info.fullname;
            email = user_info.fullname;
            phone = user_info.phone;
        }

    }
}
