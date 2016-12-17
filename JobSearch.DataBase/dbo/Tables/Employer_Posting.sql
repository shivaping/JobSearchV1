CREATE TABLE [dbo].[Employer_Posting] (
    [Employer_Posting_Id]      INT           NOT NULL,
    [User_Id]                  INT           NOT NULL,
    [Employer_Posting_Type_Id] INT           NOT NULL,
    [Contact_Person]           VARCHAR (255) NOT NULL,
    [Title]                    VARCHAR (255) NOT NULL,
    [Department]               VARCHAR (50)  NOT NULL,
    [Jobcode]                  VARCHAR (50)  NOT NULL,
    [City]                     VARCHAR (50)  NOT NULL,
    [State_Id]                 INT           NOT NULL,
    [Country_Id]               INT           NOT NULL,
    [Education_Levelid]        INT           NOT NULL,
    [Job_Type_Id]              INT           NOT NULL,
    [Min_Salary]               MONEY         NULL,
    [Max_Salary]               MONEY         NULL,
    [Job_Description]          TEXT          NOT NULL,
    [Posting_Date]             SMALLDATETIME NOT NULL,
    [Posted_By]                VARCHAR (50)  NOT NULL,
    CONSTRAINT [Pk_Employer_Posting] PRIMARY KEY CLUSTERED ([Employer_Posting_Id] ASC),
    CONSTRAINT [Fk_Employer_Posting_Type] FOREIGN KEY ([Employer_Posting_Type_Id]) REFERENCES [dbo].[Employer_Posting_Type] ([Employer_Posting_Type_Id]),
    CONSTRAINT [Fk_Employer_Posting_User] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([User_Id])
);

