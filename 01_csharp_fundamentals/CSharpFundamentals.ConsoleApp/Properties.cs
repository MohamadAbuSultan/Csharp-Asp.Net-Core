namespace CSharpFundamentals
{
    internal class Properties
    {
        static void Main(string[] args)
        {
            /*
             * private string _name;
             * public string Name
             * {
             *      get { return _name; }
             *      set { _name = value; }
             * }
            */
            //public string Name { get; set; } // auto implemented property || // automatic properties 
            //public int PhoneNumber { get; set; } // automatic properties 
            // We use automatic properties when we need to define a property that only contains the default get and set operations
            Student student1 = new("Mohamad");
            //student1.Name = "Test";
            Console.WriteLine(student1.Name);
        }
    }
}
