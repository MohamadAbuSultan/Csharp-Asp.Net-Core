using System.Reflection;

namespace MySecondExtension
{
    public class ReflectionDemo2
    {
        public static void PrintAssemblyDetails()
        {
            System.Console.WriteLine($"Entry Assembly: {Assembly.GetEntryAssembly().FullName}");
            System.Console.WriteLine($"Calling Assembly: {Assembly.GetCallingAssembly().FullName}");
            System.Console.WriteLine($"Executing Assembly: {Assembly.GetExecutingAssembly().FullName}");
        }
    }
}
