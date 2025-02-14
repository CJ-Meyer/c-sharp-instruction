namespace AccountBalanceCalculator.Model
{
    internal class CheckingAccount : Account{
        public decimal MonthlyFee { get; set; }
        public CheckingAccount(decimal monthlyFee)
        {
            MonthlyFee = monthlyFee;
        }
        public void SubtractFee()
        {
            Balance -= MonthlyFee;
        }
    }
}
