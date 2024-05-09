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
        public uint id_order;
        public uint id_client;
        public uint? id_master;
        public Product product;
        public string deadline;
        public uint? client_cost;
        public uint? master_cost;
        public string status;

        public Order() { 
        }

        public Order(OrderData order_data)
        {
            id_order = order_data.order_id;
            id_master = order_data.master_id;
            id_client = order_data.client_id;
            status = order_data.status;
            deadline = order_data.deadline;
            client_cost = order_data.client_cost;
            master_cost = order_data.master_cost;

            product = new Product();
            product.fullname = order_data.name;
            product.type = order_data.type;
            product.client_description = order_data.client_desc;
            product.master_specification = order_data.master_desc;
        }
    }

}
