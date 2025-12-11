namespace Anonymous_Methods___Lambda_Expressions
{
    delegate int Del(int a, int b); // definition

    internal class Program
    {
        static void Main(string[] args)
        {
            Del del1 = new Del(Add); // instantiation
            Del del2 = Add;


            int result = del1.Invoke(5, 10);
            int result2 = del1(5, 10);
            //Console.WriteLine(result);

            Del del3 = Sub;
            int result3 = del3(10, 5);
            //Console.WriteLine(result3);

            // Anonymous Methods
            Del del4 = delegate (int x, int y) { return x + y; };
            int result4 = del4(10, 5);
            //Console.WriteLine(result4);

            Del del5 = delegate (int x, int y) { return x - y; };
            int result5 = del5(15, 5);
            //Console.WriteLine(result5);


            // Lambda Expressions
            Del d = (int x, int y) => x * y;
            Del d1 = (int x, int y) => { return x * y; };
            int r = d(5, 10);
            Console.WriteLine(r);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
