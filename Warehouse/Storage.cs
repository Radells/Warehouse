using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class Storage
    {
        public List<Product> storageProducts = new List<Product>();
        public void GetInfo()
        {
            for(var i = 0; i < storageProducts.Count; i++)
            {
                Console.WriteLine($"ID ячейки {storageProducts[i].ID}, вес содержимого {storageProducts[i].Weight}");
            }
        }
    }
}
