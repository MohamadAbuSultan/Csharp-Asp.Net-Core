using System;

public class Employee
{
    public Employee() { }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public string Gender { get; set; }
    public string Department { get; set; }
    public bool HasHealthInsurance { get; set; }
    public bool HasPensionPlan { get; set; }
    public decimal Salary { get; set; }
    public override string ToString()
    {
        return
            $"Id: {Id}, " +
            $"FirstName: {FirstName}, " +
            $"LastName: {LastName}, " +
            $"HireDate: {HireDate}, " +
            $"Gender: {Gender}, " +
            $"Department: {Department}, " +
            $"HasHealthInsurance: {HasHealthInsurance}, " +
            $"HasPensionPlan: {HasPensionPlan}, " +
            $"Salary: {Salary}";
    }
}