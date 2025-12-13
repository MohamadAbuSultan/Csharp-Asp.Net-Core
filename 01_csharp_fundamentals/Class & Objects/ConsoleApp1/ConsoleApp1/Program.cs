using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        //Messages.Hello();
        //Messages.Waiting();
        //Messages.Bye();

        // class = A bundle of related code.
        //         Can be used as a blueprint to create objects (OOP)



        // object = An instance of a class
        //          A class can be used as a blueprint to create objects (OOP)
        //          objects can have fields & methods (characteristics & actions)

        Human human1 = new Human();
        Human human2 = new Human();

        human1.name = "Rick";
        human1.age = 65;

        human2.name = "Morty";
        human2.age = 16;

        //human1.Eat();
        //human1.Sleep();

        //human2.Eat();
        //human2.Sleep();


        // struct = A value type that can encapsulate data and related functionality
        //         Used to create complex data types
        //        Can contain constructors, methods, properties, fields, constants, etc.
        //        Useful for small data structures that have value semantics
        Student student = new("Mohamad", 20);
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
      
        //Console.ReadKey();
    }
}

class Human
{
    // fields
    public String name;
    public int age;


    // methods
    public void Eat()
    {
        Console.WriteLine(name + " is eating");
    }
    public void Sleep()
    {
        Console.WriteLine(name + " is sleeping");
    }
}


public struct Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}