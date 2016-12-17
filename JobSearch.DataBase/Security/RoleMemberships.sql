ALTER ROLE [db_owner] ADD MEMBER [Poratluser];


GO

ALTER ROLE [db_owner] ADD MEMBER [pu];


GO

ALTER ROLE [db_ddladmin] ADD MEMBER [pu];


GO
ALTER ROLE [db_datareader] ADD MEMBER [Poratluser];


GO

ALTER ROLE [db_datareader] ADD MEMBER [pu];


GO
ALTER ROLE [db_datawriter] ADD MEMBER [Poratluser];


GO

ALTER ROLE [db_datawriter] ADD MEMBER [pu];

