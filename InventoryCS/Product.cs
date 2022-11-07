using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCS
{
    internal class Product
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, string type, int amount, decimal price)
        {
            Name = name;
            Type = type;
            Amount = amount;
            Price = price;
        }
    }
}
