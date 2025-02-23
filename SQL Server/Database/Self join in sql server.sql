-- Joining a table with itself is called as
-- SELF JOIN.
-- SELF JOIN is not a different type of
-- JOIN.
-- It can be classified under any type of
-- JOIN:
-- 1. INNER,
-- 2. OUTER (Left, Right, Full)
-- 3. CROSS Joins.

Select * From tblEmployees

-- Left Outer Self Join
SELECT E.Name AS Employee, M.Name AS Manager
FROM tblEmployees E
LEFT JOIN tblEmployees M
ON E.ManagerID = M.EmployeeID

-- Inner Self Join
SELECT E.Name AS Employee, M.Name AS Manager
FROM tblEmployees E
INNER JOIN tblEmployees M
ON E.ManagerID = M.EmployeeID

-- Cross Self Join
SELECT E.Name AS Employee, M.Name AS Manager
FROM tblEmployees E
CROSS JOIN tblEmployees M