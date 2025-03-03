using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please enter a number: ");

        // Declare the variable before using it in TryParse
        // int num;

        var isSuccessful = int.TryParse(Console.ReadLine(), out int num);
        Console.WriteLine($"Is number? = {isSuccessful}");
        Console.WriteLine($"num = {num}");

        // The ref parameter needs to be initialized.
        TestRef();

        // The out parameter must be assigned before the method returns.
        TestOut();
    }

    private static void TestOut()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Testing Out");
        double number = 10;
        double divisor = 0;
        bool isSuccessful = false;

        double result = DivideOut(number, divisor, out isSuccessful);

        Console.WriteLine(isSuccessful ? $"Division successful: {result}" : "Division failed.");
    }

    static void TestRef()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Testing Ref");
        double number = 10;
        double divisor = 0;
        bool isSuccessful = false;

        double result = Divide(number, divisor, ref isSuccessful);

        Console.WriteLine(isSuccessful ? $"Division successful: {result}" : "Division failed.");
    }

    // The out parameter must be assigned before the method returns.
    static double DivideOut(double number, double divisor, out bool isSuccessful)
    {
        if (divisor == 0)
        {
            Console.WriteLine("Can't divide by zero!");
            isSuccessful = false;
            return 0;
        }

        isSuccessful = true;
        return number / divisor;
    }

    // The ref parameter needs to be initialized before being passed to the method.
    static double Divide(double number, double divisor, ref bool isSuccessful)
    {
        if (divisor == 0)
        {
            Console.WriteLine("Can't divide by zero!");
            isSuccessful = false;
            return 0;
        }

        isSuccessful = true;
        return number / divisor;
    }
}