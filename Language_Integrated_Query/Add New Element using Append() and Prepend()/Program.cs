// See https://aka.ms/new-console-template for more information
using Append_Prepend;
using System.Collections.Generic;
using System.Linq;

var cars = CarRepository.GetCars();

var newCar = new Car(28, "Chevrolet", "Camaro", "2023", "Convertible", "Gasoline", "Red", "ZD67KZP", 190);

var result = cars
        .Append(newCar)
        .Prepend(newCar);
// var result = cars.Prepend(newCar);
CarRepository.PrintCars(result);
