using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_IT.Classes
{
    public class Master : User
    {
        public string fullname;
        public string email;
        public string phone;
        public string about_me;
        public SortedDictionary<string, string> skills;
    }
}
