namespace Filter_Inventory__Anonymous_Methods_
{
    public delegate bool ProductFilter(Product filter);

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
        new Product { Name = "Laptop", Price = 1200.00m },
        new Product { Name = "Mouse", Price = 25.50m },
        new Product { Name = "Keyboard", Price = 80.00m },
        new Product { Name = "Monitor", Price = 300.00m }
            };


            ProductFilter filter = delegate (Product p)
            {
                return p.Price > 50.00m;
            };

            //FilterProducts(products, p => p.Price > 50.00m); // lambda 
            FilterProducts(product, filter);
        }

        private static void FilterProducts(List<Product> product, ProductFilter filter)
        {
            foreach (var item in product)
            {
                if (filter(item))
                    Console.WriteLine($"Product: {item.Name}, Price: ${item.Price}");
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
