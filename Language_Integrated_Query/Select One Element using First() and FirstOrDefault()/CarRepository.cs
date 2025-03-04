using System;
using System.Collections.Generic;

namespace SelectOneElement 
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
            return new List<Car>
            {
                new Car("Hyundai", "Volvo Altima", "2", "Cargo Van", "Diesel", "orange", "ZD20KEK"),
                new Car("Ford", "Mercedes Benz Charger", "Fortwo", "Hatchback", "Hybrid", "maroon", "IR52LWF"),
                new Car("Aston Martin", "Lamborghini Civic", "1", "Extended Cab Pickup", "Electric", "salmon", "LD91UUS"),
                new Car("Volkswagen", "Porsche CTS", "Expedition", "Passenger Van", "Gasoline", "cyan", "WX80VBH"),
                new Car("Cadillac", "Audi Mercielago", "Civic", "Convertible", "Gasoline", "violet", "RY45FRH"),
                new Car("Fiat", "Bugatti Element", "Beetle", "Sedan", "Electric", "red", "AT69RTH"),
                new Car("Dodge", "Jaguar Jetta", "Camaro", "Convertible", "Diesel", "violet", "MX02XHD"),
                new Car("Bugatti", "Kia Focus", "Expedition", "Passenger Van", "Hybrid", "teal", "XG24PBO"),
                new Car("Land Rover", "Maserati Ranchero", "V90", "Minivan", "Electric", "magenta", "GC54YSM"),
                new Car("Hyundai", "Lamborghini Taurus", "A4", "Hatchback", "Diesel", "olive", "DN79APW"),
                new Car("Tesla", "Lamborghini Ranchero", "Challenger", "Convertible", "Hybrid", "gold", "JK51QYJ"),
                new Car("Ford", "Land Rover A4", "Land Cruiser", "Passenger Van", "Diesel", "cyan", "RQ67JJT"),
                new Car("Dodge", "Ford Aventador", "A4", "Extended Cab Pickup", "Hybrid", "lavender", "AR46BCU"),
                new Car("Volkswagen", "Bentley Challenger", "Escalade", "Minivan", "Hybrid", "maroon", "JG79UOH"),
                new Car("Aston Martin", "Polestar Prius", "Volt", "Crew Cab Pickup", "Gasoline", "sky blue", "AX73MXT"),
                new Car("Maserati", "Jaguar Fiesta", "Silverado", "Wagon", "Hybrid", "magenta", "OZ01MDT"),
                new Car("Toyota", "Chevrolet Element", "Durango", "Cargo Van", "Diesel", "ivory", "NT29BSN"),
                new Car("BMW", "Cadillac Focus", "Charger", "Cargo Van", "Diesel", "red", "NG18HOG"),
                new Car("Lamborghini", "Volkswagen Spyder", "Silverado", "Convertible", "Diesel", "black", "CP59KOJ"),
                new Car("Aston Martin", "Rolls Royce Golf", "El Camino", "Coupe", "Gasoline", "gold", "PK48TTL"),
                new Car("Lamborghini", "Hyundai Ranchero", "Escalade", "Cargo Van", "Diesel", "yellow", "YB91UFQ"),
                new Car("Mini", "Audi Model 3", "Accord", "Cargo Van", "Diesel", "blue", "HZ35HFB"),
                new Car("Dodge", "Bugatti A8", "Volt", "Coupe", "Hybrid", "plum", "JZ08TGH"),
                new Car("Jeep", "Chevrolet Prius", "XC90", "Sedan", "Hybrid", "purple", "TA60BMV"),
                new Car("Maserati", "Polestar Model X", "Durango", "Crew Cab Pickup", "Gasoline", "silver", "CP13NOF"),
                new Car("Chevrolet", "Maserati A8", "Civic", "Convertible", "Electric", "cyan", "ZD67KZP"),
                new Car("Chevrolet", "Maserati Fiesta", "Civic", "Convertible", "Gasoline", "ivory", "ZD67KZP"),
                };
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
