using AccountBalanceCalculator.Model;
using ConsoleLibrary;
namespace AccountBalanceCalculator.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Account Balance Calculator!");
            //init checking and savings account
            CheckingAccount ca = new CheckingAccount(1.0m);
            ca.Balance = 1000.0m;
            SavingsAccount sa = new SavingsAccount(.01m);
            sa.Balance = 1000.0m;
            MyConsole.PrintLine("Starting Balances");
            DisplayBalances(ca, sa);
            MyConsole.PrintLine("\nEnter transactions for the month:\n");

            string choice = "y";
            while (choice == "y")
            {
                Account a;
                string action = MyConsole.PromptReqString("Deposit or Withdraw? (d/w): ", "d", "w");
                string account = MyConsole.PromptReqString("Savings or Checking? (s/c): ", "s", "c");
                decimal amount = MyConsole.PromptDecimal("Amount: ");
                //process transaction
                if (account == "c")
                {
                    a = ca;
                } else { a = sa; }
                
                if ( action == "w")
                {
                    a.Withdraw(amount);
                }
                else { a.Deposit(amount); }


                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n");
            }

            //processEndOfMonth - interest and fees 
            sa.ApplyInterestPaymentToBalance();
            ca.SubtractFee();
            //display final account balances
            MyConsole.PrintLine("\nMonthly Payments and Fees");
            MyConsole.PrintLine($"Checking Fee: {ca.MonthlyFee.ToString("c")}");
            MyConsole.PrintLine($"Savings Interest Payment: {sa.MonthlyInterestPayment.ToString("c")}");

            MyConsole.PrintLine("\nFinal Balances");
            DisplayBalances(ca, sa);

            MyConsole.PrintLine("BYE!");
        }

        static void DisplayBalances(CheckingAccount ca, SavingsAccount sa)
        {
            MyConsole.PrintLine($"Checking: {ca.Balance.ToString("c")}");
            MyConsole.PrintLine($"Savings: {sa.Balance.ToString("c")}");
        }
    }
}
