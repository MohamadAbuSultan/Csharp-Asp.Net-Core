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

var result = cars
    .OrderBy(c => c.Manufacturer)
    // .ThenBy(c => c.Model)
    .ThenByDescending(c => c.MaxSpeed);

CarRepository.PrintCars(result);