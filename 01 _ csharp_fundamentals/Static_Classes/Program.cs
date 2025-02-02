// See https://aka.ms/new-console-template for more information

using MyNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        // MyStaticClass myStaticClass = new MyStaticClass(); // Error: 'MyNamespace

        // The static constructor is called only once, before any static members are accessed.
        MyStaticClass.DoSomething();
        MyStaticClass.DoSomething();
        MyStaticClass.DoSomething();
        MyStaticClass.DoSomething();
    }
}