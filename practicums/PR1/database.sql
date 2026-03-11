USE [master]
GO
/****** Object:  Database [test_db]    Script Date: 11.03.2026 20:24:43 ******/
CREATE DATABASE [test_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'test_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\test_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'test_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\test_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [test_db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [test_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [test_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [test_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [test_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [test_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [test_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [test_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [test_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [test_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [test_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [test_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [test_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [test_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [test_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [test_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [test_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [test_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [test_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [test_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [test_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [test_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [test_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [test_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [test_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [test_db] SET  MULTI_USER 
GO
ALTER DATABASE [test_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [test_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [test_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [test_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [test_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [test_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [test_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [test_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [test_db]
GO
/****** Object:  Table [dbo].[questions]    Script Date: 11.03.2026 20:24:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[questions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[question_text] [nvarchar](512) NOT NULL,
	[option1] [nvarchar](256) NOT NULL,
	[option2] [nvarchar](256) NOT NULL,
	[option3] [nvarchar](256) NOT NULL,
	[option4] [nvarchar](256) NOT NULL,
	[correct_answer] [int] NOT NULL,
	[question_order] [int] NOT NULL,
 CONSTRAINT [PK_questions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_answers]    Script Date: 11.03.2026 20:24:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_answers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[question_id] [int] NULL,
	[selected_answer] [int] NULL,
	[is_correct] [bit] NULL,
	[answer_time] [datetime] NULL,
 CONSTRAINT [PK_user_answers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11.03.2026 20:24:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](128) NOT NULL,
	[last_name] [nvarchar](128) NOT NULL,
	[test_date] [datetime] NULL,
	[score] [int] NULL,
	[time_spent] [int] NULL,
	[is_completed] [bit] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[user_answers]  WITH CHECK ADD  CONSTRAINT [FK_user_answers_questions] FOREIGN KEY([question_id])
REFERENCES [dbo].[questions] ([id])
GO
ALTER TABLE [dbo].[user_answers] CHECK CONSTRAINT [FK_user_answers_questions]
GO
ALTER TABLE [dbo].[user_answers]  WITH CHECK ADD  CONSTRAINT [FK_user_answers_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[user_answers] CHECK CONSTRAINT [FK_user_answers_users]
GO
USE [master]
GO
ALTER DATABASE [test_db] SET  READ_WRITE 
GO

INSERT INTO questions (id, question_text, option1, option2, option3, option4, correct_answer, question_order) VALUES
(16, 'Какой газ необходим для дыхания человека?', 'Кислород', 'Азот', 'Углекислый газ', 'Водород', 1, 16),
(17, 'Столица Франции?', 'Лондон', 'Берлин', 'Париж', 'Мадрид', 3, 17),
(18, 'Сколько дней в неделе?', '5', '6', '7', '8', 3, 18),
(19, 'В каком году началась Вторая мировая война?', '1914', '1939', '1941', '1917', 2, 19),
(20, 'Кто написал "Война и мир"?', 'Достоевский', 'Толстой', 'Пушкин', 'Чехов', 2, 20),
(21, 'Самая большая планета Солнечной системы?', 'Марс', 'Юпитер', 'Сатурн', 'Земля', 2, 21),
(22, 'Сколько будет 2 + 2 * 2?', '4', '6', '8', '2', 2, 22),
(23, 'Какое животное называют "кораблем пустыни"?', 'Верблюд', 'Лошадь', 'Слон', 'Осел', 1, 23),
(24, 'Самый большой океан на Земле?', 'Атлантический', 'Индийский', 'Тихий', 'Северный Ледовитый', 3, 24),
(25, 'Кто изобрёл телефон?', 'Эдисон', 'Белл', 'Тесла', 'Маркони', 2, 25),
(26, 'В каком году человек впервые высадился на Луну?', '1965', '1969', '1972', '1958', 2, 26),
(27, 'Какой химический символ воды?', 'H2O', 'O2', 'CO2', 'NaCl', 1, 27),
(28, 'Кто написал серию книг о Гарри Поттере?', 'Дж.Р.Р. Толкин', 'Дж.К. Роулинг', 'Стивен Кинг', 'Агата Кристи', 2, 28),
(29, 'Сколько континентов на Земле?', '5', '6', '7', '4', 3, 29),
(30, 'Какой цвет получается при смешении красного и синего?', 'Зеленый', 'Фиолетовый', 'Оранжевый', 'Коричневый', 2, 30);