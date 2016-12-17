CREATE TABLE [dbo].[User_Jobs] (
    [User_Job_Id]         INT      NOT NULL,
    [Employer_Posting_Id] INT      NOT NULL,
    [Created_Date]        DATETIME NOT NULL,
    CONSTRAINT [Pk_User_Jobs] PRIMARY KEY CLUSTERED ([User_Job_Id] ASC),
    CONSTRAINT [Fk_User_Jobs_Employer_Posting] FOREIGN KEY ([Employer_Posting_Id]) REFERENCES [dbo].[Employer_Posting] ([Employer_Posting_Id])
);

