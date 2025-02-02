using System;

namespace MyNamespace
{
    public static class MyStaticClass
    {
        // Represents a static class with a static constructor.
        // A static class cannot be instantiated and can only contain static members.
        // Static members are shared across all instances and are accessed using the class name.
        // The static constructor is called only once, before any static members are accessed
        // or any static methods are called, and it is called automatically by the runtime.
        // Static constructors are used to initialize static data or to perform actions
        // that need to be performed only once.

        static MyStaticClass()
        {
            // Static constructor
            Console.WriteLine("Static constructor called.");
        }

        // A static method that can be called without creating an instance of the class.
        public static void DoSomething()
        {
            // Console.WriteLine("Doing something...");
        }
    }
}