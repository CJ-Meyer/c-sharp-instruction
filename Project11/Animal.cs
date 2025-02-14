namespace Project11
{
    abstract class Animal: Countable {
        public int Count { get; set; }
        public string Name { get; set; }
        public Animal() { this.Count = 0 }

        public void incrementCount() {
            Count++;
        }
        public void resetCount()
        {
            Count = 0;
        }
        public abstract string GetCountString();
    }
}
