/* 
// Introduction
// Projection & Filtering (Select, Where, OfType)
// Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
// Quantifiers (All, Any, Contains)
// Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
// Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)
* Joins (Join, GroupJoin)
* Grouping (GroupBy, ToLookup)
*/


//* ------------------ الفرق بين IEnumerable و IQueryable -------------------

// IEnumerable:
//* الداتا كلها محملة معاك في الذاكرة (In-Memory)
//* كل الكويري بتتنفذ داخل تطبيقك
//* مناسبة للعمليات اللي على كائنات محلية زي List

// IQueryable:
//* ما بتحمل الداتا فوراً، بتجهز الكويري وتبعتها مثلاً لـ DB
//* مناسبة لما تكون بتتعامل مع مصدر بيانات خارجي (Database)
//* تستخدم مع Entity Framework والـ EF Core

// خلاصة:
// - لو الداتا معاك في الميموري؟ استخدم IEnumerable
// - لو بدك تبعت الكويري لقاعدة بيانات؟ استخدم IQueryable

var depatements = new List<Department>{
    new Department(1, "HR"),
    new Department(2, "IT"),
    new Department(3, "Finance"),
    new Department(4, "Development")
};

var employees = new List<Employee>
{
    new Employee("Mohamad Khaled", 23, 1000000, 1),
    new Employee("Ibrahim Mohamad", 24, 1000000, 1),
    new Employee("David John", 35, 700000, 2),
    new Employee("John David", 36, 700000, 2),
    new Employee("Ahmed Mohamad", 20, 500000, 3),
    new Employee("Sara Mohamad", 21, 500000, 3),
    new Employee("Amal Mohamad", 30, 800000, 4),
    new Employee("Hamada Salah", 31, 800000, 4),
};

// var query = from employee in employees
//             join department in depatements
//             on employee.DepartmentId equals department.Id
//             select new { EmployeeName = employee.Name, DepartmentName = department.Name };
// select new Employee(employee.Name, employee.Age, employee.Salary, department.Id);

// var query = employees.Join(depatements,
//     employee => employee.DepartmentId,
//     department => department.Id,
//     (employee, department) => new { EmployeeName = employee.Name, DepartmentName = department.Name });    
// foreach (var record in query) 
//     Console.WriteLine($"{record.EmployeeName} works in {record.DepartmentName} department.");

var query = from employee in employees
            join department in depatements
            on employee.DepartmentId equals department.Id
            group employee by department.Name;
foreach (var group in query)
{
    var employeeNames = string.Join(", ", group.Select(x => x.Name).ToArray());
    Console.WriteLine($"#{group.Key} Group: {employeeNames}");
}

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public int DepartmentId { get; set; }

    public Employee(string name, int age, decimal salary, int departmentId)
    {
        Name = name;
        Age = age;
        Salary = salary;
        DepartmentId = departmentId;
    }
}
