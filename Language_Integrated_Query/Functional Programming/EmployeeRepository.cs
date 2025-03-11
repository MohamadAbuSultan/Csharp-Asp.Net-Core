using System;
using System.Collections.Generic;

public static class EmployeeRepository
{
    public static IEnumerable<Employee> LoadEmployees()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1001,
                FirstName = "John",
                LastName = "Doe",
                HireDate = new DateTime(2020, 1, 1),
                Gender = "Male",
                Department = "IT",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 60000m
            },
            new Employee
            {
                Id = 1002,
                FirstName = "Jane",
                LastName = "Smith",
                HireDate = new DateTime(2019, 2, 15),
                Gender = "Female",
                Department = "HR",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 55000m
            },
            new Employee
            {
                Id = 1003,
                FirstName = "Michael",
                LastName = "Johnson",
                HireDate = new DateTime(2018, 3, 10),
                Gender = "Male",
                Department = "Finance",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 70000m
            },
            new Employee
            {
                Id = 1004,
                FirstName = "Hester",
                LastName = "Evans",
                HireDate = new DateTime(2017, 4, 5),
                Gender = "Male",
                Department = "Finance",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 155500m
            },
            new Employee
            {
                Id = 1005,
                FirstName = "Sarah",
                LastName = "Brown",
                HireDate = new DateTime(2021, 5, 20),
                Gender = "Female",
                Department = "Marketing",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 50000m
            },
            new Employee
            {
                Id = 1006,
                FirstName = "David",
                LastName = "Wilson",
                HireDate = new DateTime(2016, 6, 10),
                Gender = "Male",
                Department = "Sales",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 75000m
            },
            new Employee
            {
                Id = 1007,
                FirstName = "Emily",
                LastName = "Davis",
                HireDate = new DateTime(2018, 7, 15),
                Gender = "Female",
                Department = "Operations",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 65000m
            },
            new Employee
            {
                Id = 1008,
                FirstName = "James",
                LastName = "Miller",
                HireDate = new DateTime(2019, 8, 20),
                Gender = "Male",
                Department = "IT",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 80000m
            },
            new Employee
            {
                Id = 1009,
                FirstName = "Olivia",
                LastName = "Garcia",
                HireDate = new DateTime(2020, 9, 25),
                Gender = "Female",
                Department = "HR",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 55000m
            },
            new Employee
            {
                Id = 1010,
                FirstName = "Daniel",
                LastName = "Martinez",
                HireDate = new DateTime(2017, 10, 30),
                Gender = "Male",
                Department = "Finance",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 90000m
            },
            new Employee
            {
                Id = 1011,
                FirstName = "Sophia",
                LastName = "Rodriguez",
                HireDate = new DateTime(2018, 11, 5),
                Gender = "Female",
                Department = "Marketing",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 60000m
            },
            new Employee
            {
                Id = 1012,
                FirstName = "Matthew",
                LastName = "Martinez",
                HireDate = new DateTime(2019, 12, 10),
                Gender = "Male",
                Department = "Sales",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 70000m
            },
            new Employee
            {
                Id = 1013,
                FirstName = "Ava",
                LastName = "Hernandez",
                HireDate = new DateTime(2020, 1, 15),
                Gender = "Female",
                Department = "Operations",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 65000m
            },
            new Employee
            {
                Id = 1014,
                FirstName = "Joseph",
                LastName = "Lopez",
                HireDate = new DateTime(2016, 2, 20),
                Gender = "Male",
                Department = "IT",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 85000m
            },
            new Employee
            {
                Id = 1015,
                FirstName = "Isabella",
                LastName = "Gonzalez",
                HireDate = new DateTime(2017, 3, 25),
                Gender = "Female",
                Department = "HR",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 55000m
            },
            new Employee
            {
                Id = 1016,
                FirstName = "William",
                LastName = "Perez",
                HireDate = new DateTime(2018, 4, 30),
                Gender = "Male",
                Department = "Finance",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 95000m
            },
            new Employee
            {
                Id = 1017,
                FirstName = "Mia",
                LastName = "Sanchez",
                HireDate = new DateTime(2019, 5, 5),
                Gender = "Female",
                Department = "Marketing",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 60000m
            },
            new Employee
            {
                Id = 1018,
                FirstName = "Alexander",
                LastName = "Clark",
                HireDate = new DateTime(2020, 6, 10),
                Gender = "Male",
                Department = "Sales",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 75000m
            },
            new Employee
            {
                Id = 1019,
                FirstName = "Charlotte",
                LastName = "Lewis",
                HireDate = new DateTime(2016, 7, 15),
                Gender = "Female",
                Department = "Operations",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 65000m
            },
            new Employee
            {
                Id = 1020,
                FirstName = "Elijah",
                LastName = "Walker",
                HireDate = new DateTime(2017, 8, 20),
                Gender = "Male",
                Department = "IT",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 80000m
            },
            new Employee
            {
                Id = 1021,
                FirstName = "Amelia",
                LastName = "Hall",
                HireDate = new DateTime(2018, 9, 25),
                Gender = "Female",
                Department = "HR",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 55000m
            },
            new Employee
            {
                Id = 1022,
                FirstName = "James",
                LastName = "Allen",
                HireDate = new DateTime(2019, 10, 30),
                Gender = "Male",
                Department = "Finance",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 90000m
            },
            new Employee
            {
                Id = 1023,
                FirstName = "Harper",
                LastName = "Young",
                HireDate = new DateTime(2020, 11, 5),
                Gender = "Female",
                Department = "Marketing",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 60000m
            },
            new Employee
            {
                Id = 1024,
                FirstName = "Benjamin",
                LastName = "Hernandez",
                HireDate = new DateTime(2016, 12, 10),
                Gender = "Male",
                Department = "Sales",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 70000m
            },
            new Employee
            {
                Id = 1025,
                FirstName = "Evelyn",
                LastName = "King",
                HireDate = new DateTime(2017, 1, 15),
                Gender = "Female",
                Department = "Operations",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 65000m
            },
            new Employee
            {
                Id = 1026,
                FirstName = "Lucas",
                LastName = "Wright",
                HireDate = new DateTime(2018, 2, 20),
                Gender = "Male",
                Department = "IT",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 85000m
            },
            new Employee
            {
                Id = 1027,
                FirstName = "Abigail",
                LastName = "Lopez",
                HireDate = new DateTime(2019, 3, 25),
                Gender = "Female",
                Department = "HR",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 55000m
            },
            new Employee
            {
                Id = 1028,
                FirstName = "Henry",
                LastName = "Hill",
                HireDate = new DateTime(2020, 4, 30),
                Gender = "Male",
                Department = "Finance",
                HasHealthInsurance = true,
                HasPensionPlan = false,
                Salary = 95000m
            },
            new Employee
            {
                Id = 1029,
                FirstName = "Ella",
                LastName = "Scott",
                HireDate = new DateTime(2016, 5, 5),
                Gender = "Female",
                Department = "Marketing",
                HasHealthInsurance = true,
                HasPensionPlan = true,
                Salary = 60000m
            },
            new Employee
            {
                Id = 1030,
                FirstName = "Sebastian",
                LastName = "Green",
                HireDate = new DateTime(2017, 6, 10),
                Gender = "Male",
                Department = "Sales",
                HasHealthInsurance = false,
                HasPensionPlan = true,
                Salary = 75000m
            }
        };
    }
}