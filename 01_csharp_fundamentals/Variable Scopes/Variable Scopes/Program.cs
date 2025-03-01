namespace Variable_Scopes
{
    internal class Program
    {
        // [ Variable Scopes ]
        // Class-Level scope
        // Method-Level scope
        // Block-Level scope

        private static string _name = "Mohamad"; // CLASS SCOPE

        static void Main(string[] args)
        {
            string _name = "Khaled";
            Console.WriteLine(_name);
            Console.WriteLine(Program._name);

            //int x = 10; // Method Scope
            //Console.WriteLine(x);

            //if (true) // Block Scope
            //{
            //    int my_level = 10;
            //    Console.WriteLine(my_level);
            //}
        }

        static void MyMethod()
        {
            _name = "Ahmed";
        }

    }
}
