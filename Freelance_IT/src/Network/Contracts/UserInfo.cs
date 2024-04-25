using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_IT.Network
{
    public class UserInfo
    {
        public uint id { get; set; }
        public string login { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string about_me { get; set; }
        public SortedDictionary<string, string> skills { get; set; }
    }
}
