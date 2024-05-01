namespace CSharpFundamentals
{
    internal class Student
    {
        // the code in the compilation_process.cs file
        public Student()
        {
            Console.WriteLine("New Student has been initialized");
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
