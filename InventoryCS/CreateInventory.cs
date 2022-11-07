using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryCS
{
    internal class CreateInventory
    {
        internal Inventory InitInventory()
        {
            var inventory = new Inventory();
            inventory.Products = new List<Product>();
            var apple = new Product("Apple", "Food", 25, 2.5M);
            var chocolateBar = new Product("Chocolate Bar", "Food", 15, 4M);
            var washingPowder = new Product("Washing Powder", "Chemicals", 10, 6.25M);
            var soap = new Product("Soap", "Chemicals", 20, 1.5M);
            var washingMachine = new Product("Washing Machine", "Machinery", 4, 150M);
            var cellPhone = new Product("Cell Phone", "Machinery", 10, 80M);
            inventory.AddProduct(apple);
            inventory.AddProduct(chocolateBar);
            inventory.AddProduct(washingPowder);
            inventory.AddProduct(soap);
            inventory.AddProduct(cellPhone);
            inventory.AddProduct(washingMachine);
            return inventory;
            
        }
        
        
    }
}
