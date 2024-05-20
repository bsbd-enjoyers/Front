using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avito.Network;

namespace Avito.Classes
{
    public class Seller : User
    {
        public uint? id { get; set; }

        public string name { get; set; }

        public string phone { get; set; }

        public string desc { get; set; }

        public string email { get; set; }

        public Seller() {
        }
    }
}
