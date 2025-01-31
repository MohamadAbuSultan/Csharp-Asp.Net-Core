using Access_Modifiers.Models;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            /*
            public: Accessible from any code.
            internal: Accessible within the same assembly.
            private: Accessible only within the same class.
            */
        }
    }
}
