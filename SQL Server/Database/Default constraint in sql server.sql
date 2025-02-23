Select * From tblGender
Select * From tblPerson

Insert into tblPerson (ID,Name,Email,GenderID) Values(5,'Sara','S@S.com',2)
-- to insert NULL, instead of using the default
Insert into tblPerson (ID,Name,Email,GenderID) Values(6,'Moh','M@M.com',NULL)
-- The insert statement below does not provide a value for GenderId column
Insert into tblPerson (ID,Name,Email) Values(7,'Sara','S@S.com')

-- to add a default constraint
-- ALTER TABLE {TABLE_NAME} ADD CONSTRAINT {CONSTRAINT_NAME} DEFAULT {DEFAULT_VALUE} FOR {EXITING_COLUMN_NAME}
ALTER TABLE tblPerson ADD CONSTRAINT DF_tblPerson_GenderId
DEFAULT 3 FOR GenderId

-- to add a new column with default value to an existing table
-- ALTER TABLE {TABLE_NAME} ADD {COLUMN_NAME} {DATA_TYPE} {NULL} CONSTRAINT {CONSTRAINT_NAME} DEFAULT {DEFAULT_VALUE}
ALTER TABLE tblPerson
ADD Country VARCHAR(50) NULL CONSTRAINT DF_tblPerson_Country DEFAULT 'Unknown';
ALTER TABLE tblPerson
DROP COLUMN Country

-- to add a new column with default value to an existing table
-- ALTER TABLE {TABLE_NAME} ADD {COLUMN_NAME} {DATA_TYPE} {NOT NULL} CONSTRAINT {CONSTRAINT_NAME} DEFAULT {DEFAULT_VALUE}
ALTER TABLE tblPerson
ADD Country VARCHAR(50) NOT NULL CONSTRAINT DF_tblPerson_Country DEFAULT 'Palestine';


-- To drop a constraint
-- ALTER TABLE {TABLE_NAME} DROP CONSTRAINT {CONSTRAINT_NAME}
ALTER TABLE tblPerson DROP CONSTRAINT DF_tblPerson_GenderId

-- A column default can be specified using Default constraint.
-- The DEFAULT constraint is used to insert a default value into a column
-- The default value will be add to all new records, if no other value is specified, including NULL