namespace CSharpFundamentals
{
    public class Student
    {
        public Student(string name)
        {
            Console.WriteLine("New Student has been initialized");
            this.Name = name;
        }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
