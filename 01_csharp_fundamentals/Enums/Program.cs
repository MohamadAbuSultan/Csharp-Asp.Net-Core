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

[Flags] // This attribute allows the enum to have multiple values
public enum WeekDays
{
    None = 0b_0000_0000, //  0
    Saturday = 0b_0000_0001, //  1
    Sunday = 0b_0000_0010, //  2
    Monday = 0b_0000_0100, //  4
    Tuesday = 0b_0000_1000, //  8
    Wednesday = 0b_0001_0000, // 16
    Thursday = 0b_0010_0000, // 32
    Friday = 0b_0100_0000  // 64 (if you need it)
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

        /* while (true)
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
        } */

        // WeekDays weekend = WeekDays.Saturday | WeekDays.Sunday | WeekDays.Friday;
        // Console.WriteLine(weekend); // Output: Saturday, Sunday, Friday

        WeekDays w1 = WeekDays.Saturday | WeekDays.Sunday | WeekDays.Monday | WeekDays.Thursday;
        WeekDays w2 = WeekDays.Saturday | WeekDays.Tuesday | WeekDays.Friday | WeekDays.Thursday;
        // System.Console.WriteLine(w1 & w2); // Output: Saturday, Thursday

        // WeekDays fridayFlag = w2 & WeekDays.Friday;
        // bool isFriday = (fridayFlag == WeekDays.Friday);
        // Console.WriteLine(isFriday); // Output: True
        // Console.WriteLine(w2 & WeekDays.Wednesday); // Output: None

        // Console.WriteLine((int)fridayFlag); // Output: 64

        // WeekDays w3 = WeekDays.Saturday | WeekDays.Sunday;
        // Console.WriteLine(w3); // Output: Saturday, Sunday

        // WeekDays weekend1 = WeekDays.Friday | WeekDays.Saturday;
        // Console.WriteLine(weekend1); // Output: Saturday, Friday

        // System.Console.WriteLine(w1); // Output: Saturday, Sunday, Monday, Thursday
        // System.Console.WriteLine(w1 & ~WeekDays.Sunday); // Saturday, Monday, Thursday
    
        WeekDays w3 = w1 ^ WeekDays.Sunday;
        WeekDays w4 = w3 ^ WeekDays.Sunday;
        Console.WriteLine(w1); // Saturday, Sunday, Monday, Thursday
        Console.WriteLine(w3); // Saturday, Monday, Thursday
        Console.WriteLine(w4); // Saturday, Sunday, Monday, Thursday
    }
}