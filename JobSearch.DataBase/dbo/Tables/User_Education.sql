CREATE TABLE [dbo].[User_Education] (
    [User_Education_Id] INT          NOT NULL,
    [User_Id]           INT          NOT NULL,
    [Qualification]     VARCHAR (50) NOT NULL,
    [Specialization]    VARCHAR (50) NOT NULL,
    [Institute]         VARCHAR (50) NOT NULL,
    [Year]              INT          NOT NULL,
    CONSTRAINT [Pk_User_Education] PRIMARY KEY CLUSTERED ([User_Education_Id] ASC),
    CONSTRAINT [Fk_User_Education_User] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([User_Id])
);

