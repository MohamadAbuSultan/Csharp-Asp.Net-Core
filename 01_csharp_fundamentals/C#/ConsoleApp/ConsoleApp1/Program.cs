// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using Pastel;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!".Pastel(Color.Red));

        var product = new Product("Sample Product", 19.99m, new List<string> { "Tag1", "Tag2" });
        Console.WriteLine(product.ToString());

        string newJson = JsonConvert.SerializeObject(product, Formatting.Indented);
        Console.WriteLine(newJson);
    }
}
