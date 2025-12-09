namespace FizzBuzz__The_Logical_Switch_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogicalSwitch.PrintNumbersFrom1to30();
        }
    }

    internal static class LogicalSwitch
    {
        public static void PrintNumbersFrom1to30()
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }

        }
    }
}
