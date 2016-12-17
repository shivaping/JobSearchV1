CREATE TABLE [dbo].[User_Job_Details] (
    [User_Job_Id]        INT             NOT NULL,
    [User_Id]            INT             NOT NULL,
    [Resume_Title]       VARCHAR (50)    NOT NULL,
    [Resume_Description] VARCHAR (255)   NOT NULL,
    [Resume]             VARBINARY (MAX) NOT NULL,
    [Current_Location]   INT             NOT NULL,
    [Preferred_Location] VARCHAR (255)   NOT NULL,
    [Current_Role]       VARCHAR (255)   NOT NULL,
    [Dob]                SMALLDATETIME   NOT NULL,
    [Gender]             NCHAR (10)      NOT NULL,
    [Experience]         INT             NOT NULL,
    [Current_Ctc]        MONEY           NOT NULL,
    [Active]             BIT             NOT NULL,
    CONSTRAINT [Pk_User_Job_Details] PRIMARY KEY CLUSTERED ([User_Job_Id] ASC),
    CONSTRAINT [Fk_User_Job_Details_User] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([User_Id])
);

