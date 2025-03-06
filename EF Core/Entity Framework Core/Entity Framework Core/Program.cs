using Entity_Framework_Core.Data;
using Entity_Framework_Core.Model;

using ContosoPizzaContext context = new ContosoPizzaContext();

var veggieSpecial = context.Products
                    .Where(p => p.Name == "Veggie Special Pizza")
                    .FirstOrDefault();

if (veggieSpecial is Product)
{
    context.Remove(veggieSpecial);
    //veggieSpecial.Price = 10.99M;
}

context.SaveChanges();

//var products = context.Products
//                    .Where(product => product.Price > 10.00M)
//                    .OrderBy(product => product.Name);

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;

foreach (Product product in products)
{
    Console.WriteLine($"Id: {product.Id}");
    Console.WriteLine($"Name: {product.Name}");
    Console.WriteLine($"Price: {product.Price}");
    Console.WriteLine(new string('-', 20));
}

//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};
//context.Products.Add(veggieSpecial);

//Product deluxeMeat = new Product()
//{
//    Name = "Deluxe Meat Pizza",
//    Price = 12.99M
//};
//context.Add(deluxeMeat);

//context.SaveChanges();
