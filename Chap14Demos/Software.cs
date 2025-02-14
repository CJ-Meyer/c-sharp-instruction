namespace Chap14Demos
{
    public sealed class Software: Product
    {
        public string Version { get; set; }
        public Software(string code, double price, string description, string version) :
            base(code, price, description)
        {
            this.Version = version;
        }

        public override string GetDisplayText(string sep)
        {
            return $"{base.GetDisplayText(sep)}{Version}";
        }
    }
}
