// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int choice = 0;
//         do
//         {
//             Console.Clear();
//             choice = ReadChoice();
//             if (choice >= 1 && choice <= 3)
//             {
//                 var pizza = CreatePizza(choice);
//                 Console.WriteLine(pizza);
//             }
//             Console.WriteLine("Press any key to continue");
//             Console.ReadKey();
//         } while (choice != 8);
//     }


//     private static Pizza CreatePizza(int choice)
//     {
//         Pizza pizza = null;

//         switch (choice)
//         {
//             case 1:
//                 pizza = new Chicken();
//                 break;
//             case 2:
//                 pizza = new Cheese();
//                 break;
//             case 3:
//                 pizza = new Margherita();
//                 break;
//             default:
//                 Console.WriteLine("Invalid choice, please try again.");
//                 break;
//         }

//         return pizza;
//     }

//     static int ReadChoice()
//     {
//         Console.WriteLine("Enter your choice (1-3 or 8 to exit): ");
//         return int.TryParse(Console.ReadLine(), out int choice) ? choice : 0;
//     }

//     private static Pizza Create(string type)
//     {
//         Pizza pizza;

//         if (type.Equals(PizzaConstants.CheesePizza))
//             pizza = new Cheese();
//         else if (type.Equals(PizzaConstants.MargheritaPizza))
//             pizza = new Margherita();
//         else
//             pizza = new Chicken();
//         return pizza;
//     }
//     // public static Pizza Order(string type)
//     // {
//     //     Pizza pizza = Create(type);

//     //     return pizza;
//     // }
//     class Pizza
//     {
//         public virtual string Title => $"{nameof(Pizza)}";
//         public virtual decimal Price => 10.0m;

//         public override string ToString()
//         {
//             return $"\n{Title}" +
//                    $"\n\tPrice: {Price.ToString("C")}";
//         }
//     }

//     class Margherita : Pizza
//     {
//         public override string Title => $"{base.Title} {nameof(Margherita)}";
//         public override decimal Price => base.Price + 6.0m;
//     }

//     class Cheese : Pizza
//     {
//         public override string Title => $"{base.Title} {nameof(Cheese)}";
//         public override decimal Price => base.Price + 5.0m;
//     }

//     class Chicken : Pizza
//     {
//         public override string Title => $"{base.Title} {nameof(Chicken)}";
//         public override decimal Price => base.Price + 7.0m;
//     }
// }