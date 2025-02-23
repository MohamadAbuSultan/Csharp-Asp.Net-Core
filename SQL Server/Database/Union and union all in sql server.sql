-- UNION and UNION ALL operators in SQL Server, are used to 
-- combine the result-set of two or more SELECT queries.

Select Id, Name, Email From tblIndiaCustomers
Union
Select Id, Name, Email From tblUKCustomers

Select Id, Name, Email From tblIndiaCustomers
Union All
Select Id, Name, Email From tblUKCustomers
order by Name

Select Id, Name, Email From tblIndiaCustomers
Union
Select Id, Name, Email From tblUKCustomers

-- Note: For UNION and UNION ALL to work, the Number, Data types, 
-- and the order of the columns in the select statements should be same.

-- Difference between UNION and UNION ALL
-- 1. Union removes duplicate rows, where as Union All does not
-- 2. Union has to perform distinct sort to remove duplicates, 
-- which makes it less faster than Union All
-- Note: Estimated query execution plan-CTRL + L

-- Sorting results of a UNION or UNION ALL
-- Order By clause should be used only on the last SELECT statement
-- in the UNION query

-- Difference between UNION and JOIN
-- Union combines the result-set of two or more select 
-- queries into a single result-set which
-- includes all the rows from all the queries in the union, 
-- where as Joins retrieve data from two or more tables based on logical relationships between the tables.
-- In short, Union combines rows from 2 or more tables
-- where Joins combine columns from 2 or more table.