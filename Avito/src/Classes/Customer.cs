using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avito.Network;

namespace Avito.Classes
{
    public class Customer : User
    {
        public uint? customer_id;
        public string customer_name;
        public string customer_phone;
        public string customer_desc;
        public string customer_email;
        public uint? amount;

        public Customer() { }

    }
}
