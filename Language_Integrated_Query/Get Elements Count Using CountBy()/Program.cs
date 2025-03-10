// See https://aka.ms/new-console-template for more information
using GetElementsCountUsingCountBy;
using System.Collections.Generic;
using System.Linq;

var cars = CarRepository.GetCars();

// var makesCount = cars.CountBy(c => c.Manufacturer).OrderByDescending(c => c.Value);
var makesCount = cars.CountBy(c => $"{c.Manufacturer}~{c.Color}").OrderByDescending(c => c.Value);
foreach (var make in makesCount)
{
    Console.WriteLine($"{make.Key} --> {make.Value}");
}

