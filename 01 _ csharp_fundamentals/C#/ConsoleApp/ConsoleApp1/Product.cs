using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<string> Tags { get; set; }

    public Product(string name, decimal price, List<string> tags)
    {
        Name = name;
        Price = price;
        Tags = tags;
    }

    public override string ToString()
    {
        return $"Product: {Name}, Price: {Price:C}, Tags: {string.Join(", ", Tags)}";
    }
}