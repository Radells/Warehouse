using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class QueueStorage
    {
        public Queue<Product> products = new Queue<Product>();

        public void AddQueue(Product product)
        {
            products.Enqueue(product);
        }
        public void AddQueue(Product[] product)
        {
            for(var i = 0; i < product.Length; i++)
            {
                products.Enqueue(product[i]);
            }
        }
    }
}
