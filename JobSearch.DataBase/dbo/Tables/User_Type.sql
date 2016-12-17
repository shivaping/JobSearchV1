CREATE TABLE [dbo].[User_Type] (
    [User_Type_Id]          INT           NOT NULL,
    [User_Type_Name]        VARCHAR (100) NOT NULL,
    [User_Type_Description] VARCHAR (300) NOT NULL,
    [Created_Date]          DATETIME      CONSTRAINT [DF_User_Type_Created_Date] DEFAULT (getdate()) NOT NULL,
    [Updated_Date]          DATETIME      CONSTRAINT [DF_User_Type_Updated_Date] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [Pk_User_Type] PRIMARY KEY CLUSTERED ([User_Type_Id] ASC)
);

