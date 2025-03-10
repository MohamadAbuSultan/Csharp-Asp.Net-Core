// See https://aka.ms/new-console-template for more information
using GetElementsCountUsingCountAndLongCount;
using System.Collections.Generic;
using System.Linq;

var cars = CarRepository.GetCars();

var carsCount = cars.Count();
var fordCount = cars.Count(IsFord);
var fordLongCount = cars.LongCount(IsFord);
System.Console.WriteLine($"Total Ford Cars: {fordLongCount}");

static bool IsFord(Car car) => car.Manufacturer == "Ford";