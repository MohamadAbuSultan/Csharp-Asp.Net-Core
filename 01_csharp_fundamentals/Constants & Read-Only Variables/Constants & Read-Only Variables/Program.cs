namespace Constants___Read_Only_Variables
{
    internal class Program
    {
        // Constants (Compile-time Constants)
        // Must be assigned at the time of declaration.
        // Cannot be changed after being assigned.
        // The value is replaced directly in the program code (Inlined).
        // Cannot store values that require runtime computation.
        public const string Message = "Hello World";
        public const double PI = 3.141592653589793;
        public const int MinutesPerHour = 60;

        // Read-Only Variables (Runtime Constants)
        // Can be assigned either at the declaration or inside the constructor.
        // Cannot be changed after being assigned inside the constructor.
        // Can store values that are computed at runtime.
        private static readonly string _Message = "Hello World";

        // Constructor - Readonly variables can be modified here only
        static Program()
        {
            _Message = "Hello ";
            _Message = "Mohamad "; // Allowed because its inside the constructor
        }

        static void Main(string[] args)
        {
            // Using Constants
            var str = Message;
            string str2 = Message;

            // Not allowed because const values cannot be modified
            // Message = "Test";  

            // Calculate the area of a circle using the PI constant
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleArea = PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is: " + circleArea);
        }
    }
}
