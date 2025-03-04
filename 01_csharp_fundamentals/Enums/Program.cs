using System;

public enum Gender // Simple Enum
{
    Male = 1,
    Female
}

public enum Color
{
    Red = 1,
    Green,
    Blue,
    Yellow,
    Black,
    White,
    Purple,
    Pink,
    Brown,
    Orange
}
public class Program
{
    static void Main(string[] args)
    {
        // Gender gender = Gender.Female;
        // Console.WriteLine($"Selected gender: {gender/*.ToString()*/}, value: {(int)gender}");

        // foreach(var color in Enum.GetValues(typeof(Color)))
        // {
        //     Console.WriteLine($"{color} = {(int)color}");
        // }

        // foreach(var color in Enum.GetNames(typeof(Color)))
        // {
        //     Console.WriteLine($"{color} = {(int)Enum.Parse(typeof(Color), color)}");
        // }

        // string colorName = "red";
        // Color color2 = (Color)Enum.Parse(typeof(Color), colorName, true);
        // Console.WriteLine($"{color2} = {(int)color2}");

        // Console.BackgroundColor = ConsoleColor.DarkGreen;
        // Console.ForegroundColor = ConsoleColor.White;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("[1] Change Background Color\t\t[2] Change Foreground Color");
            string selectedOption = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Available colors: ");
            foreach (var color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.WriteLine($"{color}");
            }
            Console.Write("Please write color name: ");
            string colorName = Console.ReadLine();
            Console.Clear();
            ConsoleColor selectedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true);

            if (selectedOption == "1")
            {
                Console.BackgroundColor = selectedColor;
                Console.Clear(); // Clear the console to apply the background color change
                Console.WriteLine("Background color changed.");
            }
            else if (selectedOption == "2")
            {
                Console.ForegroundColor = selectedColor;
                Console.WriteLine("Foreground color changed.");
            }
            else
            {
                Console.WriteLine("Invalid Option!");
            }

            // Add a pause to see the changes before the loop restarts
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}