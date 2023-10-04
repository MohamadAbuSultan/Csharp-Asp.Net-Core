namespace CSharpFundamentals
{
    internal class Array_Finding
    {
        static void Main(string[] args)
        {
            int number = ReadPositiveNumber();
            int[] numbers = ReadNumbers(number);
            Console.WriteLine("The Greatest Number is : " + GreatestNumber(numbers));
            Console.WriteLine($"The Smallest Number is : {SmallestNumber(numbers)}");
        }
        static int ReadPositiveNumber()
        {
            int number = 0;
            do
            {
                Console.Write("Enter A positive integer number: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 0);
            return number;
        }
        static int[] ReadNumbers(int size)
        {
            Console.WriteLine("Enter number of array : ");
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }
        static int GreatestNumber(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > result)
                    result = numbers[i];
            }
            return result;
        }
        static int SmallestNumber(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < result)
                    result = numbers[i];
            }
            return result;
        }
    }
}
