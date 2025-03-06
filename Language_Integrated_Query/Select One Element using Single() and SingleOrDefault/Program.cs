// See https://aka.ms/new-console-template for more information
using SelectOneElement;

var cars = CarRepository.GetCars();
var defaultCar = 
    new Car("Default", "Default", "Default", "Default", "Default", "Default", "Default");
// cars = [defaultCar];
cars = [];
// var result = cars.Single();
// var result = cars.Single(car => car.VRM == "ZD20KEK");
var result = cars.SingleOrDefault() ?? defaultCar;

CarRepository.PrintCars(new List<Car> { result });
// CarRepository.PrintCars([result]);