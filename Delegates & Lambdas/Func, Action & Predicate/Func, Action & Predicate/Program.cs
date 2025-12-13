using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Func__Action___Predicate
{

    // Summary of Delegates:

    // Func<T1, T2, ..., TResult>: Used for methods that return a value(TResult).
    // It can take from 0 up to 16 input parameters.
    // The last type parameter is always the return type.

    // Action<T1, T2, ...>: Used for methods that do not return a value (void).
    // It can take from 0 up to 16 input parameters.

    // Predicate<T>: A specialized Func<T, bool> that always returns a boolean and takes
    // exactly one input parameter of type T.
   
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * public delegate TResult
             * Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2)
             * 
             * 
             * public delegate TResult
             * Func<in T, out TResult>(T arg)
             * 
             * 
             * public delegate TResult
             * Func<out TResult>()
            */

            Func<int, int, int> del1 = Add;

            Console.WriteLine(del1(5, 10));

            Func<int, int, string> del2 = Concate;
            Console.WriteLine(del2(5, 10));

            //public delegate void Action<in T>(T obj) where T : allows ref struct;

            Action<double> del3 = PrintX;
            del3(11.3);

            Action<string, string> del4 = PrintXY;
            del4("5.96", "6.95");


            Predicate<int> del5 = IsEven;
            Console.WriteLine(del5(4));
        }

        private static bool IsEven(int input)
        {
            return input % 2 == 0;
        }

        private static void PrintX(double obj) => Console.WriteLine(obj);
        private static void PrintXY(string x, string y) => Console.WriteLine($"{x} + {y}");


        private static int Add(int arg1, int arg2) => arg1 + arg2;
        private static string Concate(int in1, int in2) => $"{in1} + {in2} = {in1 + in2}";
    }
}
