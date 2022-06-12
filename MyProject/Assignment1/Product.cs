using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Product
    {
        private object v1;
        private object v2;
        private object v3;

        public int id { get; set; }
        public string proName { get; set; }
        public string proDesc { get; set; }
        public double price { get; set; }

        public Product(int id, string proName, string proDesc, double price)
        {
            this.id = id;
            this.proName = proName;
            this.proDesc = proDesc;
            this.price = price;

        }
        public Product(string proName, string proDesc, double price)
        {
            this.proName = proName;
            this.proDesc = proDesc;
            this.price = price;
        }
    }
}
