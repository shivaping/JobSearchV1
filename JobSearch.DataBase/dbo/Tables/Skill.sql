CREATE TABLE [dbo].[Skill] (
    [Skill_Id]          INT           NOT NULL,
    [Skill_Name]        VARCHAR (100) NOT NULL,
    [Skill_Description] VARCHAR (255) NOT NULL,
    CONSTRAINT [Pk_Skill] PRIMARY KEY CLUSTERED ([Skill_Id] ASC)
);

