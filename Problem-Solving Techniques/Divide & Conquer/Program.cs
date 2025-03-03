using System;

class Program
{
    static int ContainsIterative(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid; // Target found
            else if (arr[mid] < target)
                left = mid + 1; // Target is in the right half
            else
                right = mid - 1; // Target is in the left half
        }

        return -1; // Target not found
    }

    static int ContainsRecursion(int[] arr, int target, int left, int right)
    {
        if (left > right)
            return -1; // Target not found

        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            return mid; // Target found
        else if (arr[mid] < target)
            return ContainsRecursion(arr, target, mid + 1, right); // Target is in the right half
        else
            return ContainsRecursion(arr, target, left, mid - 1); // Target is in the left half
    }

    static void Main()
    {
        int[] numbers = { 2, 7, 8, 18, 20, 24, 29, 33, 36, 40, 45, 51, 53, 60, 65, 69, 77, 81, 85, 91, 97 };
        int target = 65;
        int target2 = 66;

        int result = ContainsIterative(numbers, target);
        int result2 = ContainsRecursion(numbers, target2, 0, numbers.Length - 1);

        Console.WriteLine(result != -1 ? "Target found at index " + (result + 1) : "Target not found");
        Console.WriteLine(result2 != -1 ? "Target2 found at index " + (result2 + 1) : "Target2 not found");
    }
}
