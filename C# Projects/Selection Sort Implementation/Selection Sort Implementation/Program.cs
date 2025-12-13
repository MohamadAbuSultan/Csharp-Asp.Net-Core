namespace SortingAlgorithms
{
    // Make the class static if it only contains static utility methods
    public static class SortUtils
    {
        // Private helper method: Abstraction for readability and correctness.
        // Takes the array and the two indices to swap.
        private static void Swap(int[] array, int indexA, int indexB)
        {
            // C# 7.0+ allows for a very concise tuple-based swap.
            // While the temp variable approach is 100% fine, this is a modern C# idiom.
            // array[indexA] = array[indexB]; // Standard temp swap:
            // array[indexB] = array[indexA]; //   int temp = array[indexA];
            // array[indexA] = array[indexB]; //   array[indexA] = array[indexB];
            //                                 //   array[indexB] = temp;

            (array[indexA], array[indexB]) = (array[indexB], array[indexA]);
        }

        public static void SelectionSort(int[] array)
        {
            int n = array.Length;

            // Outer loop: Determines the current position (i) in the sorted section
            for (int i = 0; i < n - 1; i++)
            {
                int smallestIndex = i;

                // Inner loop: Finds the smallest element in the unsorted subarray (i+1 to n-1)
                for (int j = i + 1; j < n; j++)
                {
                    // Update the index of the minimum value found so far
                    if (array[j] < array[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                // PERFORM THE SINGLE SWAP AT THE END OF THE PASS
                // Only swap if the minimum element is not already in the correct place.
                if (smallestIndex != i)
                {
                    Swap(array, i, smallestIndex);
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 10, 5, 3, 7, 19, 2, 0 };

            SortUtils.SelectionSort(data);

            Console.WriteLine("Sorted array:");
            // Clear and idiomatic C# printing
            Console.WriteLine(string.Join(", ", data));
        }
    }
}

//namespace SelectionSortImplementation
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] values = { 10, 5, 3, 7, 19, 2, 0 };
//            SelectionSort(values);
//            Console.WriteLine("Sorted array:");
//            Console.WriteLine(string.Join(", ", values));
//        }

//        private static void SelectionSort(int[] values)
//        {
//            int n = values.Length;
//            for (int i = 0; i < n - 1; i++)
//            {
//                int smallestIndex = i;
//                for (int j = i + 1; j < n; j++)
//                {
//                    if (values[j] < values[smallestIndex])
//                        smallestIndex = j;
//                }
//                int temp = values[smallestIndex];
//                values[smallestIndex] = values[i];
//                values[i] = temp;
//            }
//        }
//    }
//}
