using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace YouTubeLINQ
{
    public record Car
    (
        string Manufacturer,
        string Vehicle,
        string Model,
        string Type,
        string Fuel,
        string Color,
        string VRM
    );

    public static class CarRepository
    {
        public static IEnumerable<Car> GetCars()
        {
            var jsonData = File.ReadAllText("faker.json");
            return JsonConvert.DeserializeObject<IEnumerable<Car>>(jsonData);
        }

        public static void PrintCars(IEnumerable<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Manufacturer: {car.Manufacturer}, Vehicle: {car.Vehicle}, Model: {car.Model}, Type: {car.Type}, Fuel: {car.Fuel}, Color: {car.Color}, VRM: {car.VRM}");
            }
        }
    }
}