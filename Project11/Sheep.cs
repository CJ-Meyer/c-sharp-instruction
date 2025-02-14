namespace Project11
{
    internal class Sheep : Animal {
        public string Name { get; set; }  // Constructor to initialize Name

        public override string GetCountString()
        {
            return $"{Count}{Name}";
        }
    }
}
