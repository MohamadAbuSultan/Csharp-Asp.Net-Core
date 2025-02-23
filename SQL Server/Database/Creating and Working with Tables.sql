-- to use a database
use [DemoDB]
Go

-- to create database table (Creating tables)
-- in sql server, tables can be created graphically using sql server management studio(ssms)
Create table tblGender
(
 ID int NOT NULL Primary Key,
 Gender nvarchar(50)
)


-- Enforcing primary key and foreign key constraints
-- integrity data
-- Foreign key references can be added graphically using SSMS
-- Alter table ForeginKeyTable 
-- add constriant ForeignKeyTable_ForiegnKeyColumn_FK FOREIGN KEY (ForiegnKeyColumn) references PrimaryKeyTable (PrimaryKeyColumn)
Alter table tblPerson
add constraint tblPerson_GenderID_FK FOREIGN KEY (GenderID) references tblGender(ID)
-- Foreign keys are used to enforce database integrity.
-- In layman's terms, A foreign key in one table points to a primary key in another table.
-- The foreign key constraint prevents invalid data form being inserted into the foreign key column.
-- The values that you enter into the foreign key column, has to be one of the values contained in the table it points to.