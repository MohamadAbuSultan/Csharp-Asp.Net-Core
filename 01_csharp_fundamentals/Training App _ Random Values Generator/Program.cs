using System;
using System.Text;

enum UserOption
{
    GenerateRandomNumber = 1,
    GenerateRandomString = 2,
    Exit = 3
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Generate Random Number");
            Console.WriteLine("2. Generate Random String");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int userOp) && Enum.IsDefined(typeof(UserOption), userOp))
            {
                UserOption option = (UserOption)userOp;

                switch (option)
                {
                    case UserOption.GenerateRandomNumber:
                        GenerateRandomNumber();
                        break;
                    case UserOption.GenerateRandomString:
                        GenerateRandomString();
                        break;
                    case UserOption.Exit:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static int ReadPositiveNumber()
    {
        int number;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                return number;
            else
                Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
    static void GenerateRandomNumber()
    {
        Console.Write("Enter the minimum number: ");
        int min = ReadPositiveNumber();
        Console.Write("Enter the maximum number: ");
        int max = ReadPositiveNumber();

        if (min >= max)
        {
            Console.WriteLine("Invalid range. Minimum should be less than maximum.");
            return;
        }

        Random randNumber = new Random();
        int number = randNumber.Next(min, max + 1); // max + 1 to include the max value
        Console.WriteLine($"Random Number between {min} and {max}: {number}");
    }

    static void GenerateRandomString()
    {
        Random rand = new Random();
        // const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        StringBuilder chars = GetCharacterSet();
        if (chars.Length == 0)
        {
            Console.WriteLine("No character types selected. Cannot generate random string.");
            return;
        }
        
        Console.Write("Enter the length of the random string: ");
        int length = ReadPositiveNumber();

        StringBuilder result = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            result.Append(chars[rand.Next(chars.Length)]);
            // var randomIndex = rand.Next(0, chars.Length - 1);
            // result.Append(chars[randomIndex]);
        }

        Console.WriteLine($"Random String: {result.ToString()}");

        // char[] stringChars = new char[length];

        // for (int i = 0; i < length; i++)
        // {
        //     stringChars[i] = chars[rand.Next(chars.Length)];
        // }

        // string randomString = new string(stringChars);
        // Console.WriteLine($"Random String: {randomString}");
    }

    static StringBuilder GetCharacterSet()
    {
        StringBuilder chars = new StringBuilder();

        Console.Write("Include uppercase letters? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            chars.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        }

        Console.Write("Include lowercase letters? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            chars.Append("abcdefghijklmnopqrstuvwxyz");
        }

        Console.Write("Include digits? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            chars.Append("0123456789");
        }

        return chars;
    }
}