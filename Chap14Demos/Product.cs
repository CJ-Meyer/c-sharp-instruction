namespace Chap14Demos
{
    public class Product
    {
        public string Code { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Product(string code, double price, string description)
        {
            this.Code = code;
            this.Price = price;
            this.Description = description;
        }
        public Product() { }
        public virtual GetDisplayText(string sep)
        {
            return $"{Code}{sep}{Price:c}{Description} ";
        }
        public override string GetDisplayText(string sep)
        {
            return $"{base.GetDisplayText(sep)}{Version}";
        }

    }
}
