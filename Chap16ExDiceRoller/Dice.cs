using ConsoleLibrary;

namespace Chap16ExDiceRoller
{
    public class Dice
    {
        public Die Die1 { get; set; }
        public Die Die2 { get; set; }
        public Dice()
        {
            this.Die1 = new Die();
            this.Die2 = new Die();
        }
        public int Sum()
        {
            return this.Die1.Value + this.Die2.Value;
        }
        public void roll()
        {
            this.Die1.roll();
            this.Die2.roll();
        }
        public string GetRollResults()
        {   //changed to return string
            string returnStr = ($"Die 1: {this.Die1.Value}\n");
            returnStr += ($"Die 2: {this.Die2.Value}\n");
            returnStr += ($"Total: {this.Sum()}\n");
            if (Sum() == 2)
            {
                returnStr += "Snake Eyes!\n";
            }
            else if (Sum() == 7)
            {
                returnStr += "Craps!\n";

            }
            else if (Sum() == 12)
            {
                returnStr += "Box Cars!\n";

            }
            return returnStr;
        }
    }
}
