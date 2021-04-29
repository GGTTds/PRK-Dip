USE [master]
GO
/****** Object:  Database [SAD]    Script Date: 29.04.2021 13:46:20 ******/
CREATE DATABASE [SAD]
GO
ALTER DATABASE [SAD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SAD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SAD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SAD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SAD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SAD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SAD] SET ARITHABORT OFF 
GO
ALTER DATABASE [SAD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SAD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SAD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SAD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SAD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SAD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SAD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SAD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SAD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SAD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SAD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SAD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SAD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SAD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SAD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SAD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SAD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SAD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SAD] SET  MULTI_USER 
GO
ALTER DATABASE [SAD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SAD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SAD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SAD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SAD]
GO
/****** Object:  Table [dbo].[Child]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Child](
	[ID_Child] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [nvarchar](170) NULL,
	[Paren] [int] NULL,
	[Grp] [int] NULL,
	[DataBir] [datetime] NULL,
	[Adress] [nvarchar](150) NULL,
	[Event] [int] NULL,
	[DopZan] [int] NULL,
	[budjet] [nvarchar](250) NULL,
	[Jelih] [nvarchar](250) NULL,
	[Propis] [nvarchar](250) NULL,
 CONSTRAINT [PK_Child] PRIMARY KEY CLUSTERED 
(
	[ID_Child] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[ID_Event] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](120) NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[ID_Event] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[ID_Group] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Opis] [nvarchar](200) NULL,
	[Kurt] [int] NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[ID_Group] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parents]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parents](
	[ID_Parent] [int] IDENTITY(1,1) NOT NULL,
	[FIOMA] [nvarchar](150) NULL,
	[TelMA] [nvarchar](50) NULL,
	[FIOFAT] [nvarchar](150) NULL,
	[TelFAT] [nvarchar](50) NULL,
	[OtherTel] [nvarchar](50) NULL,
 CONSTRAINT [PK_Parents] PRIMARY KEY CLUSTERED 
(
	[ID_Parent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roul]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roul](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roul] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tich]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tich](
	[ID_Tich] [int] IDENTITY(1,1) NOT NULL,
	[FIOTic] [nvarchar](150) NULL,
	[Tel] [nvarchar](50) NULL,
	[GrpForChil] [int] NULL,
	[ToEvent] [int] NULL,
	[ToZant] [int] NULL,
	[login_Tic] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[Rol] [int] NULL,
	[Pari] [int] NULL,
 CONSTRAINT [PK_Tich_1] PRIMARY KEY CLUSTERED 
(
	[ID_Tich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zanat]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zanat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DenNed] [nvarchar](50) NULL,
	[Para1] [nvarchar](50) NULL,
	[Zam1] [nvarchar](250) NULL,
	[Para2] [nvarchar](50) NULL,
	[Zam2] [nvarchar](250) NULL,
	[Para3] [nvarchar](50) NULL,
	[Zam3] [nvarchar](250) NULL,
	[Para4] [nvarchar](50) NULL,
	[Zam4] [nvarchar](250) NULL,
	[Para5] [nvarchar](50) NULL,
	[Zam5] [nvarchar](250) NULL,
	[NomerUch] [int] NULL,
	[Kluc] [int] NULL,
 CONSTRAINT [PK_Zanat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zanztia]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zanztia](
	[ID_Zan] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Zanztia] PRIMARY KEY CLUSTERED 
(
	[ID_Zan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Child] ON 

INSERT [dbo].[Child] ([ID_Child], [FIO], [Paren], [Grp], [DataBir], [Adress], [Event], [DopZan], [budjet], [Jelih], [Propis]) VALUES (1, N'Мелякин Антон Антонович', 1, 1, CAST(N'2001-03-15T00:00:00.000' AS DateTime), N'г.Заречный ул Ленина 12а', 1, 1, N'Бюджет', N'', N'')
INSERT [dbo].[Child] ([ID_Child], [FIO], [Paren], [Grp], [DataBir], [Adress], [Event], [DopZan], [budjet], [Jelih], [Propis]) VALUES (3, N'Мелякин Игнат Антонович', 1, 1, CAST(N'2000-07-19T00:00:00.000' AS DateTime), N'awda', NULL, 4, N'Контракт', N'Сьемная квартира', N'Местная')
INSERT [dbo].[Child] ([ID_Child], [FIO], [Paren], [Grp], [DataBir], [Adress], [Event], [DopZan], [budjet], [Jelih], [Propis]) VALUES (10, N'Матвеев Антон Александрович', 5, 5, CAST(N'2010-10-15T00:00:00.000' AS DateTime), N'1233', 2, 3, N'Контракт', N'Общежитие', N'Не местная')
INSERT [dbo].[Child] ([ID_Child], [FIO], [Paren], [Grp], [DataBir], [Adress], [Event], [DopZan], [budjet], [Jelih], [Propis]) VALUES (12, N'Макеев Иван Иваныч', 5, 2, CAST(N'2021-03-30T00:00:00.000' AS DateTime), N'sdcsdc', 2, 3, N'Бюджет', N'Общежитие', N'Не местная')
SET IDENTITY_INSERT [dbo].[Child] OFF
GO
SET IDENTITY_INSERT [dbo].[Event] ON 

INSERT [dbo].[Event] ([ID_Event], [Name], [Date]) VALUES (1, N'Веселый утренник', CAST(N'2021-04-27T00:00:00.000' AS DateTime))
INSERT [dbo].[Event] ([ID_Event], [Name], [Date]) VALUES (2, N'Веселые страты', CAST(N'2021-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Event] ([ID_Event], [Name], [Date]) VALUES (3, N'Комната веселья', CAST(N'2021-04-29T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Event] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([ID_Group], [Name], [Opis], [Kurt]) VALUES (1, N'1a', N'Начальная группа', 2)
INSERT [dbo].[Group] ([ID_Group], [Name], [Opis], [Kurt]) VALUES (2, N'2a', NULL, 1)
INSERT [dbo].[Group] ([ID_Group], [Name], [Opis], [Kurt]) VALUES (3, N'3a', NULL, 2)
INSERT [dbo].[Group] ([ID_Group], [Name], [Opis], [Kurt]) VALUES (4, N'1с', NULL, 2)
INSERT [dbo].[Group] ([ID_Group], [Name], [Opis], [Kurt]) VALUES (5, N'2с', NULL, 3)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Parents] ON 

INSERT [dbo].[Parents] ([ID_Parent], [FIOMA], [TelMA], [FIOFAT], [TelFAT], [OtherTel]) VALUES (1, N'Мелякина Инна Сергеевна', N'+7 966 312-65-44', N'Мелякин Антон Викторович', N'+7 366 656-56-96', NULL)
INSERT [dbo].[Parents] ([ID_Parent], [FIOMA], [TelMA], [FIOFAT], [TelFAT], [OtherTel]) VALUES (5, N'Матвеева Анна Александровна', N'+7 912 633-44-88', N'Матвеев Игорь Николаевич', N'+7 912 633-44-77', N'+7 912 633-33-33')
SET IDENTITY_INSERT [dbo].[Parents] OFF
GO
SET IDENTITY_INSERT [dbo].[Roul] ON 

INSERT [dbo].[Roul] ([ID], [Name]) VALUES (1, N'Студент')
INSERT [dbo].[Roul] ([ID], [Name]) VALUES (2, N'Преподаватель')
INSERT [dbo].[Roul] ([ID], [Name]) VALUES (3, N'Администратор')
SET IDENTITY_INSERT [dbo].[Roul] OFF
GO
SET IDENTITY_INSERT [dbo].[Tich] ON 

INSERT [dbo].[Tich] ([ID_Tich], [FIOTic], [Tel], [GrpForChil], [ToEvent], [ToZant], [login_Tic], [password], [Rol], [Pari]) VALUES (1, N'Антонова Виктория Петровна', N'+7 988 414-96-85', 1, 2, 2, N'1', N'1', 3, NULL)
INSERT [dbo].[Tich] ([ID_Tich], [FIOTic], [Tel], [GrpForChil], [ToEvent], [ToZant], [login_Tic], [password], [Rol], [Pari]) VALUES (2, N'Петров Виктор Антонович', N'+7 912 699+96+69', 3, NULL, 1, N'2', N'2', 2, NULL)
INSERT [dbo].[Tich] ([ID_Tich], [FIOTic], [Tel], [GrpForChil], [ToEvent], [ToZant], [login_Tic], [password], [Rol], [Pari]) VALUES (3, N'Шляпкина Анна Петровна', N'+7 899 969-96-89', 3, 1, 3, N'login3', N'1111', 2, NULL)
INSERT [dbo].[Tich] ([ID_Tich], [FIOTic], [Tel], [GrpForChil], [ToEvent], [ToZant], [login_Tic], [password], [Rol], [Pari]) VALUES (5, N'2', N'21', NULL, NULL, NULL, N'3', N'3', 2, NULL)
SET IDENTITY_INSERT [dbo].[Tich] OFF
GO
SET IDENTITY_INSERT [dbo].[Zanat] ON 

INSERT [dbo].[Zanat] ([ID], [DenNed], [Para1], [Zam1], [Para2], [Zam2], [Para3], [Zam3], [Para4], [Zam4], [Para5], [Zam5], [NomerUch], [Kluc]) VALUES (1, N'Понедельник', N'ИРС', N'нет', N'ППП', N'', N'ОМТ', N'', N'ССА', N'', N'CCC', N'', 1, NULL)
INSERT [dbo].[Zanat] ([ID], [DenNed], [Para1], [Zam1], [Para2], [Zam2], [Para3], [Zam3], [Para4], [Zam4], [Para5], [Zam5], [NomerUch], [Kluc]) VALUES (2, N'Вторник', N'ИИР', NULL, N'ПП', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[Zanat] ([ID], [DenNed], [Para1], [Zam1], [Para2], [Zam2], [Para3], [Zam3], [Para4], [Zam4], [Para5], [Zam5], [NomerUch], [Kluc]) VALUES (3, N'Понедельник', N'ПРП', NULL, N'СМП', NULL, N'ППП', NULL, NULL, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[Zanat] ([ID], [DenNed], [Para1], [Zam1], [Para2], [Zam2], [Para3], [Zam3], [Para4], [Zam4], [Para5], [Zam5], [NomerUch], [Kluc]) VALUES (5, N'Вторник', N'ПП', NULL, N'ПП', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[Zanat] ([ID], [DenNed], [Para1], [Zam1], [Para2], [Zam2], [Para3], [Zam3], [Para4], [Zam4], [Para5], [Zam5], [NomerUch], [Kluc]) VALUES (13, N'Среда', N'ПП', NULL, N'ПП', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[Zanat] ([ID], [DenNed], [Para1], [Zam1], [Para2], [Zam2], [Para3], [Zam3], [Para4], [Zam4], [Para5], [Zam5], [NomerUch], [Kluc]) VALUES (14, N'Четверг', N'ПП', NULL, N'ПП', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[Zanat] ([ID], [DenNed], [Para1], [Zam1], [Para2], [Zam2], [Para3], [Zam3], [Para4], [Zam4], [Para5], [Zam5], [NomerUch], [Kluc]) VALUES (16, N'Среда', N'СПР', NULL, N'ВКЗ', NULL, N'ПП', NULL, NULL, NULL, NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[Zanat] OFF
GO
SET IDENTITY_INSERT [dbo].[Zanztia] ON 

INSERT [dbo].[Zanztia] ([ID_Zan], [Name]) VALUES (1, N'Робототехника')
INSERT [dbo].[Zanztia] ([ID_Zan], [Name]) VALUES (2, N'Программирование')
INSERT [dbo].[Zanztia] ([ID_Zan], [Name]) VALUES (3, N'Анг.язык')
INSERT [dbo].[Zanztia] ([ID_Zan], [Name]) VALUES (4, N'Экономика')
SET IDENTITY_INSERT [dbo].[Zanztia] OFF
GO
ALTER TABLE [dbo].[Child]  WITH CHECK ADD  CONSTRAINT [FK_Child_Event] FOREIGN KEY([Event])
REFERENCES [dbo].[Event] ([ID_Event])
GO
ALTER TABLE [dbo].[Child] CHECK CONSTRAINT [FK_Child_Event]
GO
ALTER TABLE [dbo].[Child]  WITH CHECK ADD  CONSTRAINT [FK_Child_Group] FOREIGN KEY([Grp])
REFERENCES [dbo].[Group] ([ID_Group])
GO
ALTER TABLE [dbo].[Child] CHECK CONSTRAINT [FK_Child_Group]
GO
ALTER TABLE [dbo].[Child]  WITH CHECK ADD  CONSTRAINT [FK_Child_Parents] FOREIGN KEY([Paren])
REFERENCES [dbo].[Parents] ([ID_Parent])
GO
ALTER TABLE [dbo].[Child] CHECK CONSTRAINT [FK_Child_Parents]
GO
ALTER TABLE [dbo].[Child]  WITH CHECK ADD  CONSTRAINT [FK_Child_Zanztia] FOREIGN KEY([DopZan])
REFERENCES [dbo].[Zanztia] ([ID_Zan])
GO
ALTER TABLE [dbo].[Child] CHECK CONSTRAINT [FK_Child_Zanztia]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Tich] FOREIGN KEY([Kurt])
REFERENCES [dbo].[Tich] ([ID_Tich])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Tich]
GO
ALTER TABLE [dbo].[Tich]  WITH CHECK ADD  CONSTRAINT [FK_Tich_Event] FOREIGN KEY([ToEvent])
REFERENCES [dbo].[Event] ([ID_Event])
GO
ALTER TABLE [dbo].[Tich] CHECK CONSTRAINT [FK_Tich_Event]
GO
ALTER TABLE [dbo].[Tich]  WITH CHECK ADD  CONSTRAINT [FK_Tich_Group] FOREIGN KEY([GrpForChil])
REFERENCES [dbo].[Group] ([ID_Group])
GO
ALTER TABLE [dbo].[Tich] CHECK CONSTRAINT [FK_Tich_Group]
GO
ALTER TABLE [dbo].[Tich]  WITH CHECK ADD  CONSTRAINT [FK_Tich_Roul] FOREIGN KEY([Rol])
REFERENCES [dbo].[Roul] ([ID])
GO
ALTER TABLE [dbo].[Tich] CHECK CONSTRAINT [FK_Tich_Roul]
GO
ALTER TABLE [dbo].[Tich]  WITH CHECK ADD  CONSTRAINT [FK_Tich_Zanztia] FOREIGN KEY([ToZant])
REFERENCES [dbo].[Zanztia] ([ID_Zan])
GO
ALTER TABLE [dbo].[Tich] CHECK CONSTRAINT [FK_Tich_Zanztia]
GO
ALTER TABLE [dbo].[Zanat]  WITH CHECK ADD  CONSTRAINT [FK_Zanat_Tich] FOREIGN KEY([Kluc])
REFERENCES [dbo].[Tich] ([ID_Tich])
GO
ALTER TABLE [dbo].[Zanat] CHECK CONSTRAINT [FK_Zanat_Tich]
GO
/****** Object:  StoredProcedure [dbo].[FIO]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FIO] (@logww nvarchar(50), @Ima nvarchar(50) Output)
as
declare @nam nvarchar(50)
set @nam = (Select FIOTic from Tich where login_Tic = @logww)
set @Ima = @nam
GO
/****** Object:  StoredProcedure [dbo].[Reg]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Reg] (@FIo nvarchar(150),@tel nvarchar(50), @log nvarchar(50), @Pass nvarchar(50),@V int output)
as
declare @con int
set @con = (Select count(*) from Tich where login_Tic=@log)
if (@con =0)
INSERT INTO Tich values( @Fio,@tel,null,null,null, @log,@Pass,2)
if(@con >=1)
set @V =2
else 
set @V = 1
GO
/****** Object:  StoredProcedure [dbo].[Rol]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Rol] (@log nvarchar(50), @V int output)
as
set @V = ( Select Rol from Tich where @log = login_Tic)
GO
/****** Object:  StoredProcedure [dbo].[Vxod]    Script Date: 29.04.2021 13:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Vxod] (@logg nvarchar(50), @pasWr nvarchar(50), @Vix int Output)
as
declare @count int
 set @count = (Select count(*) from Tich where login_Tic=@logg and password = @pasWr)
If (@count = 1)
 set @Vix = 1
 else 
 set @Vix = 0
GO
USE [master]
GO
ALTER DATABASE [SAD] SET  READ_WRITE 
GO
