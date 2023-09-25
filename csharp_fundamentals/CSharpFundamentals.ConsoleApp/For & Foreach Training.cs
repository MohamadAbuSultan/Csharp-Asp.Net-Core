namespace CSharpFundamentals
{
    internal class For_Foreach_Training
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter Number of the array : ");
            //int number = int.Parse(Console.ReadLine());
            //int[] arr = new int[number];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter array item of {i + 1} : ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int[] reversedArray = new int[number];
            //for (int i = number - 1; i >= 0; i--)
            //{
            //    reversedArray[number - i - 1] = arr[i];
            //}
            //foreach (int i in reversedArray)
            //{
            //    Console.WriteLine(i);
            //}

            Console.Write("Enter number of array : ");
            int result = 0;
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach (int n in numbers)
            {
                result += n;
            }
            double avg = result / number;
            Console.WriteLine($"sum of numbers : {result}");
            Console.WriteLine($"average of numbers : {avg}");
        }
    }
}
