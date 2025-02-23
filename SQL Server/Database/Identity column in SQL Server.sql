Select * From tblPerson1

-- Drop the primary key constraint
ALTER TABLE tblPerson1 DROP CONSTRAINT PK_tblPerson1;

-- Drop the columns
ALTER TABLE tblPerson1 DROP COLUMN ID;
ALTER TABLE tblPerson1 DROP COLUMN Name;

-- Check Constraint
-- If a column is marked as an identity column, then the values for this column are
-- automatically generated, when you insert a new row into the table.
-- Create Table tblPerson ( PersonId int Identity(1,1) Primary Key, Name navrchar(20) )
-- Recreate the 'ID' column with the identity property
ALTER TABLE tblPerson1 ADD ID INT IDENTITY(1,1) PRIMARY KEY;
-- Note: Seed and Increment values are optional. If you don't specify the identity and seed they both default to 1

-- Recreate the 'Name' column if necessary
ALTER TABLE tblPerson1 ADD Name VARCHAR(50); -- Adjust the data type and length accordingly

Insert Into tblPerson1 (Name) Values('Mohamad')
Insert Into tblPerson1 (Name) Values('Khaled')
Insert Into tblPerson1 (Name) Values('Mays')
Insert Into tblPerson1 (Name) Values('Anmar')
Insert Into tblPerson1 (Name) Values('Marah')
Insert Into tblPerson1 (Name) Values('Sarah')

UPDATE tblPerson1 SET Name = 'Unknown' WHERE Name IS NULL;

Delete From tblPerson1 -- delete all data

-- To explicitly supply a value for identity column
-- 1. First turn on identity insert - SET Identity_Insert tblPerson ON
-- 2. In the insert query specify the column list
-- Insert into tblPerson(Personid, Name) values(2, 'John')

Set IDENTITY_INSERT tblPerson1 OFF

Set IDENTITY_INSERT tblPerson1 ON

-- If you have deleted all the rows in a table, and you want to reset the identity column value,
-- use DBCC CHECKIDENT command.
-- DBCC CHECKIDENT('tblPerson', RESEED, 0)
DBCC checkIdent(tblPerson1,Reseed,0) 