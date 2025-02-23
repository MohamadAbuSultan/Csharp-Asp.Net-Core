Select * From tblGender
Select * From tblPerson

Delete From tblGender Where ID = 1

-- Cascading referential integrity constraint allows to define 
-- the actions Microsoft Sql Server should take when a user attempts
-- to delete or update a key to which an existing foreign keys points
-- ex: if you delete row with ID=1 fromt tblGender table, 
-- then row with ID=3 from tblPerson table becomes an orphan record
-- You will not be able to tell the Gender for this row
-- So, Cascading referential integrity constraint can be used to 
-- define actions Microsoft SQL Server should take when this happens
-- By default, we get an error and the DELETE or UPDATE statement is rolled back

-- Options when setting up Cascading referential integrity constraint:
-- 1. No Action: This is the default behaviour. No Action specifies that if an attempt
-- is made to delete or update a row with a key referenced by foreign keys in existing rows in other tables,
-- an erroris raised and the DELETE or UPDATE is rolled back.

-- 2. Cascade: Specifies that if an attempt is made to delete or update a row
-- with a key referenced by foreign keys in existing rows in other tables,
-- all rows containing those foreign keys are also deleted or updated.

-- 3. Set NULL:Specifies that if an attempt is made to delete or update a row with a key referenced
-- by foreign keys in existing rows in other tables, all rows containing those foreign keys are set to NULL.

-- 4. Set Default: Specifies that if an attempt is made to delete or update a row with a key referenced
-- by foreign keys in existing rows in other tables, all rows containing those foreign keys are set to default values.