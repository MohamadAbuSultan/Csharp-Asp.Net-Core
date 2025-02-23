-- Replacing NULL Values
-- Three ways to replace NULL values - ISNULL() Function, CASE Statement & COALESCE Function

-- ISNULL() Function
-- Select ISNULL(NULL,'No Manager') 
Select E.Name as Name, 
ISNULL(M.Name,'No Manager') as Manager
From tblEmployees E
Left Join tblEmployees M 
On E.ManagerID = M.EmployeeID

-- COALESCE Function
-- Select Coalesce(NULL, 'Mohamad')
Select E.Name as Name, 
Coalesce(M.Name, 'No Manager') as Manager
From tblEmployees E
Left Join tblEmployees M 
On E.ManagerID = M.EmployeeID

-- CASE Statement
-- CASE WHEN Expression THEN '' ELSE '' END
Select E.Name as Name, 
Case When M.Name Is Null Then 'No Manager' else M.Name End as Manager
From tblEmployees E
Left Join tblEmployees M 
On E.ManagerID = M.EmployeeID