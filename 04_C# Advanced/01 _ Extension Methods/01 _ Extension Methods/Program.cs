using _01___Extension_Methods;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int percentage = -10;

            if (percentage.IsBetween(0, 100))
                Console.WriteLine("Percentage is valid");
            else
                Console.WriteLine("Invalid percentage");

            Console.WriteLine("Enter value:");
            var input = Console.ReadLine();
            // method chaining
            Console.WriteLine(input.RemoveWhiteSpaces().Reverse()); // This is an example of method chaining
        }
    }
}

// The Old Way:
//  if (NumberExtension.IsBetween(percentage, 0, 100))
//      Console.WriteLine("Percentage is valid");
//  else
//      Console.WriteLine("Invalid percentage");