// See https://aka.ms/new-console-template for more information
using Any_All;
using System.Collections.Generic;
using System.Linq;

var cars = CarRepository.GetCars();

// cars = [];
// var result = cars.Any();
// Console.WriteLine(result ? "There are cars in the collection" : "There are no cars in the collection");

// var result = cars.Any(car => car.Manufacturer == "Hyundai");
// Console.WriteLine($"Any Hyundai cars: {result}");

var result = cars.All(car => car.MaxSpeed > 200);
Console.WriteLine($"All cars have a max speed greater than 200: {result}");