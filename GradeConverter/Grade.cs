using System.Net.Http.Headers;

namespace GradeConverter
{
    public class Grade
    {
        public int Number { get; set; }
        public Grade()
        {
            this.Number = 0;
            
        }
        public Grade(int number)
        {
            this.Number = number;
        }
        public string GetLetter()
        {
            string letterGrade = "F";
            if (Number >= 88)
            {
                letterGrade = "A";
            }
            else if (Number >= 80)
            {
                letterGrade = "B";
            }
            else if (Number >= 68)
            {
                letterGrade = "C";
            }
            else if (Number >= 60)
            {
                letterGrade = "D";
            }
            return letterGrade;
        }
    }
}
