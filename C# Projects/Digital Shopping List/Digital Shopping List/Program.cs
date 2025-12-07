namespace Digital_Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use descriptive name and proper casing
            List<string> shoppingList = new List<string>();
            string userInput = "";

            do
            {
                DisplayMenu();
                userInput = Console.ReadLine()?.Trim(); // Use Trim() and null-conditional operator for robustness

                if (userInput == "1")
                {
                    AddItem(shoppingList);
                }
                else if (userInput == "2")
                {
                    RemoveItem(shoppingList);
                }
                else if (userInput == "3")
                {
                    ViewList(shoppingList);
                }
                else if (userInput == "-1")
                {
                    Console.WriteLine("\nExiting application. Goodbye!");
                }
                else
                {
                    // Handle invalid input gracefully
                    Console.WriteLine("\n--- Invalid option. Please choose 1, 2, 3, or -1. ---");
                }

            } while (userInput != "-1");
        }

        // --- Helper Methods to separate concerns ---

        static void DisplayMenu()
        {
            Console.WriteLine("\n--- Choose an option ---");
            Console.WriteLine("1 - Add item");
            Console.WriteLine("2 - Remove item");
            Console.WriteLine("3 - View shopping list");
            Console.WriteLine("-1 - Exit");
            Console.Write("Your choice: ");
        }

        static void AddItem(List<string> list)
        {
            Console.Write("Enter item to add: ");
            string itemToAdd = Console.ReadLine()?.Trim();

            // Input Validation
            if (!string.IsNullOrWhiteSpace(itemToAdd))
            {
                list.Add(itemToAdd);
                Console.WriteLine($"\nSUCCESS: '{itemToAdd}' added to the list.");
            }
            else
            {
                Console.WriteLine("\nERROR: Item name cannot be empty.");
            }
        }

        static void RemoveItem(List<string> list)
        {
            Console.Write("Enter item to remove: ");
            string itemToRemove = Console.ReadLine()?.Trim();

            // Safer removal using Remove(T item)
            if (!string.IsNullOrWhiteSpace(itemToRemove))
            {
                bool wasRemoved = list.Remove(itemToRemove);

                if (wasRemoved)
                {
                    Console.WriteLine($"\nSUCCESS: '{itemToRemove}' was removed.");
                }
                else
                {
                    Console.WriteLine($"\nERROR: '{itemToRemove}' was not found in the list.");
                }
            }
            else
            {
                Console.WriteLine("\nERROR: Item name cannot be empty.");
            }
        }

        static void ViewList(List<string> list)
        {
            Console.WriteLine("\n--- Your Current Shopping List ---");

            if (list.Count == 0)
            {
                Console.WriteLine("The list is currently empty.");
            }
            else
            {
                // Print items with numbers for better readability
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }
            }
            Console.WriteLine($"Total Items: {list.Count}");
            Console.WriteLine("----------------------------------");
        }
    }
}