CREATE TABLE [dbo].[Employer_Posting_Type] (
    [Employer_Posting_Type_Id] INT          NOT NULL,
    [Name]                     VARCHAR (50) NOT NULL,
    [Description]              VARCHAR (50) NOT NULL,
    CONSTRAINT [Pk_Employer_Posting_Type] PRIMARY KEY CLUSTERED ([Employer_Posting_Type_Id] ASC)
);

