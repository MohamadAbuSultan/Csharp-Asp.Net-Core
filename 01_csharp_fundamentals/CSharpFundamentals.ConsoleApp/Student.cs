namespace CSharpFundamentals
{
    public class Student
    {
        public Student(string name)
        {
            Console.WriteLine("-----------------------------------------");
            this.Name = name;
        }
        public string Name { get; set; } // auto implemented property || // automatic properties 
        public int PhoneNumber { get; set; } // automatic properties 
        public string Address { get; set; }
    }
}
