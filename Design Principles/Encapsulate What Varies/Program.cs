
internal class Program
{
    private static void Main(string[] args)
    {
        // what stays the same is isolated from what changes often
        // logic that keeps changing, candidate to be highly reused
        // Don't repeat yourself (DRY) principle
        // Polute the code It contains details that not important to show

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Pizza pizza = Pizza.Order(PizzaConstants.CheesePizza);
        Console.WriteLine(pizza);

        System.Console.WriteLine();
        System.Console.WriteLine();

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        pizza = Pizza.Order(PizzaConstants.MargheritaPizza);
        Console.WriteLine(pizza);

        System.Console.WriteLine();
        System.Console.WriteLine();

        Console.BackgroundColor = ConsoleColor.DarkRed;
        pizza = Pizza.Order(PizzaConstants.ChickenPizza);
        Console.WriteLine(pizza);
    }
}

class Pizza
{
    public virtual string Title => $"{nameof(Pizza)}";
    public virtual decimal Price => 10.0m;

    public static Pizza Order(string type)
    {
        Pizza pizza = Create(type);

        Prepare();
        Cook();
        Cut();

        return pizza;
    }

    private static Pizza Create(string type)
    {
        Pizza pizza;

        if (type.Equals(PizzaConstants.CheesePizza))
            pizza = new Cheese();
        else if (type.Equals(PizzaConstants.MargheritaPizza))
            pizza = new Margherita();
        else
            pizza = new Chicken();
        return pizza;
    }

    private static void Cut()
    {
        Console.Write($"Cuting the pizza...");
        Thread.Sleep(500);
        Console.WriteLine(" Completed!");
    }

    private static void Cook()
    {
        Console.Write($"Cooking the pizza...");
        Thread.Sleep(500);
        Console.WriteLine(" Completed!");
    }

    public static void Prepare()
    {
        Console.Write($"Preparing the pizza...");
        Thread.Sleep(500);
        Console.WriteLine(" Completed!");
    }

    public override string ToString()
    {
        return $"\n{Title}" +
               $"\n\tPrice: {Price.ToString("C")}";
    }
}

class Margherita : Pizza
{
    public override string Title => $"{base.Title} {nameof(Margherita)}";
    public override decimal Price => base.Price + 6.0m;
}

class Cheese : Pizza
{
    public override string Title => $"{base.Title} {nameof(Cheese)}";
    public override decimal Price => base.Price + 5.0m;
}

class Chicken : Pizza
{
    public override string Title => $"{base.Title} {nameof(Chicken)}";
    public override decimal Price => base.Price + 7.0m;
}