namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is exercise questions");

            // Student registration form 
            //Console.WriteLine("Enter First Name: "); string firstName = Console.ReadLine();
            //Console.WriteLine("Enter Last Name: "); string lastName = Console.ReadLine();
            //Console.WriteLine("Year of Birth: "); string yOB = Console.ReadLine();
            //Console.WriteLine("Welcome " + firstName + ' ' + lastName + "!");
            //Console.WriteLine("Your registration is complete.");
            //Console.WriteLine("Your temporary password is: " + firstName + "*" + yOB);

            //convert number grade to letter grade
            Console.WriteLine("Enter numerical grade: "); int numGrade = Convert.ToInt32(Console.ReadLine());
            if (numGrade >= 88)
            {
                Console.WriteLine("Letter grade: A");
            }else if (numGrade >= 80)
            {
                Console.WriteLine("Letter grade: B");
            }else if (numGrade >= 67)
            {
                Console.WriteLine("Letter grade: C");
            }else if (numGrade >= 60)
            {
                Console.WriteLine("Letter grade: D");
            }else
            {
                Console.WriteLine("Letter grade: F");
            }
            //rectangular calculator'
            string choice = "y";
            while (choice =="y") {
                Console.WriteLine("Welcome to the are and perimeter calculator");
                Console.WriteLine("Enter length: "); int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter width: "); int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Area: " + length * width);
                Console.WriteLine("Perimeter: " + (2 * (length + width)));
                Console.WriteLine("continue y/n");
                choice = Console.ReadLine();
            }
            

            Console.WriteLine("BYE");
        }
    }
}
