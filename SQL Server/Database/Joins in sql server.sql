-- Joins in SQL Server are used to retrieve data from 2 or more related tables. In general tables are
-- related to each other using foreign key constraints.

-- In SQL server, there are different types of JOINS
-- 1. INNER JOIN
-- 2. OUTER JOIN
-- 3. CROSS JOIN

-- INNER JOIN returns only the matching rows between both
-- the tables. Non matching rows are eliminated.
-- INNER JOIN || JOIN
SELECT Name, Gender, Salary, DepartmentName
From tblEmployee
INNER JOIN tblDepartment
ON 
tblEmployee.DepartmentId = tblDepartment.Id
-- Or
SELECT Name, Gender, Salary, DepartmentName
From tblEmployee
JOIN tblDepartment
ON 
tblEmployee.DepartmentId = tblDepartment.Id

-- Left Outer Join || Left Join
-- LEFT JOIN returns all the matching rows + non matching
-- rows from the left table.
SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee
LEFT OUTER JOIN tblDepartment
ON 
tblEmployee.DepartmentId = tblDepartment.Id
-- OR
SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee
LEFT JOIN tblDepartment
ON
tblEmployee.DepartmentId = tblDepartment.Id

-- Right Outer Join || Right Join
-- RIGHT JOIN returns all the matching rows + non matching
-- rows from the right table
SELECT Name, Gender, salary,DepartmentName
FROM tblEmployee
RIGHT OUTER JOIN tblDepartment
ON tblEmployee.DepartmentId = tblDepartment.Id
-- OR
SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee
RIGHT JOIN tblDepartment
ON tblEmployee .DepartmentId = tblDepartment. Id

-- Full Outer Join or Full Join
-- FULLJOIN returns all rows from both the left and right
-- tables, including the non matching rows.
SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee
FULL OUTER JOIN tblDepartment
ON tblEmployee.DepartmentId = tblDepartment.Id
-- OR
SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee
FULL JOIN tblDepartment
ON tblEmployee.DepartmentId = tblDepartment.Id

-- Cross Join
-- CROSS JOIN, produces the Cartesian product of the 2 tables involved in the join. For example, in the
-- Employees table we have 10 rows and in the Departments table we have 4 rows. So, a cross join between
-- these 2 tables produces 40 rows.
-- NOTE: Cross Join shouldn't have ON clause.
-- General Formula for Joins:
-- SELECT COLUMN_LIST
-- FROM LEFT_TABLE_ NAME
-- JOIN_TYPE RIGHT_ TABLE_NAME
-- ON JOIN_CONDITION
-- Cross Join:
SELECT Name, Gender, Salary, DepartmentName
FROM tblEmployee
CROSS JOIN tblDepartment

-- Summary
-- Join Type  - Purpose
-- Cross Join - Purpose: Returns Cartesian product of the tables involved in the join
-- Inner Join - Purpose: Returns only the matching rows. Non matching rows are eliminated.
-- Left Join  - Purpose: Returns all the matching rows + non matching rows from the left table
-- Right Join - Purpose: Returns all the matching rows + non matching rows from the right table
-- Full Join  - Purpose: Returns all rows from both tables, including the non-matching rows.