Select * From tblEmployee1

-- COALESCE Function - Returns The First Non Null Value
SELECT Id, COALESCE(FirstName, MiddleName, LastName) as Name
FROM tblEmployee1