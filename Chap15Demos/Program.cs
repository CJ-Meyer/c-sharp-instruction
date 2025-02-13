using System.Reflection;
using ConsoleLibrary;

namespace Chap15Demos{
    internal class Program{
        static void Main(string[] args){
            MyConsole.PrintLine("Welcome to interfaces!!!\n");
            List <Summarizable> things = new List <Summarizable>();
            // create some products
            Product p1 = new Product("c#", "Murach's C#", 53.99m);
            Product p2 = new Product("mysql", "Murach's SQL", 45.99m);
            Product p3 = new Product("Java", "Murach's Java", 69.99m);
            things.Add(p1);
            things.Add(p2);
            things.Add(p3);

            // create some customers
            Customer c1 = new Customer("Adrian", "Johnson", "AJ001");
            Customer c2 = new Customer("Celina", "Saksith", "CS001");
            things.Add(c1);
            things.Add(c2);

            // print summary
            MyConsole.PrintLine("Summary: ");
            foreach (var thing in things)
            {
                MyConsole.PrintLine($"{thing.GetSummaryDetails()}");
            }

            // list of products 
            List <Product> products = new List <Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            // sort products
            products.Sort();
            MyConsole.PrintLine("=== Sorted Products ===");
            foreach (Product p in products)
            {
                MyConsole.PrintLine(p.GetSummaryDetails());
            }


            MyConsole.PrintLine("BYE!");
        }
    }
}
