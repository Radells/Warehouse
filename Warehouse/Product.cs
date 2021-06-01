using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Product
    {
        public int Weight { get; }
        public int ID { get; set; }
        public Product (int weight)
        {
            Weight = weight;
        }
    }
}
