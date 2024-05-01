namespace CSharpFundamentals
{
    internal class Compilation_Proccess
    {
        /*
            the compilation process in C# involves the following steps:

            1- Lexical analysis: The source code is broken down into tokens.

            2- Syntax analysis: The tokens are analyzed to check for any syntax errors.

            3- Semantic analysis: The code is analyzed to check for any semantic errors.

            4- Code generation: The compiler generates an intermediate language code (IL or MSIL).

            5- Optimization: The IL code is optimized to improve performance.

            6- Execution: The IL code is executed by the .NET runtime
               which JIT compiles it into machine code specific to the platform it is running on
        . */
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            Student ahmed = new Student();

            //Console.WriteLine("Enter The Student Name: ");
            //ahmed.Name = Console.ReadLine();
            //Console.WriteLine(ahmed.Name);

            //Console.WriteLine("Enter The Student Address: ");
            //ahmed.Address = Console.ReadLine();
            //Console.WriteLine(ahmed.Address);

            //Console.WriteLine("Enter The Student Phone Number: ");
            //ahmed.PhoneNumber = Console.ReadLine();
            //Console.WriteLine(ahmed.PhoneNumber);

            //students[0] = ahmed;
        }
    }
}
