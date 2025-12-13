namespace SortingAlgorithms
{
    // Using a static utility class for sorting methods
    public static class SortUtils
    {
        // Extracted the core logic into a reusable method.
        public static void InsertionSort(int[] array)
        {
            int n = array.Length;

            // Start from the second element (index 1), assuming index 0 is sorted
            for (int i = 1; i < n; i++)
            {
                int key = array[i]; // The element to be inserted into the sorted subarray
                int j = i - 1;       // Start comparing from the end of the sorted subarray

                // Inner loop: Shifts elements greater than the key to the right
                while (j >= 0 && array[j] > key)
                {
                    // Shift: moves the larger element one position to the right
                    array[j + 1] = array[j];
                    j--;
                }

                // Insertion: Places the key into the correct 'hole'
                // Note: j is one position less than where the key belongs
                array[j + 1] = key;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 64, 34, 25, 12, 22, 11, 90, 5 };

            // Call the dedicated function
            SortUtils.InsertionSort(data);

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", data));
        }
    }
}