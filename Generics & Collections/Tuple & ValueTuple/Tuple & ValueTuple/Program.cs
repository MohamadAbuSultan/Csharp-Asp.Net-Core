namespace Tuple___ValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuple is a Reference type
            // Tuple is a Generic type
            // We use Tuple when we want to store multiple items in a single object

            // ValueTuple is a Value type

            Tuple<int, int> tuple = new Tuple<int, int>(4, 10);
            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);

            Tuple<int, int, double, int> tuple1 = new Tuple<int, int, double, int>(4, 10, 20.5, 30);
            //Console.WriteLine(tuple1.Item3);

            var myTuple = Tuple.Create(15, 30, "String Tuple");

            var myTuple1 = Tuple.Create(15, 30, 60, 120, 240, 480, 960, 1820);
            //Console.WriteLine(myTuple1.Rest);
            //Console.WriteLine(myTuple1.Rest.Item1);

            var myTuple2 = Tuple.Create(15, 30, 60, 120, 240, 480, 960, Tuple.Create(1820, 3640, 7280));
            //Console.WriteLine(myTuple2.Rest.Item1.Item3);

            Person person1 = new Person() { Name = "Moh", Age = 30 };
            var ageAndName = person1.Deconstruct();
            //Console.WriteLine(ageAndName.Item1);
            //Console.WriteLine(ageAndName.Item2);



            var (name, age) = person1.Deconstruct(); // ValueTuple deconstruction
            //Console.WriteLine(name);
            //Console.WriteLine(age);

            ValueTuple<int, string, string> employee = (10, "Moh", "Kha");
            //Console.WriteLine(employee.Item1);
            // ValueTuple store the value as a struct not as a class
            (int Id, string FirstName, string SecondName) employee1 = (10, "Moh", "Kha"); // ValueTuple syntax in C# 7.0
            //Console.WriteLine(employee1.Id);
            //Console.WriteLine(employee1.FirstName);
            //Console.WriteLine(employee1.SecondName);

            Person2 person2 = new Person2() { Name = "Moh", Age = 30 };
            var (name2, age2) = person2.Deconstruct(); // ValueTuple Deconstruction
            Console.WriteLine(name2);
            Console.WriteLine(age2);

            // In general, prefer ValueTuple over Tuple for better performance and usability.
            // ValueTuple can store more elements directly without nesting.
            // ValueTuple supports named elements for better code readability.
            // ValueTuple is more efficient in terms of memory and performance since it is a value type.
            // ValueTuple defintions are easier to read and write compared to Tuple.
            // ValueTuple is lightweight and has less overhead compared to Tuple.
        }
    }

    internal class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public (string Name, int Age) Deconstruct()
        {
            return (Name, Age);
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Tuple<string, int> Deconstruct()
        {
            return Tuple.Create(Name, Age);
        }
    }
}
