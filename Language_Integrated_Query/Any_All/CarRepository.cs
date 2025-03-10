using System;
using System.Collections.Generic;

namespace Any_All
{
    public record Car
    (
        int ID,
        string Manufacturer,
        string Vehicle,
        string Model,
        string Type,
        string Fuel,
        string Color,
        string VRM,
        int MaxSpeed
    );

    public static class CarRepository
    {
        public static IEnumerable<Car> GetCars()
        {
            return new List<Car>
            {
                new Car(1, "Hyundai", "Volvo Altima", "2", "Cargo Van", "Diesel", "orange", "ZD20KEK", 180),
                new Car(2, "Ford", "Mercedes Benz Charger", "Fortwo", "Hatchback", "Hybrid", "maroon", "IR52LWF", 220),
                new Car(3, "Aston Martin", "Lamborghini Civic", "1", "Extended Cab Pickup", "Electric", "salmon", "LD91UUS", 240),
                new Car(4, "Volkswagen", "Porsche CTS", "Expedition", "Passenger Van", "Gasoline", "cyan", "WX80VBH", 200),
                new Car(5, "Cadillac", "Audi Mercielago", "Civic", "Convertible", "Gasoline", "violet", "RY45FRH", 230),
                new Car(6, "Fiat", "Bugatti Element", "Beetle", "Sedan", "Electric", "red", "AT69RTH", 190),
                new Car(7, "Dodge", "Jaguar Jetta", "Camaro", "Convertible", "Diesel", "violet", "MX02XHD", 250),
                new Car(8, "Bugatti", "Kia Focus", "Expedition", "Passenger Van", "Hybrid", "teal", "XG24PBO", 260),
                new Car(9, "Land Rover", "Maserati Ranchero", "V90", "Minivan", "Electric", "magenta", "GC54YSM", 210),
                new Car(10, "Hyundai", "Lamborghini Taurus", "A4", "Hatchback", "Diesel", "olive", "DN79APW", 200),
                new Car(11, "Tesla", "Lamborghini Ranchero", "Challenger", "Convertible", "Hybrid", "gold", "JK51QYJ", 270),
                new Car(12, "Ford", "Land Rover A4", "Land Cruiser", "Passenger Van", "Diesel", "cyan", "RQ67JJT", 230),
                new Car(13, "Dodge", "Ford Aventador", "A4", "Extended Cab Pickup", "Hybrid", "lavender", "AR46BCU", 250),
                new Car(14, "Volkswagen", "Bentley Challenger", "Escalade", "Minivan", "Hybrid", "maroon", "JG79UOH", 180),
                new Car(15, "Aston Martin", "Polestar Prius", "Volt", "Crew Cab Pickup", "Gasoline", "sky blue", "AX73MXT", 240),
                new Car(16, "Maserati", "Jaguar Fiesta", "Silverado", "Wagon", "Hybrid", "magenta", "OZ01MDT", 210),
                new Car(17, "Toyota", "Chevrolet Element", "Durango", "Cargo Van", "Diesel", "ivory", "NT29BSN", 220),
                new Car(18, "BMW", "Cadillac Focus", "Charger", "Cargo Van", "Diesel", "red", "NG18HOG", 190),
                new Car(19, "Lamborghini", "Volkswagen Spyder", "Silverado", "Convertible", "Diesel", "black", "CP59KOJ", 280),
                new Car(20, "Aston Martin", "Rolls Royce Golf", "El Camino", "Coupe", "Gasoline", "gold", "PK48TTL", 260),
                new Car(21, "Lamborghini", "Hyundai Ranchero", "Escalade", "Cargo Van", "Diesel", "yellow", "YB91UFQ", 230),
                new Car(22, "Mini", "Audi Model 3", "Accord", "Cargo Van", "Diesel", "blue", "HZ35HFB", 200),
                new Car(23, "Dodge", "Bugatti A8", "Volt", "Coupe", "Hybrid", "plum", "JZ08TGH", 250),
                new Car(24, "Jeep", "Chevrolet Prius", "XC90", "Sedan", "Hybrid", "purple", "TA60BMV", 220),
                new Car(25, "Maserati", "Polestar Model X", "Durango", "Crew Cab Pickup", "Gasoline", "silver", "CP13NOF", 240),
                new Car(26, "Chevrolet", "Maserati A8", "Civic", "Convertible", "Electric", "cyan", "ZD67KZP", 230),
                new Car(27, "Chevrolet", "Maserati Fiesta", "Civic", "Convertible", "Gasoline", "ivory", "ZD67KZP", 190),
            };

        }

        public static void PrintCars(IEnumerable<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"ID: {car.ID}, Manufacturer: {car.Manufacturer}, Vehicle: {car.Vehicle}, Model: {car.Model}, Type: {car.Type}, Fuel: {car.Fuel}, Color: {car.Color}, VRM: {car.VRM}, MaxSpeed: {car.MaxSpeed}");
            }
        }
    }
}
