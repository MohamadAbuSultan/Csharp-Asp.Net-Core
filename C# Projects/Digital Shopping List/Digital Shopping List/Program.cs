namespace Digital_Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> digitalShopping = new List<string>();

            string input = "";

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Add item");
                Console.WriteLine("2 - Remove item");
                Console.WriteLine("3 - View shopping list");
                Console.WriteLine("-1 - Exit");

                input = Console.ReadLine();

                if(input == "1")
                {
                    Console.WriteLine("Enter item to add:");
                    input = Console.ReadLine();
                    digitalShopping.Add(input);
                }
                else if(input == "2")
                {
                    Console.WriteLine("Enter item to remove:");
                    input = Console.ReadLine();
                    int index = digitalShopping.IndexOf(input);
                    digitalShopping.RemoveAt(index);
                }
                else if (input == "3")
                {
                    Console.WriteLine("Your shopping list:");
                    foreach (var item in digitalShopping)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if(input == "-1")
                {
                    Console.WriteLine("you choose to exit.");
                    break;
                }
            } while (input != "-1");
        }
    }
}
