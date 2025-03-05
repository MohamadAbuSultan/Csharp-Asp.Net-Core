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

    static void GenerateRandomNumber()
    {
        Random randNumber = new Random();
        int number = randNumber.Next(1000, 9999);
        Console.WriteLine($"Random Number: {number}");
    }

    static void GenerateRandomString()
    {
        Random rand = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        int length = 16;
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
}