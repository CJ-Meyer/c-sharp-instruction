namespace Chap07Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, chapter 7 - exceptions data validation");

            
            int nbr1 = 0;
            while (true)
            {
                Console.Write("Enter an integer: ");
                if (!Int32.TryParse(Console.ReadLine(), out nbr1))
                {
                    Console.WriteLine("Error - enter a whole number: ");
                }
                else { break; }
            }
            Console.WriteLine("You entered: " + nbr1);

            Console.WriteLine("bye");
        }
    }
}
