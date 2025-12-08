namespace Product_Inventory_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> inventory = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200.00m },
                new Product { Name = "Mouse", Price = 99.50m },
                new Product { Name = "Keyboard", Price = 100.00m },
                new Product { Name = "Monitor", Price = 500.00m }
            };

            inventory.Add(new Product { Name = "USB-C Cable", Price = 15.00m });

            Console.WriteLine("Products over $50.00:\n");
            foreach (var item in inventory)
                if (item.Price > 50.00m)
                    // Using :C for currency formatting
                    Console.WriteLine($"- {item.Name}: {item.Price:C}");
        }
    }

    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
