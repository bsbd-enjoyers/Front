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
        public uint? seller_id;
        public string seller_name;
        public string seller_phone;
        public string seller_desc;
        public string seller_email;
        public uint? amount;

        public Seller() {
        }
    }
}
