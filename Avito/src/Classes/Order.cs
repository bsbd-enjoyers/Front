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
        public uint? order_id;
        public uint? product_id;
        public uint? customer_id;
        public uint? quantity;
        public string delivery_date;
        public uint? price;
        public string status;

        public Order() { 
        }
    }

}
