using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Avito.Classes;

namespace Avito.Network
{

	public class OrderData
	{
        public uint order_id { get; set; }
		public string deadline { get; set; }
		public uint client_id { get; set; }
		public uint? master_id { get; set; }
		public uint? client_cost { get; set; }
		public uint? master_cost { get; set; }
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
