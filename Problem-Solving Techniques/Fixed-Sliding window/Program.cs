using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 17, 11, 40, 18, 51, 24, 29, 36, 12, 45 };
        int windowsize = 3;

        int maxSum = MaxSumwithBruteForce(numbers, windowsize);
        // Console.WriteLine("Maximum sum of subarrays of size " + windowsize + " is " + maxSum);

        // int maxSum = MaxSumwithFixedSlidingWindow(numbers, windowsize);
        // Console.WriteLine("Maximum sum of subarrays of size " + windowsize + " is " + maxSum);

        var randomOneMillionhumber = Enumerable.Range(1, 1_000_000).OrderBy(_ => Random.Shared.Next()).ToArray();
        var newWindowSize = 30000;

        var randomOneThousandNumbers = Enumerable.Range(1, 1000).OrderBy(_ => Random.Shared.Next()).ToArray();
        var newSmallWindowSize = 100;

        int maxSum2 = MaxSumwithBruteForce(randomOneThousandNumbers, newSmallWindowSize);
        Console.WriteLine("Maximum sum of subarrays of size " + newSmallWindowSize + " is " + maxSum2);

        // int maxSum = MaxSumwithFixedSlidingWindow(randomOneMillionhumber, newWindowSize);
        // Console.WriteLine("Maximum sum of subarrays of size " + newWindowSize + " is " + maxSum2);

        var randomOneMillionNumbers = Enumerable.Range(1, 1_000_000).OrderBy(_ => Random.Shared.Next()).ToArray();
        // var newWindowSize = 30000;

        // Using Brute Force to find the maximum sum of subarrays of size 30000
        int maxSum3 = MaxSumwithBruteForce(randomOneMillionNumbers, newWindowSize);
        Console.WriteLine("Maximum sum of subarrays of size " + newWindowSize + " is " + maxSum3);
        // Note: This code takes a very long time to print the results due to O(n²) time complexity
    }

    static int MaxSumwithFixedSlidingWindow(int[] source, int windowsize)
    {
        int maxSum = 0, windowSum = 0;

        for (int i = 0; i < windowsize; i++)
            windowSum += source[i];

        maxSum = windowSum;

        for (int i = windowsize; i < source.Length; i++)
        {
            windowSum += source[i] - source[i - windowsize];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum;
    }

    static int MaxSumwithBruteForce(int[] source, int windowsize)
    {
        int maxSum = int.MinValue;

        for (int i = 0; i <= source.Length - windowsize; i++)
        {
            // int currentSum = 0;

            // for (int j = 0; j < windowsize; j++)
            // {
            //     currentSum += source[i + j];
            // }
            // if (currentSum > maxSum)
            // {
            //     maxSum = currentSum;
            // }

            int windowSum = 0;

            for (int j = i; j < i + windowsize; j++)
                windowSum += source[j];

            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum;
    }
}
