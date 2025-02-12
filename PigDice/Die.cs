namespace PigDice
{
    public class Die
    {
        public int Value { get; set; }
        
        public Die()
        {
            this.Value = 0;
        }
        public void Roll()
        {
            Random rand = new Random();
            this.Value = rand.Next(1, 7);
        }
    }
}
