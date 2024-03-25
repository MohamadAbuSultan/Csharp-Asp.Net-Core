namespace CSharpFundamentals
{
    internal class String_SplitJoin
    {
        /*
         * string.Split بتاخذ سترينق بتقطعه وبتحوله ل أرري أوف سترينق
         * string.Join بتاخذ أرري وبتحولها لسترينق واحد على بعضه
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter list of numbers separated by Comma(,):");
            string input = Console.ReadLine();
            string[] numbers = input.Split(",");
            int sum = 0;
            foreach (string number in numbers)
                sum += int.Parse(number);
            Console.WriteLine("Average = " + sum / numbers.Length);
            string[] words = { "Hello", "Passionate", "Coders", "World" };
            string statement = string.Join(" ! ", words);
            Console.WriteLine(statement);
        }
    }
}