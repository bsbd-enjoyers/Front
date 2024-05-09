using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Freelance_IT.Classes;

namespace Freelance_IT.Network
{
    public class OrderData
	{
        public uint order_id { get; set; }
		public string deadline { get; set; }
		public uint id_client { get; set; }
		public uint id_master { get; set; }
		public uint cost { get; set; }
		public string status { get; set; }

		public string name { get; set; }
		public string type { get; set; }
		public string client_desc { get; set; }
		public string master_desc { get; set; }
	}


    public class OrderList
    {
        public List<OrderData> orders { get; set; }
    }
}
