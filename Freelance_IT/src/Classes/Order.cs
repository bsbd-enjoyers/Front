using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Freelance_IT.Network;

namespace Freelance_IT.Classes
{
    public class Order
    {
        public uint id_order = 0;
        public uint id_client = 0;
        public uint id_master = 0;
        public Product product = null;
        public string deadline = null;
        public uint totalcost = 0;
        public string status = null;

        public Order() { 
        }

        public Order(OrderData order_data)
        {
            id_order = order_data.order_id;
            id_master = order_data.id_master;
            id_client = order_data.id_client;
            status = order_data.status;
            deadline = order_data.deadline;
            totalcost = order_data.cost;

            product = new Product();
            product.fullname = order_data.name;
            product.type = order_data.type;
            product.client_description = order_data.client_desc;
            product.master_specification = order_data.master_desc;
        }
    }

}
