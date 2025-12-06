using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product<string, int> product1 = new Product<string, int>
            {
                Name = "Laptop",
                Price = 1200
            };
            //product1.PrintProduct();
            //product1.PrintProductName("Gaming Laptop");
            //product1.PrintProductPrice(1200);

            //Console.WriteLine();

            Product<string, decimal> product2 = new Product<string, decimal>
            {
                Name = "Tablet",
                Price = 499.50M
            };
            //product2.PrintProduct();
            //product2.PrintProductName("Android Tablet");
            //product2.PrintProductPrice(499.50M);


            Printer printer = new Printer();
            //printer.Print<int>(100); // Explicitly specifying the type argument
            //printer.Print<string>("Hello, Generics!"); // 
            //printer.Print("Hello, Generics!"); // Type argument inferred by the compiler

            //IContainer<string> container = new Box<string>();
            //// The type 'string' must be a non-nullable value type in order to use it
            //// as parameter 'T' in the generic type or method 'IContainer<T>'
            //container.Add("Hello World");

            IContainer<int> container2 = new Box<int>();
            //container2.Add(42);

            CompanyEntance<Engineer> companyEntance = new CompanyEntance<Engineer>();
            companyEntance.LogToTheCompany(new Engineer());
        }
    }

    // Generic Class
    // It's a blueprint for creating classes that can work with any data type.
    public class Product<T, U>
    {
        // T - Type of Name
        // U - Type of Price
        public T Name { get; set; }
        public U Price { get; set; }

        public void PrintProduct()
        {
            Console.WriteLine($"Product Name: {Name}, Price: {Price}");
        }

        public void PrintProductName(T name) // Method with Generic Parameter
        {
            Console.WriteLine($"Product Name: {name}");
        }

        public T PrintProductPrice(U price) // Method with Generic Return Type
        {
            Console.WriteLine($"Product Price: {price}");
            return Name;
        }
    }

    public class Printer
    {
        public void Print<T>(T printVal) // Generic Method in Non-Generic Class
        {
            Console.WriteLine(printVal);
        }
    }


    //where T : class "T must be a reference type (class)" 
    public interface IContainer<T> where T : struct // Generic Interface with Constraint on Value Types
    {   // T must be a value type (struct) // T must be a non-nullable value type 
        void Add(T item);
    }

    public class Box<T> : IContainer<T> where T : struct
    {
        public void Add(T name)
        {
            Console.WriteLine(name);
        }
    }

    public interface IEmployee
    {
        public void Work();
    }

    public class Engineer : IEmployee
    {
        public void Work()
        {
            Console.WriteLine("Engineer is working.");
        }
    }
    
    public class CompanyEntance<T> where T : class, IEmployee
    {
        public void LogToTheCompany(T employee)
        {
            Console.WriteLine("logging");
        }
    }
}
