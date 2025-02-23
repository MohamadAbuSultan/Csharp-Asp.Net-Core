namespace CSharpFundamentals
{
    internal class Syntax
    {
        static void Main2(string[] args)
        {
            Console.Title = "This is the title";
            Console.ForegroundColor = ConsoleColor.DarkBlue; // بغير لون النص
            Console.WriteLine("Hello, World!");
            Console.BackgroundColor = ConsoleColor.Yellow; // بغير خلفية النص 
            Console.WriteLine("Hello, World2!");
            Console.ForegroundColor = ConsoleColor.White; // للألوان reset هنا بنعمل 
            Console.BackgroundColor = ConsoleColor.Black; // للألوان reset هنا بنعمل 
            Console.ReadKey();
        }
    }
}