namespace Events
{
    public class Employee
    {
        public required string Name { get; set; }
        public int BasicSalary { get; set; }
        public int Deductions { get; set; }
        public int Bonus { get; set; }
    }
}