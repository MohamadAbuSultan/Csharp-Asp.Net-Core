using Average;

int[] number = { 1, 2, 3, 4, 6 };

var average = number.Average();
// Console.WriteLine($"Average: {average}");

var cars = CarRepository.GetCars();

var speedAverage = cars.Where(IsFord).Average(car => car.MaxSpeed);
// Console.WriteLine($"Average Max Speed: {speedAverage}");

string[] names = ["Mohamad", "Ali", "Ahmed", "Hasan"];
var averageNameLength = names.Average(name => name.Length);
// Console.WriteLine($"Average Name Length: {averageNameLength}");

string[] numbers = ["10000", "1993123129", "1234567890", "9876543210"];
var averageNumberLength = numbers.Average(number => long.Parse(number));
Console.WriteLine($"Average Number Length: {averageNumberLength}");

static bool IsFord(Car car) => car.Manufacturer == "Ford";