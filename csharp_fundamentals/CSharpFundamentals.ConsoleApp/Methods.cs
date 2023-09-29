namespace CSharpFundamentals
{
    internal class Methods
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            CalculateAverage(numbers);
            numbers = new int[] { 10, 20, 30, 40, 50 };
            CalculateAverage(numbers);
        }
        static void CalculateAverage(int[] numbers)
        {
            int number = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                number += numbers[i];
            }
            double avg = number / numbers.Length;
            Console.WriteLine(avg);
        }
    }
}
