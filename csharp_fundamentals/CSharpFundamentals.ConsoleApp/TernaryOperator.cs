namespace CSharpFundamentals
{
    internal class Ternary_Operator
    {
        static void Main8(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                string statement = i % 2 == 0 ? $"{i} is even" : $"{i} is odd";
                Console.WriteLine(statement);
            }
        }
    }
}
