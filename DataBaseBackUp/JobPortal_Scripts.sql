USE [JobPortal]
GO
/****** Object:  Table [dbo].[EmployerPosting]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployerPosting](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PostingTypeID] [int] NOT NULL,
	[ContactPerson] [varchar](255) NOT NULL,
	[Title] [varchar](255) NOT NULL,
	[Department] [varchar](50) NOT NULL,
	[Jobcode] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [int] NOT NULL,
	[Country] [int] NOT NULL,
	[Education_LevelID] [int] NOT NULL,
	[JobTypeId] [int] NOT NULL,
	[MinSalary] [money] NULL,
	[MaxSalary] [money] NULL,
	[JobDescription] [text] NOT NULL,
	[PostingDate] [smalldatetime] NOT NULL,
	[PostedBy] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_EmployerPosting] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jobs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Location] [varchar](100) NULL,
	[JobTitle] [varchar](100) NULL,
	[Technology] [varchar](100) NULL,
	[JobDescription] [varchar](max) NULL,
	[Category] [varchar](20) NULL,
	[Client] [varchar](255) NOT NULL,
	[Experience] [varchar](255) NULL,
	[GeneralSkills] [varchar](max) NULL,
	[TechnicalSkills] [varchar](max) NULL,
	[AboutClient] [varchar](max) NOT NULL,
	[Positions] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[ReferralAmount] [varchar](50) NULL,
	[CreatedBy] [nvarchar](128) NOT NULL,
	[JobType] [int] NULL,
	[PostedDate] [datetime] NULL,
 CONSTRAINT [primary key4] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobType]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JobType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [Pk_Employer_Posting_Type] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Skill]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Skill](
	[ID] [int] NOT NULL,
	[SkillName] [varchar](100) NOT NULL,
	[SkillDescription] [varchar](255) NOT NULL,
 CONSTRAINT [Pk_Skill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserDetail]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](128) NULL,
	[Address1] [varbinary](255) NOT NULL,
	[Address2] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
	[City] [varchar](50) NOT NULL,
	[State] [int] NOT NULL,
	[Country] [int] NOT NULL,
	[Gender] [char](10) NULL,
	[Phone] [int] NOT NULL,
	[Fax] [int] NULL,
	[Email] [varbinary](100) NOT NULL,
	[Secondary_Email] [varchar](100) NULL,
	[Website] [varchar](255) NULL,
	[Profile] [text] NULL,
	[Married] [bit] NULL,
	[Created_Date] [datetime] NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
 CONSTRAINT [PK_UserDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserEducation]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserEducation](
	[User_Education_Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](128) NOT NULL,
	[Qualification] [varchar](50) NOT NULL,
	[Specialization] [varchar](50) NOT NULL,
	[Institute] [varchar](50) NOT NULL,
	[Year] [int] NOT NULL,
 CONSTRAINT [Pk_User_Education] PRIMARY KEY CLUSTERED 
(
	[User_Education_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserJobs]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserJobs](
	[UserJobId] [int] IDENTITY(1,1) NOT NULL,
	[PostingID] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UserID] [nvarchar](128) NOT NULL,
	[ApplyDate] [datetime] NULL,
	[Status] [int] NULL,
	[ResumeID] [int] NOT NULL,
	[NoticePeriod] [int] NULL,
	[CurrentCTC] [varchar](20) NULL,
	[ExpectedCTC] [varchar](20) NULL,
	[UserExp] [varchar](20) NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [PK_UserJobs] PRIMARY KEY CLUSTERED 
(
	[UserJobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserResume]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserResume](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](128) NOT NULL,
	[ResumeTitle] [varchar](50) NOT NULL,
	[ResumeDescription] [varchar](255) NOT NULL,
	[Resume] [varbinary](max) NOT NULL,
	[CurrentLocation] [int] NOT NULL,
	[PreferredLocation] [varchar](255) NOT NULL,
	[CurrentRole] [varchar](255) NOT NULL,
	[Dob] [smalldatetime] NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[Experience] [int] NOT NULL,
	[CurrentCtc] [money] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [Pk_User_Job_Details] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserSkill]    Script Date: 18-Dec-16 5:00:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSkill](
	[ID] [int] NOT NULL,
	[UserID] [nvarchar](128) NOT NULL,
	[SkillID] [int] NOT NULL,
 CONSTRAINT [PK_UserSkill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Jobs] ADD  CONSTRAINT [DF_Jobs_isActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Jobs] ADD  CONSTRAINT [DF__Jobs__PostedDate__72C60C4A]  DEFAULT (getdate()) FOR [PostedDate]
GO
ALTER TABLE [dbo].[Jobs]  WITH CHECK ADD  CONSTRAINT [FK_Jobs_JobType] FOREIGN KEY([JobType])
REFERENCES [dbo].[JobType] ([ID])
GO
ALTER TABLE [dbo].[Jobs] CHECK CONSTRAINT [FK_Jobs_JobType]
GO
ALTER TABLE [dbo].[UserJobs]  WITH CHECK ADD  CONSTRAINT [FK_UserJobs_Jobs] FOREIGN KEY([UserJobId])
REFERENCES [dbo].[Jobs] ([ID])
GO
ALTER TABLE [dbo].[UserJobs] CHECK CONSTRAINT [FK_UserJobs_Jobs]
GO
ALTER TABLE [dbo].[UserJobs]  WITH CHECK ADD  CONSTRAINT [FK_UserJobs_UserResume] FOREIGN KEY([ResumeID])
REFERENCES [dbo].[UserResume] ([ID])
GO
ALTER TABLE [dbo].[UserJobs] CHECK CONSTRAINT [FK_UserJobs_UserResume]
GO
ALTER TABLE [dbo].[UserSkill]  WITH CHECK ADD  CONSTRAINT [FK_UserSkill_Skill] FOREIGN KEY([ID])
REFERENCES [dbo].[Skill] ([ID])
GO
ALTER TABLE [dbo].[UserSkill] CHECK CONSTRAINT [FK_UserSkill_Skill]
GO
