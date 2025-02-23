using System;
using System.Collections.Generic;

namespace PureVsImpureFunction
{
    class Program
    {
        static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        static void Main(string[] args)
        {
            // statement vs expression
            /* 1. Statement : 
             * A statement can consist of a single line of code that ends in a semicolon,
             * or a series of single-line statements in a block. A statement block is enclosed in { } brackets 
             * and can contain nested blocks. The following code shows two examples of single-line statements,
             * and a multi - line statement block 
             * statement أي سطر بينتهي بفاصلة منقوطة يسمى 
             */
            // Declaration statement.
            int counter;

            // Assignment statement.
            counter = 1;

            // Declare and initialize
            const double pi = 3.14159;

            // foreach statement and if & ifelse , switch , jump , do , while 
            foreach (var item in new int[] { 1, 2, 3 }) { }

            // 2. Expression : An expression is a sequence of operators and operands that yield a value
            var radius = 10;
            var area = 3.14 * (radius * radius); // expression 3.14 * (radius * radius) yield a value
                                                 // وهذا أول نوع من الإكسبرشن

            // method invocation (this method yield void) هذا النوع الثاني من الإكسبرشن
            // Console.WriteLine(area); // WriteLine return void 

            // new object creation هاي كمان تعتبر إكسبرشن
            var names = new string[] { "ali", "ahmed", "reem" };

            // Side Effect: عمل آثار جانبية
            //  A side effect is a change in the state of a system or program that is caused by a function or operation and is external to the function's intended result.

            // Pure Function: 
            // - A pure function is a function that always produces the same output for the same input and has no side effects.
            // - The output of a pure function depends solely on its input parameters, and it does not modify any external state or global variables.
            // - Pure functions are deterministic (given the same inputs, they will always produce the same output).
            // - Pure function are eazy to test because they don't have side effect
            // - Pure function mutate(change) just local variables

            // Impure Function: 
            // - An impure function is a function that may have side effects or produce different outputs for the same input under certain conditions.
            // - Impure functions can modify external state, mutate variables, perform I/O operations, or have non-deterministic behavior.
            // - Impure functions are often harder to predict, test, and debug due to their potential interactions with external factors.

            Console.WriteLine("old list");
            Print(numbers);
            var newList = AddInteger4(numbers, 3);
            Console.WriteLine("new list");
            Print(newList);

            // Console.ReadKey();
        }

        static void Print(List<int> source)
        {
            foreach (var item in source)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }

        static void AddInteger1(int num)
        {
            numbers.Add(num); // impure mutate global variable
                              // impure : pure function يعتبر إعتبار لل global variable أي عملية تغيير (إضافة سحب حذف) أو أي تعديل على 
        }

        static void AddInteger2(ref int num)
        {
            num++; // impure mutate parameter
            numbers.Add(num); // ref التعديل هيكون دائم عشان
        }

        static void AddInteger3()
        {
            numbers.Add(new Random().Next()); // impure interation with outside world
                                              // impure مع أي إشي خارج نطاق الفنكشن هيكون interaction أي 
        }

        static List<int> AddInteger4(List<int> numbers, int num)
        {
            var result = new List<int>(numbers); // 
            result.Add(num);
            return result;
        }
    }
}
