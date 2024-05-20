using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avito.Network;

namespace Avito.Classes
{
    public class Order
    {
        public uint? order_id { get; set; }

        public uint? price { get; set; }

        public string desc { get; set; }

        public uint? quantity { get; set; }

        public string delivery_date { get; set; }

        public string status { get; set; }

        public string name { get; set; }

        public Order() { 
        }
    }

}
