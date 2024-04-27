using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
