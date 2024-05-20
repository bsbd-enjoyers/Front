using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avito.Classes
{
    public class Product
    {
        public uint? product_id { get; set; }

        public uint? price { get; set; }

        public string desc { get; set; }

        public uint? quantity { get; set; }

        public string name { get; set; }

        public Product() { }
    }
}
