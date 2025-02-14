namespace AccountBalanceCalculator.Model
{
    internal class SavingsAccount : Account
    {
        public decimal MonthlyInterestRate { get; set; }
        public decimal MonthlyInterestPayment { get; set; }
        public SavingsAccount(decimal monthlyInterestRate)
        {
            MonthlyInterestRate = monthlyInterestRate;
        }
        public void ApplyInterestPaymentToBalance()
        {
            MonthlyInterestPayment = Balance * MonthlyInterestRate;
            Balance += MonthlyInterestPayment;
        }
    }
}
