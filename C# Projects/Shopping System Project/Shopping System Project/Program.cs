namespace Shopping_System_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            do
            {
                Console.WriteLine("1. Add Item to Cart");
                Console.WriteLine("2. View Cart");
                Console.WriteLine("3. Remove Item from Cart");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Undo Last Action");
                Console.WriteLine("6. Exit");
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        shoppingList.Add(Console.ReadLine());
                        break;
                    case 2:
                        shoppingList.
                        break;
                    case 3:
                        shoppingList.Remove(Console.ReadLine());
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;

                }
            } while (true);
        }
    }
}
