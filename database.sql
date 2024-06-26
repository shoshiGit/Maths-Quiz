USE [Maths Test C#]
GO
/****** Object:  Table [dbo].[History]    Script Date: 04/04/2024 18:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[UserId] [int] NULL,
	[TestDate] [varchar](50) NULL,
	[Mark] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Multiple_Choice_A]    Script Date: 04/04/2024 18:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multiple_Choice_A](
	[Answer_Id] [int] NOT NULL,
	[Answer] [int] NULL,
	[Question_Id] [int] NULL,
	[Percent] [int] NULL,
 CONSTRAINT [PK_Answers_Tbl] PRIMARY KEY CLUSTERED 
(
	[Answer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Multiple_Choice_Q]    Script Date: 04/04/2024 18:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multiple_Choice_Q](
	[Question_Id] [int] NOT NULL,
	[Question] [varchar](50) NULL,
	[Correct_Ans] [int] NULL,
	[Percent] [int] NULL,
 CONSTRAINT [PK_Multiple_Choice_Q] PRIMARY KEY CLUSTERED 
(
	[Question_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MyHistory]    Script Date: 04/04/2024 18:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyHistory](
	[UserId] [int] NOT NULL,
	[TestDate] [datetime] NULL,
	[Mark] [int] NULL,
 CONSTRAINT [PK_MyHistory] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question&Ans1]    Script Date: 04/04/2024 18:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question&Ans1](
	[Question_Id] [int] NOT NULL,
	[Question] [varchar](50) NULL,
	[Answer] [int] NULL,
	[Percentage] [int] NULL,
 CONSTRAINT [PK_Question&Ans1] PRIMARY KEY CLUSTERED 
(
	[Question_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 04/04/2024 18:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Student_Id] [int] NOT NULL,
	[Student_name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Student_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_MyHistory_Students] FOREIGN KEY([UserId])
REFERENCES [dbo].[Students] ([Student_Id])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_MyHistory_Students]
GO
ALTER TABLE [dbo].[Multiple_Choice_A]  WITH CHECK ADD  CONSTRAINT [FK_Answers_Tbl_Multiple_Choice_Q] FOREIGN KEY([Question_Id])
REFERENCES [dbo].[Multiple_Choice_Q] ([Question_Id])
GO
ALTER TABLE [dbo].[Multiple_Choice_A] CHECK CONSTRAINT [FK_Answers_Tbl_Multiple_Choice_Q]
GO
