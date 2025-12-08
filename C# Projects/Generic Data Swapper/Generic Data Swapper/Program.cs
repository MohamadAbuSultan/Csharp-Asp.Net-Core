namespace Generic_Data_Swapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            // No need to 'new' the class if the method is static
            GenericMethods.SwapData(ref x, ref y);
            Console.WriteLine($"After swapping integers: x = {x}, y = {y}");

            string str1 = "Hello", str2 = "World";
            GenericMethods.SwapData(ref str1, ref str2);
            Console.WriteLine($"After swapping strings: str1 = {str1}, str2 = {str2}");
        }
    }
    internal static class GenericMethods
    {
        // Making this 'static' makes it a utility method accessible anywhere
        public static void SwapData<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
