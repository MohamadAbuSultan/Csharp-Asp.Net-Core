using System.Collections.Generic;
using System.Linq; // We'll need this for ToArray() in Main, or just use Console.WriteLine
using System;

namespace FilteringEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            int[] result = FilterEvenNumbers(numbers);

            //Using foreach is cleaner for printing the results
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n\n");

            result = FilterEvenNumbers_LINQ(numbers);

            // Using foreach is cleaner for printing the results
            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        // 1. Private: Good encapsulation (only used here)
        // 2. PascalCase: Standard C# naming convention
        private static int[] FilterEvenNumbers(int[] inputArray)
        {
            List<int> evenNumbers = new List<int>();

            // Use foreach for cleaner, index-free iteration
            foreach (var number in inputArray)
            {
                if (number % 2 == 0)
                    evenNumbers.Add(number);
            }

            return evenNumbers.ToArray();
        }

        private static int[] FilterEvenNumbers_LINQ(int[] inputArray)
        {
            // The Where() method applies the condition (like your 'if') 
            // and returns the filtered results. ToArray() materializes it.
            // This is a single, highly expressive line.
            return inputArray.Where(number => number % 2 == 0).ToArray();
        }
    }
}
