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

            // How to Create Extension Methods in C#:

            // Create a Static Class:
            // The class containing the extension method must be declared as static.

            // Define a Static Method:
            // The method itself must also be declared as static.

            // Use this Keyword for the First Parameter:
            // The first parameter of the method specifies the type being extended, and it must be prefixed with this keyword.

        }
    }
}

// The Old Way:
//  if (NumberExtension.IsBetween(percentage, 0, 100))
//      Console.WriteLine("Percentage is valid");
//  else
//      Console.WriteLine("Invalid percentage");