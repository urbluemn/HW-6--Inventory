using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCS
{
    internal class Product
    {
        protected string Name;
        protected string Type;
        protected int Amount;
        protected int Price;

       public Product(string name, string type, int amount, int price)
        {
            Name = name;
            Type = type;
            Amount = amount;
            Price = price;
        }
    }
}
