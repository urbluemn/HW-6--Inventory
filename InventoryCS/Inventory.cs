using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryCS
{
    internal class Inventory
    {
        internal List<Product> Products;

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
