using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Simple_Delegate_Calculator
{
    delegate int MathOperation(int num1, int num2);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Think of the delegate as the contract
            // and the methods (Add, Sub) as the workers.
            //The contract(MathOperation) specifies the required input(two integers)
            //and output(one integer).
            //Any worker(Add, Sub) that signs the contract can be pointed
            //to by the mathOp variable.

            //MathOperation mathOp = new MathOperation(Add);
            MathOperation mathOp = Add; // Modern C# Shorthand
            Console.WriteLine(mathOp(10, 20));
            //mathOp.Invoke(10, 20);

            mathOp = new MathOperation(Sub);
            Console.WriteLine(mathOp(10, 20));
        }

        static int Add(int num1, int num2) => num1 + num2;
        static int Sub(int num1, int num2) => num1 - num2;
    }
}
