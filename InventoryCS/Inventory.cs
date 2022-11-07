using System;
using System.Collections.Generic;
using System.Globalization;
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
        public void ViewProducts()
        {
            foreach(Product product in Products)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---------------");
                Console.WriteLine($"Product name: {product.Name}");
                Console.WriteLine($"Product type: {product.Type}");
                Console.WriteLine($"Total amount: {product.Amount}");
                Console.WriteLine($"Price: {product.Price.ToString("C2", CultureInfo.CurrentCulture)}");
            }
            Console.ResetColor();
        }

        public void SortByType(string type)
        {
            List<Product> SortedProducts = new List<Product>();
            for (int i = 0; i < Products.Count; i++)
            {
                if(Products[i].Type == type)
                    SortedProducts.Add(Products[i]);
            }
            for(int i = 0; i < SortedProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}) Product by type \"{type}\": Name: {SortedProducts[i].Name}, Amount: {SortedProducts[i].Amount}," +
                    $" Price: {SortedProducts[i].Price.ToString("C2", CultureInfo.CurrentCulture)}");
            }

        }
        
        public void CountInvSum()
        {
            decimal InvSum = 0M;
            for (int i = 0; i < Products.Count; i++)
                InvSum += Products[i].Amount * Products[i].Price;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Total inventory price is: {InvSum.ToString("C2", CultureInfo.CurrentCulture)}");
            Console.ResetColor();
        }
    }
}
