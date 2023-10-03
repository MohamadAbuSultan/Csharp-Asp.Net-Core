namespace CSharpFundamentals
{
    internal class Methods
    {
        static void Main9(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //CalculateAverage(numbers);
            //numbers = new int[] { 10, 20, 30, 40, 50 };
            //CalculateAverage(numbers);
            int[] numbers = { 1, 2, 3, 4, 5 };
            CalculateAverage1(numbers, printAverageToConsole: true);
            numbers = new int[] { 10, 20, 30, 40, 50 };
            CalculateAverage1(numbers, printSumToConsole: true);

            CalculateAverage1(numbers);
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
            return; // عادي لو كتبتها في الدالة إلي ما بترجع قيمة ، بنكتبها عشان يتجاهل السطور إلي بعدها
        }



        // optional arguments لازم يكون آخر إشي تضيفه
        /// to document any method
        /// <summary>
        /// Calculate the average for an array of numbers 
        /// </summary>
        /// <param name="numbers">the array to calculate its average</param>
        /// <param name="printAverageToConsole">determine whether print average nor not</param>
        /// <param name="printSumToConsole">determine whether print sum nor not</param>
        /// <returns></returns> 
        static double CalculateAverage1(int[] numbers, bool printAverageToConsole = false /*this is optional arguments*/, bool printSumToConsole = false)
        {
            int number = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                number += numbers[i];
            }
            double average = number / numbers.Length;
            if (printSumToConsole == true) Console.WriteLine("Sum is : " + number);
            if (printAverageToConsole == true) Console.WriteLine($"average is : {average}");
            return average;
        }
    }
}
