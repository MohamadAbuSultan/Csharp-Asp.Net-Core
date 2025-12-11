namespace Simple_Account_Class__OOP___Encapsulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(1000);
            Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

            if (account.Withdraw(500))
                Console.WriteLine($"Withdrawal successful. Balance: {account.GetBalance()}");
            else
                Console.WriteLine("Withdrawal failed. Insufficient funds.");

            if (account.Withdraw(600))
                Console.WriteLine($"Withdrawal successful. Balance: {account.GetBalance()}");
            else
                Console.WriteLine("Withdrawal failed. Insufficient funds.");
        }
    }

    internal class BankAccount
    {
        private decimal _balance;

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return false;
            }

            if (_balance >= amount)
            {
                _balance -= amount;
                return true;
            }

            return false;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
