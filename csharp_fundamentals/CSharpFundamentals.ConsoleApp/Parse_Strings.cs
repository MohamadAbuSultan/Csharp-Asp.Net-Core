namespace CSharpFundamentals
{
    internal class Parse_Strings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year: ");
            string year = Console.ReadLine();
            int Year = int.Parse(year);
            double Year2 = double.Parse(year);
            Console.WriteLine($"Your age : {2023 - Year}");
            Console.WriteLine($"Your age : {2023 - Year2}");
        }
    }
}
