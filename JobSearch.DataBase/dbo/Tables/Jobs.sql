CREATE TABLE [dbo].[Jobs] (
    [job_id]          INT           IDENTITY (1, 1) NOT NULL,
    [location]        VARCHAR (100) NULL,
    [jobtitle]        VARCHAR (100) NULL,
    [technology]      VARCHAR (100) NULL,
    [job_description] VARCHAR (MAX) NULL,
    [category]        VARCHAR (20)  NULL,
    [client]          VARCHAR (255) NULL,
    [experience]      VARCHAR (255) NULL,
    [generalskills]   VARCHAR (MAX) NULL,
    [technicalskills] VARCHAR (MAX) NULL,
    [About_Client]    VARCHAR (MAX) NULL,
    [positions]       INT           NULL,
    [IsActive]        BIT           CONSTRAINT [DF_Jobs_isActive] DEFAULT ((1)) NOT NULL,
    [referralamount]  VARCHAR (50)  NULL,
    [userid]          INT           NULL,
    [JobType]         INT           NULL,
    [PostedDate]      DATETIME      DEFAULT (getdate()) NULL,
    CONSTRAINT [primary key4] PRIMARY KEY CLUSTERED ([job_id] ASC)
);

