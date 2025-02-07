using System.Diagnostics.Metrics;

namespace Project_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Batting statistics
            //Print("Welcome to the Batting Average Calculator\n");
            //string choice = "y";
            //while (choice == "y")
            //{
            //    int bats = 0;
            //    double current = 0;
            //    double total = 0;
            //    double Counter = 0;
            //    Print("Enter number of times at bat: "); bats = Int32.Parse(Console.ReadLine());
            //    PrintLine("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
            //    for (int i = 1; i <= bats; i++)
            //    {
            //        Print("\nResult for at-bat" + i + ":"); current = Double.Parse(Console.ReadLine());
            //        total += current;
            //        if (current > 0) { Counter++; }

            //    }
            //    PrintLine("Batting average: " + Counter / bats);
            //    PrintLine("\nSlugging perent: " + total / bats);
            //    Print("\nAnother player (y/n): \n"); choice = Console.ReadLine().ToLower();
            //}

            // Batting statistics with arrays

            PrintLine("Welcome to the Batting Average Calculator\n");
            string choice = "y";

            while (choice == "y")
            {
                int bats = GetValidInt("Enter number of times at bat: ", 1, 30);
                int[] results = GetBatResults(bats);
                double battingAverage, sluggingPercentage;
                CalculateStats(results, out battingAverage, out sluggingPercentage);

                PrintLine($"\nBatting Average: {battingAverage:F3}");
                PrintLine($"Slugging Percentage: {sluggingPercentage:F3}");

                choice = GetValidChoice("\nAnother player (y/n): ");
            }
            // 8-2 sales report
            // for project 8-2 Sales Report
            // regions for rows 1,2,3,4 and Q1,Q2,Q3,Q4 for columns
            // sales by region, region[i++]
            // sales by quarters, quarter[++]
            //total sales 
            PrintLine("Sales thing");
            double[,] sales = { {1540.0, 2010.0, 2450.0, 1845.0},
                                {1130.0, 1168.0, 1847.0, 1491.0},
                                {1580.0, 2305.0, 2710.0, 1284.0},
                                {1105.0, 4102.0, 2391.0, 1576.0}};
            Sales1(sales);


            // sale by region
            PrintLine("Sales by region: ");
            PrintLine("Region 1: " + (sales[0, 0] + sales[0, 1] + sales[0, 2] + sales[0, 3]).ToString("c"));
            PrintLine("Region 2: " + (sales[1, 0] + sales[1, 1] + sales[1, 2] + sales[1, 3]).ToString("c"));
            PrintLine("Region 3: " + (sales[2, 0] + sales[2, 1] + sales[2, 2] + sales[2, 3]).ToString("c"));
            PrintLine("Region 4: " + (sales[3, 0] + sales[3, 1] + sales[3, 2] + sales[3, 3]).ToString("c"));

            PrintLine("Sales by Quarter: ");
            PrintLine("Region 1: " + (sales[0, 0] + sales[1, 0] + sales[2, 0] + sales[3, 0]).ToString("c"));
            PrintLine("Region 2: " + (sales[0, 1] + sales[1, 1] + sales[2, 1] + sales[3, 1]).ToString("c"));
            PrintLine("Region 3: " + (sales[0, 2] + sales[1, 2] + sales[2, 2] + sales[3, 2]).ToString("c"));
            PrintLine("Region 4: " + (sales[0, 3] + sales[1, 3] + sales[2, 3] + sales[3, 3]).ToString("c"));

            PrintLine("Total sales: " + Sales2(sales));
        }
        // sales report pt1 method
        private static void Sales1(double[,] sales)
        {
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                string saleArray = "";
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    saleArray += (sales[i, j].ToString("c") + "\t");
                }
                PrintLine((i + 1) + "\t" + saleArray + "\n");
            }
        }

        static string Sales2(double[,] sales)
        {
            double saleArray = 0;
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    saleArray += (sales[i, j]);
                }
            }
            return Console.WriteLine("Total sales" + saleArray + "\n");
        }

        // print method 
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static int GetValidInt(string message, int min, int max)
        {
            int value;
            while (true)
            {
                Print(message);
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    PrintLine("Invalid input. Please enter a valid number.");
                    return value;
                }
            }
        }
        static string GetValidChoice(string message)
        {
            string input; while (true)
            {
                Print(message);
                input = Console.ReadLine().Trim().ToLower();

                if (input == "y" || input == "n")
                    return input;
                PrintLine("Invalid input. Please enter 'y' for Yes or 'n' for No");
            }
        }
        static int[] GetBatResults(int bats)
        {
            int[] results = new int[bats];

            PrintLine("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");

            for (int i = 0; i < bats; i++)
            {
                results[i] = GetValidInt("Enter valid integer for result at bat: ", 0, 4);
            }
            return results;
        }
        static void CalculateStats(int[] results, out double battingAverage, out double sluggingPercentage)
        {
            double hits = 0, totalBases = 0;

            foreach (int result in results)
            {
                if (result > 0) hits++;
                totalBases += result;
            }

            battingAverage = hits / results.Length;
            sluggingPercentage = totalBases / results.Length;
        }
    }
}
