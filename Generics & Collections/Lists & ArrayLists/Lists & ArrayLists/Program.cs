namespace Lists___ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Collection - Generic and Non-Generic
            // Generic => List 
            // Non-Generic => ArrayList 
            // ArrayList is a non-generic collection that can hold items of any data type.
            // It's dynamic in size, meaning it can grow and shrink as needed.

            int[] numbers = new int[3] { 8, 10, 13 }; // fixed size array

            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(1); // boxing
            // boxing is the process of converting a value type to an object type
            // or to any interface type implemented by this value type.

            //Console.WriteLine(arrayList[0]); // unboxing
            // unboxing is the process of converting an object type back to a value type.

            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add("Hello");
            arrayList.Add(4.5);

            arrayList.Remove(3);
            arrayList.RemoveAt(3);

            arrayList.AddRange(numbers); // adding array to arraylist

            arrayList.Insert(2, 100);

            //Console.WriteLine(arrayList.Count);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            // ArrayList does not provide type safety

            // To achieve type safety, we can use Generic Collections like List<T>
            // List<T> is a generic collection that can hold items of a specific data type.

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            //list.Add("Hello"); // Compile-time error

            list.AddRange(numbers);

            list.Remove(2);
            list.RemoveAt(2);
            list.Insert(2, 100);

            //Console.WriteLine(list.Count);
            //foreach (var item in list)
            //{
            //Console.WriteLine(item);
            //}


            List<string> stringList = new List<string>();
            stringList.Add("Apple");
            stringList.Add("Banana");
            stringList.Add("Cherry");
            //foreach (var item in stringList)
            //{
            //    Console.WriteLine(item);
            //}


            List<Person> people = new List<Person>();

            people.Add(new Person { Name = "Alice", Age = 30 });
            people.Add(new Person { Name = "Bob", Age = 25 });
            people.Add(new Person { Name = "Charlie", Age = 35 });

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            List<int> randomNumbers = new List<int> { 5, 3, 8, 1, 4, 10, 6 };
            //randomNumbers.Sort(); // Sorts the list in ascending order

            //foreach (var number in randomNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine(randomNumbers.Contains(4)); // Returns true if the list contains the specified value

            //Console.WriteLine(randomNumbers.IndexOf(4));

            randomNumbers.Clear();
            Console.WriteLine(randomNumbers);
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
