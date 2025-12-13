namespace BasicSortingAlgorithms
{
    /*
     Time Complexity 
    You've implemented Bubble Sort efficiently.
    Now, let's look at the theoretical side: 
    Time Complexity.For an array of size N, 
    Bubble Sort has a Worst-Case and Average-Case
    time complexity of O(N^2).
    Because of your isSwapped optimization, 
    the Best-Case time complexity is O(N).
    This O(N^2) performance is why Bubble Sort is rarely used in production code for large datasets.
    This leads us perfectly to your next topic: Selection Sort.
     */

    // Renamed for better scope
    internal static class ArrayUtils
    {
        // 1. Removed the redundant 'length' argument.
        public static void PrintResult(int[] numbers)
        {
            // Use foreach for cleaner array iteration when printing.
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // 2. Removed the redundant 'length' argument.
        // 3. Renamed 'swapped' for better clarity.
        public static void BubbleSort(int[] numbers)
        {
            int n = numbers.Length;

            // Outer loop: controls the passes (n-1 passes are enough)
            for (int i = 0; i < n - 1; i++)
            {
                bool isSwapped = false;

                // Inner loop: performs comparisons and places the largest element
                // The '- i' ensures we don't re-check the already-sorted end elements.
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Standard, clear swap logic using a temporary variable
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        isSwapped = true;
                    }
                }

                // Optimization: If no two elements were swapped by inner loop, then array is sorted.
                if (!isSwapped)
                {
                    break;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 14, 11, 8, 9 };

            Console.WriteLine("--- Array Before Sort ---");
            ArrayUtils.PrintResult(numbers);

            // Cleaned-up call site
            ArrayUtils.BubbleSort(numbers);

            Console.WriteLine("\n--- Array After Bubble Sort ---");
            ArrayUtils.PrintResult(numbers);
        }
    }
}

//namespace Basic_Bubble_Sort_Implementation
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 7, 14, 11, 8, 9 };

//            int length = numbers.Length;

//            BubbleSort(numbers, length);
//            PrintResult(numbers, length);
//        }

//        private static void PrintResult(int[] numbers, int length)
//        {
//            for (int i = 0; i < length; i++)
//                Console.WriteLine(numbers[i]);
//        }

//        private static void BubbleSort(int[] numbers, int length)
//        {
//            for (int i = 0; i < length - 1; i++)
//            {
//                bool swapped = false;
//                for (int j = 0; j < length - i - 1; j++)
//                {
//                    if (numbers[j] > numbers[j + 1])
//                    {
//                        int temp = numbers[j];
//                        numbers[j] = numbers[j + 1];
//                        numbers[j + 1] = temp;
//                        swapped = true;
//                    }
//                }
//                if (!swapped) break;
//            }
//        }
//    }
//}
