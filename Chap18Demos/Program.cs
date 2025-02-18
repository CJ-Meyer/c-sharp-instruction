using ConsoleLibrary;

namespace Chap18Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to LINQ\n");

            //p.581
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumberQuery = from number in numbers
                                  where number % 2 == 0
                                  orderby number descending
                                  select number;
            // execute the query - loop thru results and store in a string 
            string evenNumbers = "";
            foreach(var nbr in evenNumberQuery)
            {
                evenNumbers += nbr + " ";
            }
            MyConsole.PrintLine(evenNumbers);

            // p.583
            decimal[] salesTotals = { 1286.45m, 2433.49m, 2893.85m, 2094.53m };
            var salesList = from sales in salesTotals
                            select sales;
            decimal sum = 0;
            foreach(var sales in salesTotals) { sum += sales; }
            MyConsole.PrintLine($"sales = {sum.ToString("c")}");

            // p.583 invoices list
            List<Invoice> invoicesList = InvoiceDB.GetInvoices();
            //foreach (var invoice in invoices) { 
            //MyConsole.PrintLine(invoice.ToString());
            //}
            var invoices = from invoice in invoicesList
                           select invoice;
            foreach( var invoice in invoices)
            {
                MyConsole.PrintLine(invoice.ToString());
            }

            // p.585
            salesList = from sales in salesTotals
                        where sales > 2000
                        select sales;
            string salesDisplay = "";
            foreach( var sales in salesList)
                { salesDisplay += sales.ToString("c")+"|"; }
            MyConsole.PrintLine(salesDisplay);
            MyConsole.PrintLine("");
            MyConsole.PrintLine("---- Invoices with totals over $150 ----");
            invoices = from invoice in invoicesList
                       where invoice.InvoiceTotal>150
                       select invoice;
            string invoiceDisplay = "";
            foreach (var invoice in invoices)
            {
                invoiceDisplay += invoice.InvoiceTotal.ToString("c")+"|";
            }
            MyConsole.PrintLine(invoiceDisplay);

            MyConsole.PrintLine("==== join in LINQ ====");
            List<Customer> customerList = CustomerDB.GetCustomers();
            //join
            var invoices2 = from invoice in invoicesList
                            join Customer in customerList
                            on invoice.CustomerID equals Customer.CustomerID
                            where invoice.InvoiceTotal > 150
                            orderby Customer.Name, invoice.InvoiceTotal descending
                            select new { Customer.Name, invoice.InvoiceTotal };
            invoiceDisplay = "Customer Name\t\tInvoice Amount\n";
            foreach (var i in invoices2)
            {
                invoiceDisplay += i.Name + "\t\t" + i.InvoiceTotal.ToString("c")+"\n";
            }

            // p.593 - extension methods 
            // list of invoice totals > 150 ordered by customerID, then by invoiceTotal (desc)
            var invoices3 = invoicesList.
                            Where(i => i.InvoiceTotal > 150).
                            OrderBy(i => i.CustomerID).
                            ThenByDescending(i => i.InvoiceTotal).
                            Select(i => new { i.CustomerID, i.InvoiceTotal });
            foreach (var i in invoices3)
            {
                MyConsole.PrintLine($"{i.CustomerID} {i.InvoiceTotal:c}");
            }
        MyConsole.PrintLine("\nBYE!");
        }
    }
}
