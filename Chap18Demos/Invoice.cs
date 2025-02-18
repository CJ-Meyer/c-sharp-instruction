namespace Chap18Demos;

public class Invoice
{
    public int InvoiceID { get; set; }
    public int CustomerID { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal ProductTotal { get; set; }
    public decimal SalesTax { get; set; }
    public decimal Shipping { get; set; }
    public decimal InvoiceTotal { get; set; }

    public override string ToString()
    {
        return $"Invoice: ({InvoiceID})|{CustomerID}|{InvoiceDate:yyyy-MM-dd}|{ProductTotal:c}|{SalesTax:c}|{Shipping:c}|{InvoiceTotal:c}";
    }
}
