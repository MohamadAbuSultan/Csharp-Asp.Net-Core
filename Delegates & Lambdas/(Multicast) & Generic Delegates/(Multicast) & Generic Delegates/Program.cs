namespace _Multicast____Generic_Delegates
{
    delegate void del1(string input);
    delegate string del2(string input);

    delegate T genecricDel<T>(T input1, T input2); // Generic Delegate

    internal class MyClass
    {
        public void Print(string input) => Console.WriteLine($"Print 1: {input}");
    }

    internal class Program : MyClass
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            del1 d1 = myClass.Print;

            //Console.WriteLine(d1.Method);
            //Console.WriteLine(d1.Target); // _Multicast____Generic_Delegates.MyClass

            d1 += Print2;

            d1 += Print3;

            var invokeList = d1.GetInvocationList();

            //d1("Hello");

            del2 d2 = (string input) => $"Print 1: {input}";
            d2 += (string input) => $"Print 2: {input}";
            d2 += (string input) => $"Print 3: {input}";

            //Console.WriteLine(d2("This is last print"));

            genecricDel<string> gDStrings = (string input1, string input2) => $"{input1}  {input2}";
            genecricDel<int> gDIntegersSum = (int input1, int input2) => input1 + input2;

            Console.WriteLine(gDStrings("Hello", "World"));
            Console.WriteLine(gDIntegersSum(100, 200));

        }

        static void Print2(string input) => Console.WriteLine($"Print 2: {input}");
        static void Print3(string input) => Console.WriteLine($"Print 3: {input}");
    }
}
