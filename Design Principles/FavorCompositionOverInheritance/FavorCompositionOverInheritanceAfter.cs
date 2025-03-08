internal class MyProgram
{
    private static void Main(string[] args)
    {
        int choice = 0;
        var pizza = new Pizza();

        do
        {
            Console.Clear();
            choice = ReadChoice(choice);
            if (choice >= 1 && choice <= 6)
            {
                ITopping topping = null;

                switch (choice)
                {
                    case 1:
                        topping = new Tomato();
                        break;
                    case 2:
                        topping = new Cheese();
                        break;
                    case 3:
                        topping = new Chicken(); // Corrected here
                        break;
                    case 4:
                        topping = new GreenOlives();
                        break;
                    case 5:
                        topping = new GreenPaper();
                        break;
                    case 6:
                        topping = new Beef();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
                pizza.AddTopping(topping);
            }
            System.Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        } while (choice != 0);

        System.Console.WriteLine(pizza);
        Console.ReadKey();
    }

    private static int ReadChoice(int choice)
    {
        Console.WriteLine("Today's Menu");
        Console.WriteLine("------------");
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Tomato");
        Console.WriteLine("2. Cheese");
        Console.WriteLine("3. Chicken"); // Corrected here
        Console.WriteLine("4. Green Olives");
        Console.WriteLine("5. Green Paper");
        Console.WriteLine("6. Beef");
        Console.WriteLine("------------");
        Console.Write("What is your order: ");

        if (int.TryParse(Console.ReadLine(), out int ch))
        {
            choice = ch;
        }

        return choice;
    }

    class Pizza
    {
        public virtual decimal Price => 10.0m;

        public List<ITopping> Toppings { get; private set; } = new List<ITopping>();

        public void AddTopping(ITopping topping) => Toppings.Add(topping);

        private decimal Calculate()
        {
            decimal total = Price;
            foreach (var topping in Toppings)
            {
                total += topping.Price;
            }
            return total;
        }

        public override string ToString()
        {
            var output = $"\n{nameof(Pizza)}";
            output += $"\n\tBase Price: ({Price.ToString("C")})";
            foreach (var topping in Toppings)
                output += $"\n\t {topping.Title} ({topping.Price.ToString("C")})";
            output += "\n-------------------";
            output += $"\nTotal: {Calculate().ToString("C")}";
            return output;
        }
    }

    public interface ITopping
    {
        string Title { get; }
        decimal Price { get; }
    }

    public class Tomato : ITopping
    {
        public string Title => nameof(Tomato);
        public decimal Price => 3.0m;
    }

    public class Chicken : ITopping // Corrected here
    {
        public string Title => nameof(Chicken); // Corrected here
        public decimal Price => 5.0m;
    }

    public class Cheese : ITopping
    {
        public string Title => nameof(Cheese);
        public decimal Price => 4.0m;
    }

    public class GreenOlives : ITopping
    {
        public string Title => nameof(GreenOlives);
        public decimal Price => 2.0m;
    }

    public class GreenPaper : ITopping
    {
        public string Title => nameof(GreenPaper);
        public decimal Price => 2.0m;
    }

    public class Beef : ITopping
    {
        public string Title => nameof(Beef);
        public decimal Price => 7.0m;
    }
}