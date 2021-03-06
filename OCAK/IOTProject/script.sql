USE [IOTProje]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassBranch] [nvarchar](10) NULL,
	[Status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationModules]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationModules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EducationID] [int] NULL,
	[ModuleID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Educations]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Educations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EducationName] [nvarchar](50) NULL,
	[EducationDescription] [text] NULL,
	[Status] [nvarchar](20) NULL,
	[TeacherID] [int] NULL,
	[Picture] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EducationID] [int] NULL,
	[TeacherID] [int] NULL,
	[ClassID] [int] NULL,
	[ExamName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Institutions]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institutions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InstitutionName] [nvarchar](50) NULL,
	[Status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modules]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModuleName] [nvarchar](50) NULL,
	[MinValue] [int] NULL,
	[MaxValue] [int] NULL,
	[ModuleDescription] [text] NULL,
	[Status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExamID] [int] NULL,
	[CorrectAnswer] [nvarchar](10) NULL,
	[Question] [text] NULL,
	[Pick1] [nvarchar](10) NULL,
	[Pick2] [nvarchar](10) NULL,
	[Pick3] [nvarchar](10) NULL,
	[Pick4] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentEducation]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentEducation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[EducationID] [int] NULL,
	[Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentModules]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentModules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NULL,
	[ModuleID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClassID] [int] NULL,
	[TeacherID] [int] NULL,
	[InstitutionID] [int] NULL,
	[UserName] [nvarchar](30) NULL,
	[Password] [nvarchar](50) NULL,
	[StudentName] [nvarchar](50) NULL,
	[StudentSurname] [nvarchar](50) NULL,
	[StudentPhone] [nvarchar](50) NULL,
	[StudentDescription] [text] NULL,
	[Status] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentValues]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentValues](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EducationID] [int] NULL,
	[StudentID] [int] NULL,
	[Value] [text] NULL,
 CONSTRAINT [PK_StudentValues] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherEducation]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherEducation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NULL,
	[EducationID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherModules]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherModules](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [int] NULL,
	[ModuleID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 28.12.2021 14:01:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InstitutionID] [int] NULL,
	[UserName] [nvarchar](30) NULL,
	[Password] [nvarchar](50) NULL,
	[TeacherName] [nvarchar](50) NULL,
	[TeacherSurname] [nvarchar](50) NULL,
	[TeacherPhone] [nvarchar](15) NULL,
	[TeacherDescription] [text] NULL,
	[Status] [nvarchar](20) NULL,
	[Picture] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Educations] ON 

INSERT [dbo].[Educations] ([ID], [EducationName], [EducationDescription], [Status], [TeacherID], [Picture]) VALUES (1, N'Eğitim 1 Adı', N'Elektronik Bilmem ne modülleri eğitimi burada', N'Aktif', 3, N'1.jpg')
INSERT [dbo].[Educations] ([ID], [EducationName], [EducationDescription], [Status], [TeacherID], [Picture]) VALUES (2, N'Eğitim 2 Adı', N'Elektronik Bilmem ne modülleri eğitimi burada', N'Aktif', 1, N'2.png')
INSERT [dbo].[Educations] ([ID], [EducationName], [EducationDescription], [Status], [TeacherID], [Picture]) VALUES (3, N'Eğitim 3 Adı', N'Elektronik Bilmem ne modülleri eğitimi burada', N'Aktif', 2, N'3.jpg')
INSERT [dbo].[Educations] ([ID], [EducationName], [EducationDescription], [Status], [TeacherID], [Picture]) VALUES (4, N'Eğitim 4 Adı', N'Elektronik Bilmem ne modülleri eğitimi burada', N'Aktif', 2, N'2.png')
INSERT [dbo].[Educations] ([ID], [EducationName], [EducationDescription], [Status], [TeacherID], [Picture]) VALUES (5, N'Eğitim 5 Adı', N'Elektronik Bilmem ne modülleri eğitimi burada', N'Aktif', 1, N'1.jpg')
INSERT [dbo].[Educations] ([ID], [EducationName], [EducationDescription], [Status], [TeacherID], [Picture]) VALUES (6, N'Eğitim 6 Adı', N'EOnur merak etmiş anlamadı zaar', N'Aktif', 3, N'3.jpg')
SET IDENTITY_INSERT [dbo].[Educations] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentEducation] ON 

INSERT [dbo].[StudentEducation] ([ID], [StudentID], [EducationID], [Status]) VALUES (1, 1, 1, N'Pasif')
INSERT [dbo].[StudentEducation] ([ID], [StudentID], [EducationID], [Status]) VALUES (2, 2, 1, N'Aktif')
INSERT [dbo].[StudentEducation] ([ID], [StudentID], [EducationID], [Status]) VALUES (3, 1, 2, N'Pasif')
INSERT [dbo].[StudentEducation] ([ID], [StudentID], [EducationID], [Status]) VALUES (4, 1, 3, N'Pasif')
INSERT [dbo].[StudentEducation] ([ID], [StudentID], [EducationID], [Status]) VALUES (5, 1, 1, N'Aktif')
INSERT [dbo].[StudentEducation] ([ID], [StudentID], [EducationID], [Status]) VALUES (6, 1, 2, N'Aktif')
INSERT [dbo].[StudentEducation] ([ID], [StudentID], [EducationID], [Status]) VALUES (7, 2, 2, N'Aktif')
SET IDENTITY_INSERT [dbo].[StudentEducation] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [ClassID], [TeacherID], [InstitutionID], [UserName], [Password], [StudentName], [StudentSurname], [StudentPhone], [StudentDescription], [Status]) VALUES (1, 1, 1, 1, N'bozturk43', N'123456', N'Burak', N'Öztürk', N'+905426453314', N'Açıklama', N'Aktif')
INSERT [dbo].[Students] ([ID], [ClassID], [TeacherID], [InstitutionID], [UserName], [Password], [StudentName], [StudentSurname], [StudentPhone], [StudentDescription], [Status]) VALUES (2, 1, 2, 1, N'username1', N'123', N'User', N'Name', N'+905865966859', N'Açıklama', N'Aktif')
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentValues] ON 

INSERT [dbo].[StudentValues] ([ID], [EducationID], [StudentID], [Value]) VALUES (1, 2, 1, NULL)
INSERT [dbo].[StudentValues] ([ID], [EducationID], [StudentID], [Value]) VALUES (2, 2, 2, NULL)
SET IDENTITY_INSERT [dbo].[StudentValues] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([ID], [InstitutionID], [UserName], [Password], [TeacherName], [TeacherSurname], [TeacherPhone], [TeacherDescription], [Status], [Picture]) VALUES (1, NULL, N'ogr1', N'123', N'Öğretmen Adı 1', N'Öğretmen SoyAdı 1', NULL, N'Bu alan ögretmenle ilgili açıklamalar eklenecek ve burada görüntülenecek', N'Aktif', N'egtmn1.jpg')
INSERT [dbo].[Teachers] ([ID], [InstitutionID], [UserName], [Password], [TeacherName], [TeacherSurname], [TeacherPhone], [TeacherDescription], [Status], [Picture]) VALUES (2, NULL, NULL, NULL, N'Öğretmen Adı 2', N'Öğretmen SoyAdı 2', NULL, N'Bu alan ögretmenle ilgili açıklamalar eklenecek ve burada görüntülenecek', N'Aktif', N'egtmn3.jpg')
INSERT [dbo].[Teachers] ([ID], [InstitutionID], [UserName], [Password], [TeacherName], [TeacherSurname], [TeacherPhone], [TeacherDescription], [Status], [Picture]) VALUES (3, NULL, NULL, NULL, N'Öğretmen Adı 3', N'Öğretmen SoyAdı 3', NULL, N'Bu alan ögretmenle ilgili açıklamalar eklenecek ve burada görüntülenecek', NULL, N'egtmn2.jpg')
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
