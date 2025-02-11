namespace Chap16ExDiceRoller
{
    public class Die
    {
        public int Value { get; set; }
        public Die()
        {
            this.Value = 0;
        }
        public void roll()
        {
            //set value to random die roll
            Random rand = new Random();
            this.Value = rand.Next(1, 7);
        }
    }
}
