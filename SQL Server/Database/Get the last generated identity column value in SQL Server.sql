-- • Retrieving Identity Column values

Create Table Test1
(
ID int identity(1,1),
Value nvarchar(20)
)

Create Table Test2
(
ID int identity(1,1),
Value nvarchar(20)
)

Insert Into Test1 Values('x')
Insert Into Test1 Values('z')
Insert Into Test2 Values('zzz')

Select * From Test1
Select * From Test2

-- to retrieve the last identity value that is generated. 
-- The most common way is to use SCOPE_IDENTITY built in function.
-- Note: You can also use @@IDENTITY and IDENT_CURRENT('TableName')
-- Difference:
-- SCOPE_IDENTITY- Same session and the same scope.
-- @@IDENTITY - Same session and across any scope.
-- IDENT CURRENT(TableName') - Specific table across any session and any scope.
Select SCOPE_IDENTITY() -- last identity column value of the same session and the same scope
Select @@Identity -- last identity column value of the same session and across any scope.
Select IDENT_CURRENT('Test2') -- last identity column value of all session(any session and any scope)

-- CREATE TRIGGER [TriggerName]
-- ON [TableName]
-- [AFTER | INSTEAD OF] [INSERT | UPDATE | DELETE]
-- AS
-- BEGIN
	-- Code to be executed when the specified event occurs
-- END
Create Trigger trForInsert on Test1 for Insert
as
Begin
	Insert into Test2 Values('yyyy')
End