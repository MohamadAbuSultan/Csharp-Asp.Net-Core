namespace CSharpFundamentals
{
    internal class If_Statement
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            string number = Console.ReadLine();
            int parsedNumber = int.Parse(number);
            int reminder = parsedNumber % 2;
            if (reminder == 1)
            {
                Console.WriteLine($"{parsedNumber} is odd");
            }
            else if (parsedNumber == 0)
            {
                Console.WriteLine("Zero neither odd nor even");
            }
            else
            {
                Console.WriteLine($"{parsedNumber} is even");
            }
        }
    }
}
