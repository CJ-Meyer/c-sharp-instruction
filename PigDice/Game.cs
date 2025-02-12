namespace PigDice
{
    public class Game
    {
        public int Score { get; set; }
        public Die Die1 { get; set; }
        public int RollTotal = 0;
        public Game()
        {
            this.Die1 = new Die();
        }
        public void Play()
        {
            this.Score = 0;
            while (true)
            {
                this.Die1.Roll();
                if (this.Die1.Value == 1)
                {
                    break;
                }
                this.Score += this.Die1.Value;
            }
        }
    }
}
