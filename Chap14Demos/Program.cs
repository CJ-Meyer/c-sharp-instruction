using Chap12Demos;
using ConsoleLibrary;

namespace Chap14Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to inheritnece i n C#");

            string name = "Bob";
            MyConsole.PrintLine(name.ToString());
            MyConsole.PrintLine(name);
            int nbr1 = 11;
            MyConsole.PrintLine(nbr1 + nbr1.ToString());

            Movie m1 = new Movie(1, "The Godfather", 1972, "PG", "Test Director");
            MyConsole.PrintLine(m1.ToString());
            Movie m2= new Movie(2, "Marvel", 2014, "PG", "Test Director");
            MyConsole.PrintLine(m1.ToString());

            int nbr2 = 11;
            MyConsole.PrintLine($"nbr1 == nbr2? {nbr1 == nbr2}");
            MyConsole.PrintLine($"m1 == m2? {m1 == m2}");
            Movie m3 = new Movie(2, "Marvel", 2014, "PG", "Test Director");
            MyConsole.PrintLine($"m2 == m3? {m2 == m3}");

            string str1 = "abc";
            string str2 = "abc";
            MyConsole.PrintLine($"str1 == str2? {str1 == str2}");

            Movie m4 = m3;
            MyConsole.PrintLine($"m3 == m4? {m3 == m4}");

            Product p1 = new Product("c#", 10.0, "Test Product");
            MyConsole.PrintLine(p1.GetDisplayText("|"));

            book b1 = new book("java", 49.99, "murachs java", "Joel Murach");
            MyConsole.PrintLine(b1.GetDisplayText("|"));

            Software s1 =  new Software("Visual Studio", 0.0, "8.0", "Visual Studio 2022");
            MyConsole.PrintLine(s1.GetDisplayText("|"));

            book b2 = new book("C#", 49.99, "Murach's C#", "Mike Murach");
            book b3 = new book("andr", 59.99, "Murach's android", "Joel Murach");

            List <Product> products = new List<Product>();
            products.Add(b1);
            products.Add(b2);
            products.Add(s1);
            products.Add(b3);

            MyConsole.PrintLine("-------------Product summary");
            foreach (Product p in products)
            {
                MyConsole.PrintLine(p.GetDisplayText("|"));
            }
            MyConsole.PrintLine("Goodbye");
        }
    }
}
