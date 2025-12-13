using System;
using System.Collections.Generic;

namespace Data_Transformer__Lambda_Expressions_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //Func<T1,  T2, TResult> // Result: Type of the return value (Always the last one)
            //Func<int, int, int> // Takes two ints, returns one int.
            // The last type parameter is ALWAYS the return type.

            Func<int, string> selector = x => "Value: " + (x * 2);

            var transformedList = Transform(numbers, selector);

            foreach (var item in transformedList)
            {
                Console.WriteLine(item);
            }
        }

        static List<TResult> Transform<T, TResult>(List<T> list, Func<T, TResult> selector)
        {
            List<TResult> result = new List<TResult>();

            foreach (var item in list)
            {
                var transformed = selector(item);
                result.Add(transformed);
            }

            return result;
        }
    }
}
