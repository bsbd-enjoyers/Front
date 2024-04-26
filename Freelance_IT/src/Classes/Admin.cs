using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Freelance_IT.Network;

namespace Freelance_IT.Classes
{
    public class Admin : User
    {
        public Admin() { }

        public Admin(UserInfo user_info)
        {
            login = user_info.login;
        }

    }
}
