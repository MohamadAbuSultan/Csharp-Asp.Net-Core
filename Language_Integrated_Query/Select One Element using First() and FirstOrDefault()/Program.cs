using System;
using System.Collections.Generic;

namespace SelectOneElement 
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Car> cars = CarRepository.GetCars();

            // var result = (from car in cars
            //             select car)
            //             .First();

            // cars = [];
            // var result = cars.First(car => car.Manufacturer == "Hyundai");
            
            // cars = [];
            // var result = cars.FirstOrDefault();
            // CarRepository.PrintCars([result]);

            // DateTime[] times = {};
            // var result = times.FirstOrDefault();
            // Console.WriteLine(result);

            var defaulCar = new Car(
                "Default",
                "Default",
                "Default",
                "Default",
                "Default",
                "Default",
                "Default"
            );
            // cars = [];
            var result = cars.FirstOrDefault(car => car.Manufacturer == "Hyundai") ?? defaulCar;
            CarRepository.PrintCars([result]);
        }
    }
}