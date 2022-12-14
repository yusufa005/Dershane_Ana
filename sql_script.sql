USE [master]
GO
/****** Object:  Database [Dershane]    Script Date: 17.10.2022 15:46:48 ******/
CREATE DATABASE [Dershane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dershane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Dershane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Dershane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Dershane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Dershane] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dershane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dershane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dershane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dershane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dershane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dershane] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dershane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dershane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dershane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dershane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dershane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dershane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dershane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dershane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dershane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dershane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dershane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dershane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dershane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dershane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dershane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dershane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dershane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dershane] SET RECOVERY FULL 
GO
ALTER DATABASE [Dershane] SET  MULTI_USER 
GO
ALTER DATABASE [Dershane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dershane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dershane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dershane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Dershane] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Dershane', N'ON'
GO
ALTER DATABASE [Dershane] SET QUERY_STORE = OFF
GO
USE [Dershane]
GO
/****** Object:  Table [dbo].[Ders_kayıt]    Script Date: 17.10.2022 15:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders_kayıt](
	[Ders_adı] [nvarchar](50) NOT NULL,
	[Ders_bölüm] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genel_rapor]    Script Date: 17.10.2022 15:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genel_rapor](
	[Ogrenci_ad_rapor] [nvarchar](50) NOT NULL,
	[Ogrenci_no_rapor] [nvarchar](50) NOT NULL,
	[Ortalama_rapor] [int] NOT NULL,
	[Geçti_Kaldı] [nvarchar](50) NOT NULL,
	[Ogrenci_ara_rapor] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Not_giris]    Script Date: 17.10.2022 15:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Not_giris](
	[Ogrenci_ad_not] [nvarchar](50) NOT NULL,
	[Ogrenci_no_not] [nvarchar](50) NOT NULL,
	[Ders_not_adı] [nvarchar](50) NOT NULL,
	[Ders_not_bölüm] [nvarchar](50) NOT NULL,
	[Ders_öğretmen] [nvarchar](50) NOT NULL,
	[sınav1] [int] NOT NULL,
	[sınav2] [int] NOT NULL,
	[Ortalama] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci_kayıt]    Script Date: 17.10.2022 15:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci_kayıt](
	[Ogrenci_ad_ekle] [nvarchar](50) NOT NULL,
	[Ogrenci_no_ekle] [nvarchar](50) NOT NULL,
	[Ogrenci_branş] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogretmen_kayıt]    Script Date: 17.10.2022 15:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmen_kayıt](
	[Ogr_Ad_soyad] [nvarchar](50) NOT NULL,
	[Ogr_tc_no] [int] NOT NULL,
	[Ogr_Branş] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Dershane] SET  READ_WRITE 
GO
