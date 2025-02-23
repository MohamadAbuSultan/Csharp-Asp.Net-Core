SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee E
Left JOIN tblDepartment D
ON E.DepartmentId = D.Id
Where E.DepartmentId is NULL

SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee E
Right JOIN tblDepartment D
ON E.DepartmentId = D.Id
Where E.DepartmentId is NULL

SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee E
Full JOIN tblDepartment D
ON E.DepartmentId = D.Id
Where E.DepartmentId is NULL