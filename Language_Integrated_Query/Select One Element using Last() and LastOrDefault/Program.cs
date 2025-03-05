using SelectOneElement;

var cars = CarRepository.GetCars();

// var resultQ = (from car in cars
//                where IsMaserati(car)
// where car.Manufacturer == "Maserati"
//                select car).LastOrDefault();
// CarRepository.PrintCars([resultQ]);

// var allCars = cars.ToList();
// CarRepository.PrintCars(allCars);
cars = [];
// var resultM = cars
// .Where(IsMaserati())
//     .Last(IsMaserati);
// CarRepository.PrintCars([resultM]);

var resultQOR = cars.LastOrDefault(IsMaserati);
// CarRepository.PrintCars([resultQOR]);

if (resultQOR != null)
    CarRepository.PrintCars(new List<Car> { resultQOR });
else
    Console.WriteLine("No car found with the specified manufacturer.");

static bool IsMaserati(Car car)
{
    return car.Manufacturer == "Maseratii";
}