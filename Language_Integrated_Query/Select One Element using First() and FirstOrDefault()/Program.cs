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
            var result = cars.First(car => car.Manufacturer == "Hyundai");
            CarRepository.PrintCars([result]);
        }
    }
}