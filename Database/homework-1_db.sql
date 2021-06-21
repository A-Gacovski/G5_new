
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[EnroledDate] [date] NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[NationalIdNumber] [int] NULL,
	[StudentCardNumber] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
))
GO

CREATE TABLE [dbo].[Teacher](
	[Id] [int] NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nchar](20) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[AcademicRank] [nvarchar](50) NOT NULL,
	[HireDate] [date] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
))
GO

CREATE TABLE [dbo].[Grade](
	[Id] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
	[TeacherId] [int] NOT NULL,
	[Grade] [smallint] NOT NULL,
	[Comment] [nvarchar](200) NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
))
GO

CREATE TABLE [dbo].[Grade Details](
	[Id] [int] NOT NULL,
	[GradeId] [int] NOT NULL,
	[AchievementTypeId] [int] NOT NULL,
	[AchievenmentPoints] [int] NOT NULL,
	[AchievenmentMaxPoints] [int] NOT NULL,
	[AchievenmentDate] [date] NULL,
 CONSTRAINT [PK_Grade Details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
))
GO

CREATE TABLE [dbo].[Cource](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Credit] [int] NOT NULL,
	[AcademicYear] [date] NOT NULL,
	[Semester] [smallint] NOT NULL,
 CONSTRAINT [PK_Cource] PRIMARY KEY CLUSTERED 
(
	[id] ASC
))
GO

CREATE TABLE [dbo].[AchievenmentType](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[ParticipationRate] [int] NULL,
 CONSTRAINT [PK_Achievenment Type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
))
GO
