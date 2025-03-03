using System;
using System.Collections.Generic;

namespace YouTubeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Car> cars = CarRepository.GetCars();

            // var result =
            //     from car in cars
            //     where car.Manufacturer == "Ford" 
            //         && (car.Color == "turquoise" || car.Color == "green")
            //         && car.VRM == "LL61IAC"
            //     where car.Model == "Impala"
            //     select car;

            // var result = cars.Where(
            //     car => car.Manufacturer == "Ford" 
            //     && (car.Color == "turquoise" || car.Color == "green")
            //     && car.VRM == "LL61IAC");
            // CarRepository.PrintCars(result);

            var result = 
                from car in cars
                where IsFord(car)
                select car;
                
            // var result = cars.Where(car => IsFord(car));
            // var result = cars.Where(IsFord);
            CarRepository.PrintCars(result);

            // CarRepository.PrintCars(cars);
        }

        static bool IsFord(Car car) => car.Manufacturer == "Ford";
    }
}
