// See https://aka.ms/new-console-template for more information
using Data_Ordering;
using System.Collections.Generic;
using System.Linq;

var cars = CarRepository.GetCars();

// var result =
//     from car in cars
//     orderby car.ID descending
//     select car;

// var result = cars.OrderBy(car => car.Manufacturer);
// var result = cars.OrderByDescending(car => car.ID);

// var result =
//     from c in cars
//     orderby c.Manufacturer, c.Model, c.MaxSpeed descending
//     select c;

// var result = cars
//     .OrderBy(c => c.Manufacturer)
// .ThenBy(c => c.Model)
//     .ThenByDescending(c => c.MaxSpeed);

// var result = cars.Order(); // System.ArgumentException
// CarRepository.PrintCars(result);

// int[] numbers = { 1, 10, 3, 4, 5, 6, 7, 8, 9, 2 };
// string[] names = { "Mohammad", "Ali", "Reza", "Hassan", "Mehdi", "Sara", "Maryam", "Zahra", "Narges", "Fatemeh" };
// var result = numbers.Order();

// DateOnly[] dates = [
//     new DateOnly(2002, 1, 3),
//     new DateOnly(2008, 1, 1),
//     new DateOnly(2023, 1, 1),
//     new DateOnly(1997, 1, 1)
// ];

// var result = dates.Order();
// var result = dates.OrderDescending();

// foreach (var date in result)
// {
//     Console.WriteLine(date);
// }

// var result = cars.Order(new CarComparer()); 
var result = cars.OrderDescending(new CarComparer()); 
CarRepository.PrintCars(result);