namespace Ch04DemoNumberStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the numbers and strings Demo!");
            int dayOfWeek = 5;
            decimal price = 11.99m;
            int quantity = 3;
            char letter = 'A';
            bool isValid = false;
            double interestRate = .0367;

            //constants
            const int DaysInWeek = 7;
            const int DaysInNovember = 30;
            const int DAYS_IN_YEAR = 365; // might see in other languages

            // arithmetic operators
            decimal lineItemTotal = price *quantity;
            int count = 0;
            while (count < DaysInNovember)
            {
                count += 2;
                Console.WriteLine(count);
            }

            int a = 9;
            int b = 2;
            int qoutient = a/b;
            int remainder = a % b;
            Console.WriteLine("qoutient = " + qoutient);
            Console.WriteLine("remainder = " + remainder);

            double result = a / b;
            Console.WriteLine("result = " + result);

            double c = 9.0;
            double d = 2.0;
            result = c / d;
            Console.WriteLine("result = " + result);

            int counter = 10;
            counter = counter + 1;
            counter++;
            counter += 1;
            Console.WriteLine("counter = "+counter);

            // add 5 to counter
            counter = counter + 5;
            counter += 5;
            Console.WriteLine("counter = " + counter);
            //subtract 2 
            counter -= 2;
            Console.WriteLine("counter = " + counter);
            //divide 2
            counter /= 2;
            Console.WriteLine("counter = " + counter);
            //mulitply 2
            counter *= 3;
            Console.WriteLine("counter = " + counter);

            //casting
            int e = 5;
            double f = e;
            double g = 6.7;
            int h = (int)g;

            //Math class
            interestRate = .0347825;
            Console.WriteLine("interestRate = " + interestRate);
            //rounded to 4 deciaml points 
            interestRate = Math.Round(interestRate, 4);
            Console.WriteLine("interestRate = " + interestRate);

            //random class
            Random rand = new Random();
            int r1 = rand.Next();
            Console.WriteLine("r1 = "+r1);
            int dieRoll = rand.Next(1,7);
            Console.WriteLine("dieRoll = "+dieRoll);

            //Strings
            string firstName = "Bob";
            string lastName = "Marley";
            //string fullName = firstName +" "+ lastName;
            //Console.WriteLine(fullName);
            string fullName = firstName;
            fullName += ' ';
            fullName += lastName;

            //escape sequences - tab, newline, backslash
            string sentence = "abc\tdef\nghi";
            Console.WriteLine(sentence);
            string reposFolder = "c:\\repos";
            Console.WriteLine(reposFolder);

            string rawMessage = """
                Hello there
                how are you?

                I'm fine, how are you??
                 

                 I dont know     why?
                """;
            Console.WriteLine(rawMessage);
            // basic while loops
            // execute the two numbers and sum until user is done 
            string choice = "y";
            while (choice == "y") { 
            Console.WriteLine("Enter two whole numbers: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum = "+(n1+n2));
            Console.WriteLine("continue? (y/n): ");
            choice = Console.ReadLine();
            }

            // if statement
            //discount %:
            //if amount is > 1000 discPct.10
            //else if amount >800, discCct = .08
            //else if amount >500, discCct = .05
            //else discPct = .00
            double amount = 900;
            double discPct = 0.0;
            if (amount >= 1000)
            {
                discPct = .1;
            } else if (amount >= 800)
            {
                discPct = .08;
            }
            else if (amount >= 500)
            {
                discPct = .05;
            }else { discPct = 0.0;}
            Console.WriteLine(amount * discPct);

            // get input from the console
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello there "+name);
            

            Console.WriteLine("BYE!");

            
        }
    }
}
