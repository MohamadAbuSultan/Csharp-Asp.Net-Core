Select * From tblEmployee

Execute spGetEmployees

Create Procedure spGetEmployees
As
Begin
Select Gender,DepartmentId From tblEmployee
End

-- A stored procedure is group of T-SQL (Transact SQL) statements. If you have a situation, where
-- you write the same query over and over again, you can save that specific query as a stored
-- procedure and call it just by it's name.

-- 1. Use CREATE PROCEDURE or CREATE PROC statement to create SP
-- Note: When naming user defined stored procedures, Microsoft recommends not to use sp_ as a
-- prefix. All system stored procedures, are prefixed with sp_. This avoids any ambiguity between
-- user defined and system stored procedures and any conflicts, with some future system procedure.

-- To execute the stored procedure
-- 1. spGetEmployees
-- 2. EXEC spGetEmployees
-- 3. Execute spGetEmployees
-- Note: You can also right click on the procedure name, in object explorer in SQL Server
-- Management Studio and select EXECUTE STORED PROCEDURE.

-- Parameters and variables have an @ prefix in their name.
-- To Execute:
-- EXECUTE spGetEmployeesByGenderAndDepartment 'Male', 1
-- EXECUTE spGetEmployeesByGenderAndDepartment @Departmentid=1, @Gender = 'Male'

-- To view the text, of the stored procedure
-- 1. Use system stored procedure sp_ helptext 'SPName'
--				        OR
-- 2. Right Click the SP in Object explorer -> Scrip Procedure as -> 
-- Create To -> New Query Editor Window

-- To change the stored procedure, use ALTER PROCEDURE statement.
-- To delete the SP, use DROP PROC 'SPName' or DROP PROCEDURE 'SPName*
-- To encrypt the text of the SP, use WITH ENCRYPTION option. 
-- It is not possible to view the text of an encrypted SP.