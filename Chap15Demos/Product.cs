namespace Chap15Demos
{
    internal class Product : Summarizable {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }

        public Product(string code, string description,  decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.price = price;
        }

        public string GetSummaryDetails()
        {
            string summary = $"Product: ({Code}) {Description} @ {price:c}";

            return summary;
        }

    }
}
