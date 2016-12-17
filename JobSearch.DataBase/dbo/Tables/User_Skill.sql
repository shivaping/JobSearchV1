CREATE TABLE [dbo].[User_Skill] (
    [User_Skill_Id] INT NOT NULL,
    [User_Id]       INT NOT NULL,
    [Skill_Id]      INT NOT NULL,
    CONSTRAINT [Pk_User_Skill] PRIMARY KEY CLUSTERED ([User_Skill_Id] ASC),
    CONSTRAINT [Fk_User_Skill_Skill] FOREIGN KEY ([Skill_Id]) REFERENCES [dbo].[Skill] ([Skill_Id]),
    CONSTRAINT [Fk_User_Skill_User] FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([User_Id])
);

