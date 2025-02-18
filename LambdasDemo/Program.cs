using ConsoleLibrary;

namespace LambdasDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambdas Demo!");
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DisplayListAsString(numbers, "Orginal List");

            // create a new list called squareNums1
            // store the squared versions of all numbers in the list above 

            List<int> squareNums1 = new List<int>() { };
            for (int i = 0; i < numbers.Count; i++) {
                squareNums1.Add(Square(numbers[i]));
            }
            DisplayListAsString(squareNums1, "Squared List");
            // do this again, using method as a parameter
            List<int> squares2 = numbers.Select(Square).ToList();
            DisplayListAsString(squares2, "squared list 2 using a method as parameter");

            //using lambda expression
            List<int> squares3 = numbers.Select(x => x*x).ToList();
            DisplayListAsString(squares3, "squared list 3 using a lambda expression: ");


            // create a new list called divThree1
            // store the numbs from numbers that are evenly divisible by three -- use % in a for loop and iterate

            List<int> divThree1 = new List<int>() { };
            for (int i = 0; i < numbers.Count; i++) {
                if (IsDivisbleByThree(i))
                {
                    divThree1.Add(numbers[i]);
                }
            }
            DisplayListAsString(divThree1, "DivThree list 1");

            List<int> divThree2 = numbers.FindAll(IsDivisbleByThree).ToList();
            DisplayListAsString(divThree2, "DivThree list 2");

            List<int> divThree3 = numbers.FindAll(x=> x % 3 == 0).ToList();
            DisplayListAsString(divThree3, "DivThree list 3");



            MyConsole.PrintLine("BYE!!");
        }
        private static bool IsDivisbleByThree(int x)
        {
            return x % 3 == 0;
        }

        private static int Square(int value)
        {
            return value * value;
        }
        private static void DisplayListAsString(List<int> numbers, string header)
        {
            string result = "========================================\n";
            result += header + "\n";
            result += "========================================\n";
            foreach (var value in numbers)
            {
                result += value.ToString() + " ";
            }
            result += "\n";
            MyConsole.PrintLine(result);
        }
    }
}
