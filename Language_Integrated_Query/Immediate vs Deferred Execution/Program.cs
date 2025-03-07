// See https://aka.ms/new-console-template for more information
using Immediate_vs_Deferred_Execution;
using System.Collections.Generic;
using System.Linq;

var cars = CarRepository.GetCars();

// Deferred Execution
// Deferred Execution: Query execution is delayed until the query is iterated over. 
// Methods like Where, Select, and OrderBy use deferred execution.
var deferredResult = cars.Where(IsVolvo);
// var deferredSelectResult = cars.Select(car => car.Manufacturer);

// Immediate Execution
// Immediate Execution: Query execution happens immediately and results are obtained right away. 
// Methods like ToList, ToArray, Count, First, and Single use immediate execution.
var immediateResult = cars.Where(IsVolvo).ToList();
// var immediateCount = cars.Count(IsVolvo);

foreach (var car in deferredResult)
    Console.WriteLine($"Deferred Execution - Car: {car.Manufacturer} ~ {car.Model} ~ {car.VRM}");

// foreach (var manufacturer in deferredSelectResult)
//     Console.WriteLine($"Deferred Execution - Manufacturer: {manufacturer}");

foreach (var car in immediateResult)
    Console.WriteLine($"Immediate Execution - Car: {car.Manufacturer} ~ {car.Model} ~ {car.VRM}");

// Console.WriteLine($"Immediate Execution - Count of Volvos: {immediateCount}");

bool IsVolvo(Car car) => car.Manufacturer == "Hyundai";