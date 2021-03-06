USE [JobPortal]
GO
/****** Object:  User [Poratluser]    Script Date: 17-Dec-16 3:37:43 PM ******/
CREATE USER [Poratluser] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[Dbo]
GO
/****** Object:  User [portaluser]    Script Date: 17-Dec-16 3:37:43 PM ******/
CREATE USER [portaluser] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [pu]    Script Date: 17-Dec-16 3:37:43 PM ******/
CREATE USER [pu] FOR LOGIN [pu] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Poratluser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Poratluser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Poratluser]
GO
ALTER ROLE [db_owner] ADD MEMBER [portaluser]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [portaluser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [portaluser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [portaluser]
GO
ALTER ROLE [db_owner] ADD MEMBER [pu]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [pu]
GO
ALTER ROLE [db_datareader] ADD MEMBER [pu]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [pu]
GO
/****** Object:  Table [dbo].[EmployerPosting]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployerPosting](
	[Employer_Posting_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
	[Employer_Posting_Type_Id] [int] NOT NULL,
	[Contact_Person] [varchar](255) NOT NULL,
	[Title] [varchar](255) NOT NULL,
	[Department] [varchar](50) NOT NULL,
	[Jobcode] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State_Id] [int] NOT NULL,
	[Country_Id] [int] NOT NULL,
	[Education_Levelid] [int] NOT NULL,
	[Job_Type_Id] [int] NOT NULL,
	[Min_Salary] [money] NULL,
	[Max_Salary] [money] NULL,
	[Job_Description] [text] NOT NULL,
	[Posting_Date] [smalldatetime] NOT NULL,
	[Posted_By] [varchar](50) NOT NULL,
 CONSTRAINT [Pk_Employer_Posting] PRIMARY KEY CLUSTERED 
(
	[Employer_Posting_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployerPostingType]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployerPostingType](
	[Employer_Posting_Type_Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [Pk_Employer_Posting_Type] PRIMARY KEY CLUSTERED 
(
	[Employer_Posting_Type_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jobs](
	[job_id] [int] IDENTITY(1,1) NOT NULL,
	[location] [varchar](100) NULL,
	[jobtitle] [varchar](100) NULL,
	[technology] [varchar](100) NULL,
	[job_description] [varchar](max) NULL,
	[category] [varchar](20) NULL,
	[client] [varchar](255) NULL,
	[experience] [varchar](255) NULL,
	[generalskills] [varchar](max) NULL,
	[technicalskills] [varchar](max) NULL,
	[About_Client] [varchar](max) NULL,
	[positions] [int] NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_Jobs_isActive]  DEFAULT ((1)),
	[referralamount] [varchar](50) NULL,
	[userid] [int] NULL,
	[JobType] [int] NULL,
	[PostedDate] [datetime] NULL DEFAULT (getdate()),
 CONSTRAINT [primary key4] PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Skill]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Skill](
	[Skill_Id] [int] NOT NULL,
	[Skill_Name] [varchar](100) NOT NULL,
	[Skill_Description] [varchar](255) NOT NULL,
 CONSTRAINT [Pk_Skill] PRIMARY KEY CLUSTERED 
(
	[Skill_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[User_Id] [int] NOT NULL,
	[User_Type_Id] [int] NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[Password] [varbinary](300) NOT NULL,
	[Created_Date] [datetime] NOT NULL,
	[Updated_Date] [datetime] NOT NULL,
 CONSTRAINT [Pk_User] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_Detail]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Detail](
	[User_Detail_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
	[Address1] [varbinary](255) NOT NULL,
	[Address2] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
	[City] [varchar](50) NOT NULL,
	[State_Id] [int] NOT NULL,
	[Country_Id] [int] NOT NULL,
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
 CONSTRAINT [Pk_User_Details] PRIMARY KEY CLUSTERED 
(
	[User_Detail_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_Education]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Education](
	[User_Education_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
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
/****** Object:  Table [dbo].[User_Job_Details]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Job_Details](
	[User_Job_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
	[Resume_Title] [varchar](50) NOT NULL,
	[Resume_Description] [varchar](255) NOT NULL,
	[Resume] [varbinary](max) NOT NULL,
	[Current_Location] [int] NOT NULL,
	[Preferred_Location] [varchar](255) NOT NULL,
	[Current_Role] [varchar](255) NOT NULL,
	[Dob] [smalldatetime] NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[Experience] [int] NOT NULL,
	[Current_Ctc] [money] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [Pk_User_Job_Details] PRIMARY KEY CLUSTERED 
(
	[User_Job_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_Jobs]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Jobs](
	[User_Job_Id] [int] NOT NULL,
	[Employer_Posting_Id] [int] NOT NULL,
	[Created_Date] [datetime] NOT NULL,
 CONSTRAINT [Pk_User_Jobs] PRIMARY KEY CLUSTERED 
(
	[User_Job_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_Skill]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Skill](
	[User_Skill_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
	[Skill_Id] [int] NOT NULL,
 CONSTRAINT [Pk_User_Skill] PRIMARY KEY CLUSTERED 
(
	[User_Skill_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_Type]    Script Date: 17-Dec-16 3:37:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User_Type](
	[User_Type_Id] [int] NOT NULL,
	[User_Type_Name] [varchar](100) NOT NULL,
	[User_Type_Description] [varchar](300) NOT NULL,
	[Created_Date] [datetime] NOT NULL CONSTRAINT [DF_User_Type_Created_Date]  DEFAULT (getdate()),
	[Updated_Date] [datetime] NOT NULL CONSTRAINT [DF_User_Type_Updated_Date]  DEFAULT (getdate()),
 CONSTRAINT [Pk_User_Type] PRIMARY KEY CLUSTERED 
(
	[User_Type_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[EmployerPosting]  WITH CHECK ADD  CONSTRAINT [Fk_Employer_Posting_Type] FOREIGN KEY([Employer_Posting_Type_Id])
REFERENCES [dbo].[EmployerPostingType] ([Employer_Posting_Type_Id])
GO
ALTER TABLE [dbo].[EmployerPosting] CHECK CONSTRAINT [Fk_Employer_Posting_Type]
GO
ALTER TABLE [dbo].[EmployerPosting]  WITH CHECK ADD  CONSTRAINT [Fk_Employer_Posting_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[EmployerPosting] CHECK CONSTRAINT [Fk_Employer_Posting_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [Fk_User_User_Type] FOREIGN KEY([User_Type_Id])
REFERENCES [dbo].[User_Type] ([User_Type_Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [Fk_User_User_Type]
GO
ALTER TABLE [dbo].[User_Detail]  WITH CHECK ADD  CONSTRAINT [Fk_User_User_Details] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[User_Detail] CHECK CONSTRAINT [Fk_User_User_Details]
GO
ALTER TABLE [dbo].[User_Education]  WITH CHECK ADD  CONSTRAINT [Fk_User_Education_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[User_Education] CHECK CONSTRAINT [Fk_User_Education_User]
GO
ALTER TABLE [dbo].[User_Job_Details]  WITH CHECK ADD  CONSTRAINT [Fk_User_Job_Details_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[User_Job_Details] CHECK CONSTRAINT [Fk_User_Job_Details_User]
GO
ALTER TABLE [dbo].[User_Jobs]  WITH CHECK ADD  CONSTRAINT [Fk_User_Jobs_Employer_Posting] FOREIGN KEY([Employer_Posting_Id])
REFERENCES [dbo].[EmployerPosting] ([Employer_Posting_Id])
GO
ALTER TABLE [dbo].[User_Jobs] CHECK CONSTRAINT [Fk_User_Jobs_Employer_Posting]
GO
ALTER TABLE [dbo].[User_Skill]  WITH CHECK ADD  CONSTRAINT [Fk_User_Skill_Skill] FOREIGN KEY([Skill_Id])
REFERENCES [dbo].[Skill] ([Skill_Id])
GO
ALTER TABLE [dbo].[User_Skill] CHECK CONSTRAINT [Fk_User_Skill_Skill]
GO
ALTER TABLE [dbo].[User_Skill]  WITH CHECK ADD  CONSTRAINT [Fk_User_Skill_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[User] ([User_Id])
GO
ALTER TABLE [dbo].[User_Skill] CHECK CONSTRAINT [Fk_User_Skill_User]
GO
