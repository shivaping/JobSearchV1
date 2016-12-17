CREATE TABLE [dbo].[User] (
    [User_Id]      INT             NOT NULL,
    [User_Type_Id] INT             NOT NULL,
    [Username]     VARCHAR (100)   NOT NULL,
    [Password]     VARBINARY (300) NOT NULL,
    [Created_Date] DATETIME        NOT NULL,
    [Updated_Date] DATETIME        NOT NULL,
    CONSTRAINT [Pk_User] PRIMARY KEY CLUSTERED ([User_Id] ASC),
    CONSTRAINT [Fk_User_User_Type] FOREIGN KEY ([User_Type_Id]) REFERENCES [dbo].[User_Type] ([User_Type_Id])
);

