using ConsoleLibrary;
namespace GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Letter Grade Converter \n");

            string choice = "y";
            while (choice == "y")
            {
                // ** ChangeRequest: Need MyConsole.PromptInt(string prompt, int min, int max)
                int numericalGrade = MyConsole.PromptInt("Enter numerical grade: ");
                Grade grade = new Grade(numericalGrade);
                MyConsole.PrintLine($"Letter grade: {grade.GetLetter()}");
                //prompt user for numerical grade
                // create instance of GradeConverter class
                // call the ConvertGrade method
                // display the letter grade
                // ask if the user wants to continue
                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n");
            }
        }
    }
}
