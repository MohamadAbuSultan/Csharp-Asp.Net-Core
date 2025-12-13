using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Messages
    {
        // static method = A method that belongs to the class itself
        //                 A static method can be called without creating an object of the class

        // class = A bundle of related code.
        //         Can be used as a blueprint to create objects (OOP)
        public static void Hello()
        {
            Console.WriteLine("Hello! Weicone to the program");
        }
        public static void Waiting()
        {
            Console.WriteLine("I an waiting for something");
        }
        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting");
        }
    }

}
