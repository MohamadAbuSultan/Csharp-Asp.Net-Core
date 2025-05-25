using MaxAndMaxBy;

int[] numbers = { 1, 2, 3, 4, 5 };

int maxNumber = numbers.Max();
// Console.WriteLine($"The maximum number is: {maxNumber}");

var cars = CarRepository.GetCars();
int maxSpeed = cars.Max(car => car.MaxSpeed);
// Console.WriteLine($"The maximum speed is: {maxSpeed}");

int maxLength = cars.Max(car => car.Manufacturer.Length);
// Console.WriteLine($"The maximum length of a manufacturer name is: {maxLength}");

Car? maxSpeedCar = cars.MaxBy(car => car.MaxSpeed);
CarRepository.PrintCars([maxSpeedCar!]);
