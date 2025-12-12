namespace Simple_Account_Class__OOP___Encapsulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(1000);
            Console.WriteLine($"Balance after deposit: {account.Balance}");

            if (account.Withdraw(500))
                Console.WriteLine($"Withdrawal successful. Balance: {account.Balance}");
            else
                Console.WriteLine("Withdrawal failed. Insufficient funds.");

            if (account.Withdraw(600))
                Console.WriteLine($"Withdrawal successful. Balance: {account.Balance}");
            else
                Console.WriteLine("Withdrawal failed. Insufficient funds.");
        }
    }

    internal class BankAccount
    {
        private decimal _balance;

        // 1. Constructor to set initial state
        public BankAccount(decimal initialBalance = 0.00m)
        {
            // Simple validation is often done here
            if (initialBalance < 0) throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative.");
            _balance = initialBalance;
        }

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

        // 2. Read-Only Property for getting the balance
        // The '=>' syntax is a concise C# way to return a value
        public decimal Balance => _balance; // Calling account.Balance returns _balance

        //public decimal GetBalance()
        //{
        //    return _balance;
        //}
    }
}
