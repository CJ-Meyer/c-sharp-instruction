namespace Chap08Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to chapter 8 demos of arrays and such\n");

            //p.231
            //array of string - names
            string[] name = new string[9];
            name[0] = "Jim";
            name[1] = "Andy";
            name[2] = "Nick";
            name[3] = "Christian";
            name[4] = "Adrian";
            name[5] = "Sean";
            name[6] = "Celina";
            name[7] = "Heath";
            name[8] = "Joe";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("name "+i+" = " + name[i]);
            }
            // namespace [9] = "new person";
            decimal[] prices = { 1.99m, 2.25m, 4.5m };
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("prices " + i + " = " + prices[i]);
            }

            // infer the type of an array: 
            var grades = new[] { 95.0, 89.0, 91.0, 98.0 };
            double sum = 0;
            for (int i = 0;i < grades.Length; i++)
            {
                sum += grades[i];
            }
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("avg: "+sum/grades.Length);

            string fullName = "Bob Nesta Marley";
            for(int i = 0; i < fullName.Length; i++)
            {
                Console.Write(fullName[i] +"");
            }
                Console.WriteLine();
            // for each loop
            //loop through name and print on one line
            foreach (var names in name)
            {
                Console.Write(names+" ");
            }Console.WriteLine();


            //p.239
            //3 x 4 grid
            //1, 2, 3, 4
            //5, 6, 7, 8
            //9,10,11,12

            int[,] grid = new int [3,4];
            grid[0,0] = 1; grid[0,1] = 2; grid[0,2] = 3; grid[0,3] = 4;
            grid[1,0] = 5; grid[1,1] = 6; grid[1,2] = 7; grid[1,3] = 8;
            grid[2,0] = 9; grid[2,1] = 10; grid[2,2] = 11; grid[2,3] = 12;

            // print grid
            //i loop - rows
            string gridString = "";
            for (int i = 0;i < grid.GetLength(0); i++)
            {   // j loop - columns
                for (int j = 0;j < grid.GetLength(1); j++)
                {
                    gridString += grid[i, j] + "\t";
                }
                gridString += "\n";
            }
            Console.WriteLine(gridString); 
            // Array class
            Array.Sort(name);
            foreach (string names in name)
            {
                Console.WriteLine(name);
            }

            // ranges within array
            // var firstQtrSales = sales[0,3];

            // Arrays Vs collections p.255
            //

            Console.WriteLine("BYE!");
        }
    }
}
