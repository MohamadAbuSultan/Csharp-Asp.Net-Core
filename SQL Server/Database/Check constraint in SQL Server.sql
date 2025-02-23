Select * From tblPerson
Select * From tblGender

-- Check Constraint is used to limit the range of the values, that can be entered for a column

-- General Syntax for ALTER TABLE
-- ALTER TABLE table_name
-- ADD column_name column_type [constraints];
ALTER TABLE tblPerson
ADD Age INT;

-- General Syntax for UPDATE Statement
-- UPDATE table_name
-- SET column1 = value1, column2 = value2, ...
-- WHERE condition;  
UPDATE tblPerson
SET GenderID = 1 WHERE ID = 6;

-- General formula for adding check constraint in sql server
-- Alter Table {Table_Name}
-- ADD CONSTRAINT {Constraint_Name} CHECK (Boolean_Expression);
ALTER TABLE tblPerson
ADD CONSTRAINT chk_Age CHECK (Age >= 0 AND Age <= 120);

-- To drop the Check constraint:
-- Alter Table {Table_Name}
-- Drop Constraint {Table_Constraint_Name}
Alter Table tblPerson
Drop Constraint chk_Age

INSERT INTO tblPerson VALUES (6,'MohamadK','M@M.com',NULL,'PS', 25);

-- IF The Boolean_Expression returns true, then the Check constraint allows the value,
-- Otherwise it doesn't. Since, Age is a nullable column, it's possible to pass null for this column, when inserting a row
-- When you pass Null for the Age column, the boolean expression evaluates to Unknown, and allows the value