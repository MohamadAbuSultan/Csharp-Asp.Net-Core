using System;

class Program
{
    static void Main(string[] args)
    {
        /* Exceptions:

            Compile-Time Errors:
            - Occur during code compilation.
            - Examples: Syntax errors, type mismatches.
            - Detected by the compiler, must be fixed to compile the program.
            - Ex: int number = "test"; // Error: Cannot implicitly convert type 'string' to 'int'

            Runtime Errors:
            - Occur during program execution.
            - Examples: Null reference, divide by zero.
            - Detected while running, handled using try-catch blocks or robust code.
            - Ex: 
            int number = 10;
            int divisor = 0;
            int result = number / divisor; // Error: DivideByZeroException
        
        */

        try
        {
            // int result = Divide(10, 0); // This will cause a DivideByZeroException
            int result = Divide(10, 2);
            Console.WriteLine(result);
            int result2 = Divide(10, 5);
            Console.WriteLine(result2);
            // int.Parse("test"); // This will cause a FormatException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Custom exception handler for DivideByZeroException");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("This block will always run.");
        }

        try
        {
            Console.Write("Please enter a five characters string: ");
            var input = Console.ReadLine();
            if (input.Length != 5)
                throw new Exception("String must be 5 characters long");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

    static int Divide(int number, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Divisor cannot be zero.");
        }
        return number / divisor;
    }
}
