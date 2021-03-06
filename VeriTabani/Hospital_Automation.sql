USE [master]
GO
/****** Object:  Database [Hospital_Automation]    Script Date: 14.01.2021 13:33:19 ******/
CREATE DATABASE [Hospital_Automation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital_Automation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hospital_Automation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hospital_Automation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hospital_Automation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hospital_Automation] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital_Automation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital_Automation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital_Automation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital_Automation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital_Automation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital_Automation] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital_Automation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital_Automation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital_Automation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital_Automation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital_Automation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital_Automation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital_Automation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital_Automation] SET RECOVERY FULL 
GO
ALTER DATABASE [Hospital_Automation] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital_Automation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital_Automation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital_Automation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital_Automation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hospital_Automation] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hospital_Automation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hospital_Automation', N'ON'
GO
ALTER DATABASE [Hospital_Automation] SET QUERY_STORE = OFF
GO
USE [Hospital_Automation]
GO
/****** Object:  Table [dbo].[BilgiIslem]    Script Date: 14.01.2021 13:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BilgiIslem](
	[BilgiIslemId] [int] IDENTITY(1,1) NOT NULL,
	[TcNo] [nvarchar](11) NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[EPosta] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
 CONSTRAINT [PK_BilgiIslem] PRIMARY KEY CLUSTERED 
(
	[BilgiIslemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doktorlar]    Script Date: 14.01.2021 13:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doktorlar](
	[DoktorId] [int] IDENTITY(1,1) NOT NULL,
	[TcNo] [nvarchar](11) NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[DogumYeri] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[BabaAdi] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[PoliklinikAdi] [nvarchar](50) NULL,
	[EPosta] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[PoliklinikId] [int] NULL,
 CONSTRAINT [PK_Doktorlar] PRIMARY KEY CLUSTERED 
(
	[DoktorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilaclar]    Script Date: 14.01.2021 13:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilaclar](
	[IlacId] [int] IDENTITY(1,1) NOT NULL,
	[IlacAdi] [nvarchar](50) NULL,
	[IlacSirket] [nvarchar](50) NULL,
	[IlacAdet] [nvarchar](50) NULL,
	[IlacKod] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ilaclar] PRIMARY KEY CLUSTERED 
(
	[IlacId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 14.01.2021 13:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[TcNo] [nvarchar](50) NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[DogumYeri] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[BabaAdi] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[EPosta] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Muayeneler]    Script Date: 14.01.2021 13:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muayeneler](
	[MuayeneId] [int] IDENTITY(1,1) NOT NULL,
	[DoktorId] [int] NULL,
	[TcNo] [nvarchar](50) NULL,
	[HastaAdi] [nvarchar](50) NULL,
	[HastaSoyadi] [nvarchar](50) NULL,
	[IlacAdi] [nvarchar](50) NULL,
	[IlacKod] [nvarchar](50) NULL,
	[Aciklama] [nvarchar](600) NULL,
 CONSTRAINT [PK_Muayeneler] PRIMARY KEY CLUSTERED 
(
	[MuayeneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poliklinikler]    Script Date: 14.01.2021 13:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poliklinikler](
	[PoliklinikId] [int] IDENTITY(1,1) NOT NULL,
	[PoliklinikAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Poliklinikler] PRIMARY KEY CLUSTERED 
(
	[PoliklinikId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Randevular]    Script Date: 14.01.2021 13:33:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevular](
	[RandevuId] [int] IDENTITY(1,1) NOT NULL,
	[DoktorId] [int] NULL,
	[RandevuTarihi] [nvarchar](50) NULL,
	[TcNo] [nvarchar](50) NULL,
	[RandevuSaati] [nvarchar](50) NULL,
	[Pol_id] [int] NULL,
 CONSTRAINT [PK_Randevular] PRIMARY KEY CLUSTERED 
(
	[RandevuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BilgiIslem] ON 

INSERT [dbo].[BilgiIslem] ([BilgiIslemId], [TcNo], [Adi], [Soyadi], [Telefon], [EPosta], [Sifre], [Cinsiyet]) VALUES (1, N'21232315677', N'Muhammed', N'Yıldızbaş', N'05050550506', N'muhammed@gmail.com', N'Muhammed.123', N'Erkek')
INSERT [dbo].[BilgiIslem] ([BilgiIslemId], [TcNo], [Adi], [Soyadi], [Telefon], [EPosta], [Sifre], [Cinsiyet]) VALUES (2, N'21232555677', N'Beril', N'Ata', N'05305649878', N'bozkir@gmail.com', N'Bozkir.234', N'Kız')
INSERT [dbo].[BilgiIslem] ([BilgiIslemId], [TcNo], [Adi], [Soyadi], [Telefon], [EPosta], [Sifre], [Cinsiyet]) VALUES (3, N'25897895954', N'Hatice', N'Başaran', N'05567895212', N'Hatice@gmail.com', N'Hatice.34', N'Kadın')
SET IDENTITY_INSERT [dbo].[BilgiIslem] OFF
GO
SET IDENTITY_INSERT [dbo].[Doktorlar] ON 

INSERT [dbo].[Doktorlar] ([DoktorId], [TcNo], [Adi], [Soyadi], [DogumYeri], [Cinsiyet], [DogumTarihi], [BabaAdi], [AnneAdi], [Telefon], [PoliklinikAdi], [EPosta], [Sifre], [PoliklinikId]) VALUES (1, N'22356489779', N'Fatma', N'Zümrüt', N'Bitlis', N'Kadın', N'28.03.1990', N'Fırat', N'Hatice', N'05056457895', N'Cildiye', N'fatma@gmail.com', N'Zumrut.21', 2)
INSERT [dbo].[Doktorlar] ([DoktorId], [TcNo], [Adi], [Soyadi], [DogumYeri], [Cinsiyet], [DogumTarihi], [BabaAdi], [AnneAdi], [Telefon], [PoliklinikAdi], [EPosta], [Sifre], [PoliklinikId]) VALUES (2, N'22354589779', N'Furkan', N'Kaya', N'Bingöl', N'Erkek', N'20.05.1998', N'Görkem', N'Kübra', N'05058948562', N'Noroloji', N'furkan@gmail.com', N'Kaya.72', 1)
INSERT [dbo].[Doktorlar] ([DoktorId], [TcNo], [Adi], [Soyadi], [DogumYeri], [Cinsiyet], [DogumTarihi], [BabaAdi], [AnneAdi], [Telefon], [PoliklinikAdi], [EPosta], [Sifre], [PoliklinikId]) VALUES (3, N'22548978523', N'Zeynep', N'Yaldiz', N'Van', N'Kadın', N'01.03.1995', N'Mehmet', N'Hülya', N'05364568978', N'Diş', N'zeynep@gmail.com', N'Van.34', 3)
SET IDENTITY_INSERT [dbo].[Doktorlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Ilaclar] ON 

INSERT [dbo].[Ilaclar] ([IlacId], [IlacAdi], [IlacSirket], [IlacAdet], [IlacKod]) VALUES (1, N'Aspirin', N'Selçuk Ecza Deposu', N'3', N'125467')
INSERT [dbo].[Ilaclar] ([IlacId], [IlacAdi], [IlacSirket], [IlacAdet], [IlacKod]) VALUES (2, N'Pharmaton Kapsül', N'Pharmaton', N'2', N'231546')
SET IDENTITY_INSERT [dbo].[Ilaclar] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([KullaniciId], [TcNo], [Adi], [Soyadi], [DogumYeri], [Cinsiyet], [DogumTarihi], [BabaAdi], [AnneAdi], [Telefon], [EPosta], [Sifre]) VALUES (1, N'22356489779', N'Fatma', N'Zümrüt', N'Gercüş', N'Kadın', N'28 Mart 1990 Çarşamba', N'Fırat', N'Hatice', N'05056457895', N'fatma@gmail.com', N'Fatma.21')
INSERT [dbo].[Kullanicilar] ([KullaniciId], [TcNo], [Adi], [Soyadi], [DogumYeri], [Cinsiyet], [DogumTarihi], [BabaAdi], [AnneAdi], [Telefon], [EPosta], [Sifre]) VALUES (2, N'22354589779', N'Furkan', N'Kaya', N'Bingöl', N'Erkek', N'20.05.1998', N'Görkem', N'Kübra', N'05058948562', N'furkan@gmail.com', N'Furkan123')
INSERT [dbo].[Kullanicilar] ([KullaniciId], [TcNo], [Adi], [Soyadi], [DogumYeri], [Cinsiyet], [DogumTarihi], [BabaAdi], [AnneAdi], [Telefon], [EPosta], [Sifre]) VALUES (4, N'25486489852', N'Umut', N'Yara', N'Gaziantep', N'Erkek', N'4 Ocak 2021 Pazartesi', N'Hasan', N'Ayşe', N'05457895689', N'umut@gmail.com', N'Hasan123')
INSERT [dbo].[Kullanicilar] ([KullaniciId], [TcNo], [Adi], [Soyadi], [DogumYeri], [Cinsiyet], [DogumTarihi], [BabaAdi], [AnneAdi], [Telefon], [EPosta], [Sifre]) VALUES (5, N'22356489778', N'Ayşe', N'Zümrüt', N'Gercüş', N'Kadın', N'28 Mart 1990 Çarşamba', N'Fırat', N'Hatice', N'05056457895', N'fatma@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
GO
SET IDENTITY_INSERT [dbo].[Muayeneler] ON 

INSERT [dbo].[Muayeneler] ([MuayeneId], [DoktorId], [TcNo], [HastaAdi], [HastaSoyadi], [IlacAdi], [IlacKod], [Aciklama]) VALUES (1, 1, N'22356489779', N'Fatma', N'Zümrüt', NULL, NULL, NULL)
INSERT [dbo].[Muayeneler] ([MuayeneId], [DoktorId], [TcNo], [HastaAdi], [HastaSoyadi], [IlacAdi], [IlacKod], [Aciklama]) VALUES (2, 2, N'22354589779', N'Furkan', N'Kaya', N'Aspirin', N'125467', N'Muayene Yapıld')
SET IDENTITY_INSERT [dbo].[Muayeneler] OFF
GO
SET IDENTITY_INSERT [dbo].[Poliklinikler] ON 

INSERT [dbo].[Poliklinikler] ([PoliklinikId], [PoliklinikAdi]) VALUES (1, N'Noroloji')
INSERT [dbo].[Poliklinikler] ([PoliklinikId], [PoliklinikAdi]) VALUES (2, N'Cildiye')
INSERT [dbo].[Poliklinikler] ([PoliklinikId], [PoliklinikAdi]) VALUES (3, N'Diş')
INSERT [dbo].[Poliklinikler] ([PoliklinikId], [PoliklinikAdi]) VALUES (4, N'Göz')
INSERT [dbo].[Poliklinikler] ([PoliklinikId], [PoliklinikAdi]) VALUES (5, N'KBB')
INSERT [dbo].[Poliklinikler] ([PoliklinikId], [PoliklinikAdi]) VALUES (6, N'Psikoloji')
SET IDENTITY_INSERT [dbo].[Poliklinikler] OFF
GO
SET IDENTITY_INSERT [dbo].[Randevular] ON 

INSERT [dbo].[Randevular] ([RandevuId], [DoktorId], [RandevuTarihi], [TcNo], [RandevuSaati], [Pol_id]) VALUES (1, 2, N'14 Ocak 2021 Perşembe', N'22356489779', N'10:40', 1)
SET IDENTITY_INSERT [dbo].[Randevular] OFF
GO
USE [master]
GO
ALTER DATABASE [Hospital_Automation] SET  READ_WRITE 
GO
