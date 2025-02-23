Select * From tblEmployee

Select SUM(Salary) From tblEmployee
Select MAX(Salary) From tblEmployee
Select MIN(Salary) From tblEmployee

-- Group by clause is used to group a selected set of rows into a set
-- of summary rows by the values of one or more columns or
-- expressions. It is always used in conjunction with one or more
-- aggregate functions.
Select City,Sum(Salary)
as [Total Salary]  -- [ ] We put it there so we can add a space between the two words
from tblEmployee
Group By City
-- [ ] We put it there so we can add a space between the two words

-- Note: If you omit, the GROUP BY clause and try to execute the query,
-- you get an error Column 'tblEmployee.City' is invalid in the select list because 
-- it is not contained in either an aggregate function or the GROUP BY clause.

Select 
City,
Gender,
Sum(Salary) as [Total Salary]  
from tblEmployee
Group By Gender,City

-- Filtering Groups:
-- WHERE clause is used to filter rows before aggregation, 
-- HAVING clause is used to filter groups after aggregations. 
-- The following 2 queries produce the same result.
-- 1)
Select City, Sum(Salary) as [Total Salary]
From tblEmployee
Group By City
Having City = 'London'
-- 2)
Select City, Sum(Salary) as [Total Salary]
From tblEmployee
Where City = 'London'
Group By City
-- Note: From a performance standpoint, you cannot say that one method is less efficient than
-- the other. Sql server optimizer analyses each statement and selects an efficient way of
-- executing it. As a best practice, use the syntax that clearly describes the desired result.
-- Try to eliminate rows that you wouldn't need, as early as possible.

Select City, Sum(Salary) as [Total Salary]
From tblEmployee
Group By City
Having Sum(Salary) > 5000

-- 1. WHERE clause can be used with - Select, Insert, and Update statements,
-- HAVING clause can only be used with the Select statement.
-- 2. WHERE filters rows before aggregation (GROUPING), 
-- HAVING filters groups, after the aggregations are performed.
-- 3. Aggregate functions cannot be used in the WHERE clause, unless it is in
-- a sub query contained in a HAVING clause, 
-- aggregate functions can be used in Having clause.