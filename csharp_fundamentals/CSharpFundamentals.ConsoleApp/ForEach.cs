namespace CSharpFundamentals
{
    internal class For_Each
    {
        static void Main8(string[] args)
        {
            char[] arr = { '1', '2', '3', '4' };
            foreach (char item in arr)
            {
                Console.WriteLine($"{item} {(int)item}");
            }
        }
    }
}
