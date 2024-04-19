using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance_IT.Classes
{
    public class Order
    {
        public uint id_order;
        public uint id_client;
        public uint id_master;

        public Product product;
        public string deadline;
        public uint totalcost;
        public string status;
    }
}
