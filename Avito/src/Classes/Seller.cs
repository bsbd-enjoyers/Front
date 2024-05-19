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
        public uint? id;

        public string name;

        public string phone;

        public string desc;

        public string email;

        public Seller() {
        }
    }
}
