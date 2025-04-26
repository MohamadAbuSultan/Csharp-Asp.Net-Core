/* 
Introduction
*** Projection & Filtering (Select, Where, OfType) ***
Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
Quantifiers (All, Any, Contains)
Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
Set Operations (Distinct, DistinctBy, Except, ExceptBy, Intersect, IntersectBy, Union, UnionBy)
Joins (Join, GroupJoin)
Grouping (GroupBy, ToLookup)
*/

// آخر مرة أخدنا مقدمة عن اللينك وأنواعه وقلنا إنه في طريقتين لكتابة اللينك: Query Syntax و Method Syntax.
// واتفقنا إنه الطريقتين صح وبطلعوا نفس النتيجة.
// لكن، بعض العمليات في LINQ لازم تستخدم الـ Method Syntax عشان تنفذها، زي بعض عمليات الترتيب.

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Descending Order 
var result = from number in numbers
             where number > 5
             orderby number descending
             select number;

foreach (var number in result) Console.WriteLine(number);

// Descending Order using Method Syntax
var result2 = numbers.OrderByDescending(number => number)
    .Where(number => number > 5);

foreach (var number in result2) Console.WriteLine(number);

// ملاحظة:
// بترتيب الميثود، أول حاجة بترتب، بعدين بتفلتر، حسب ترتيب السطور.
// ولو بدك، ممكن تعكسهم حسب الحاجة تبعتك.
// يعني حسب انت بدك ترتب قبل ولا بعد الفلترة، حسب المنطق اللي مناسب للكود تبعك.


var employees = new List<Employee>
{
    new Employee("Mohamad", 23, 1000000),
    new Employee("Duval", 35, 700000),
    new Employee("Ahmed", 35, 600000),
    new Employee("Ahmed", 30, 400000),
    new Employee("Ahmed", 30, 700000)
};

// بدنا نرتبهم حسب:
// - أولاً بالاسم Name (ترتيب أبجدي).
// - بعدين بالعمر Age (من الأصغر للأكبر).
// - بعدين بالراتب Salary (من الأصغر للأكبر).

var query = employees.OrderBy(x => x.Name)
    .ThenBy(x => x.Age)
    .ThenBy(x => x.Salary)
    .Reverse();

// ملاحظة مهمة:
/*
- OrderBy: بيرتب حسب أول معيار.
- ThenBy: بيكمل ترتيب حسب معيار تاني لو الأول متساوي.
- ThenBy: ممكن تزيده أكتر من مرة حسب معاييرك.
- Reverse: بيعكسلك النتيجة كلها (الأخير يصير أول، والأول يصير آخر).
*/


// Using Query Syntax
/*
query = from employee in employees
        orderby employee.Name, employee.Age, employee.Salary
        select employee;
*/

foreach (var employee in query)
    Console.WriteLine(
        $"Name = {employee.Name}, Age = {employee.Age}, Salary = {employee.Salary}");

// طبعاً انت حر تستعمل الطريقة اللي ترتاحلها أكثر...
// سواء Query Syntax أو Method Syntax، النتيجة وحدة.
// بس في بعض الشغلات المتقدمة (زي Reverse و Distinct مثلا) لازم تشتغل Method Syntax.

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}
