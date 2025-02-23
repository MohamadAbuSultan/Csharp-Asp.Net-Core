-- select all columns
Select * From tblPerson

-- select specfic columns
Select Name From tblPerson

-- Distinct rows
Select Distinct Name,Country From tblPerson

-- flirting with where clause
Select * From tblPerson Where Country = 'Palestine'
Select * From tblPerson Where Country != 'Palestine'
Select * From tblPerson Where Country <> 'Palestine'

-- Wild Cards in SQL Server
Select * From tblPerson Where Age = 25 or Age = 30
Select * From tblPerson Where Age In(25,30) -- IN: Specify a list of values
Select * From tblPerson Where Age Between 20 and 30 -- Between: Specify a range
Select * From tblPerson Where Country like 'P%' -- LIKE: Specify a pattern
Select * From tblPerson Where Email like '%@%' -- %: Specifies zero or more characters
Select * From tblPerson Where Email not like '%@%' -- Not: Not in a list, range etc...
Select * From tblPerson Where Email like '_@%' -- _: Specifies exactly one character
Select * From tblPerson Where name like '[MST]%' -- []: Any character with in the brackets
Select * From tblPerson Where name like '[^MST]%' -- [^]: Not any character with in the brackets

-- Joining multiple conditions using AND and OR operators
Select * From tblPerson Where (Country = 'Palestine' or Country = 'PS') and Age >= 25

-- Sorting rows using order by
Select * From tblPerson Order By Name -- default ascending order
Select * From tblPerson Order By Name desc
Select * From tblPerson Order By Name desc, Age Asc

-- Selecting top n or top n percentage of rows
Select Top 2 * From tblPerson
Select Top 1 Percent * From tblPerson 
Select Top 50 Percent * From tblPerson
Select Top 1 Percent * From tblPerson Order By Age desc