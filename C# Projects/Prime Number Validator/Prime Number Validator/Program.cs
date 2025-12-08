namespace Prime_Number_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = PrimeNumberValidator.IsPrime(7);
            Console.WriteLine(isPrime);
        }
    }

    internal static class PrimeNumberValidator
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            
            return true;
        }
    }
}
