-- system databases Responsible for executing tasks assigned to the SQL Server

 -- to create a new user define database
 -- Create Database DatabaseName
Create Database Sample3

-- to change name of the database
-- Alter Database [DatabaseName] Modify Name = NewDatabaseName
Alter database [Sample3] Modify Name = TestDatabase 

-- Alternatively, you can also use system stored procedure
--  sp_renameDB 'OldDatabaseName', 'NewDatabaseName'
-- to change name of the database
Execute sp_renameDB 'Sample2','test2' 

-- deleting or dropping a database, deletes the logical file (LDF and MDF files) 
Drop Database testdatabase

-- You cannot drop a database if its currently use.
-- if other users are connected, you need to put the database in single user mode and then drop the database
-- Alter Database DatabaseName Set SINGLE_USER With Rollback Immediate
-- With Rollback Immediate option, will rollback all incomplete transactions and closes the connection to the database
-- or you can do it with the GUI 

-- System databases cannot be dropped (close existing connections)