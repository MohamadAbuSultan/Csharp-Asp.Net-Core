using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    public static class ExtensionFunctional
    {
        public static IEnumerable<Employee> Filter
            (IEnumerable<Employee> source, Func<Employee, bool> predicate) // Func<Employee, bool> predicate = Predicate<Employee> predicate
        {
            foreach (var employee in source)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }

        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null)
            {
                return;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"| {title.PadRight(52, ' ')} |");
            Console.WriteLine("----------------------------------------------------");

            foreach (var item in source)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------------");
        }
    }
}