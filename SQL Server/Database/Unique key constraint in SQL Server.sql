-- Unique key constraint

Select * From tblPerson

-- We use UNIQUE constraint to enforce uniqueness of a column i.e 
-- the column shouldn't allow any duplicate values. 
-- We can add a Unique constraint thru the designer or using a query
-- To create the unique key using a query:
-- Alter Table Table_Name
-- Add Constraint Constraint Name Unique (Column Name)
Alter Table tblPerson
add Constraint UQ_tblPerson_Email Unique(Email)

Insert Into tblPerson Values(9,'Jhon','J@J.com',1,'PS',30)

Alter Table tblPerson
drop Constraint UQ_tblPerson_Email

-- Bot primary key and unique key are used to enforce, the uniqueness of a column. So,
-- when do you choose one over the other?
-- A table can have, only one primary key. If you want to enforce uniqueness on 2 or more
-- columns, then we use unique key constraint.

-- What is the difference between Primary key constraint and Unique key constraint?
-- 1. A table can have only one primary key, but more than one unique key
-- 2. Primary key does not allow nulls, where as unique key allows one null