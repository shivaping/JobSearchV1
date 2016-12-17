CREATE TABLE [dbo].[User_Detail] (
    [User_Detail_Id]  INT             NOT NULL,
    [User_Id]         INT             NOT NULL,
    [Address1]        VARBINARY (255) NOT NULL,
    [Address2]        VARCHAR (255)   NULL,
    [Description]     VARCHAR (255)   NULL,
    [City]            VARCHAR (50)    NOT NULL,
    [State_Id]        INT             NOT NULL,
    [Country_Id]      INT             NOT NULL,
    [Gender]          CHAR (10)       NULL,
    [Phone]           INT             NOT NULL,
    [Fax]             INT             NULL,
    [Email]           VARBINARY (100) NOT NULL,
    [Secondary_Email] VARCHAR (100)   NULL,
    [Website]         VARCHAR (255)   NULL,
    [Profile]         TEXT            NULL,
    [Married]         BIT             NULL,
    [Created_Date]    DATETIME        NOT NULL,
    [Updated_Date]    DATETIME        NOT NULL,
    CONSTRAINT [Pk_User_Details] PRIMARY KEY CLUSTERED ([User_Detail_Id] ASC),
    CONSTRAINT [Fk_User_User_Details] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([User_Id])
);

