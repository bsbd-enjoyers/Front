using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Freelance_IT.Network;

namespace Freelance_IT.Classes
{
    public class Master : User
    {
        public string fullname;
        public string email;
        public string phone;
        public string about_me;
        public SortedDictionary<string, string> skills;
        public float? score;

        public Master() {
            skills = new SortedDictionary<string, string>();
        }

        public Master(UserInfo user_info)
        {
            login = user_info.login;
            fullname = user_info.fullname;
            email = user_info.fullname;
            phone = user_info.phone;

            about_me = user_info.about_me;
            skills = user_info.skills;
            score = user_info.score;
        }
    }
}
