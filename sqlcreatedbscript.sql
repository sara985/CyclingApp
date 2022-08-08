USE [master]
GO

/****** Object:  Database [CYCLINGCLUB]    Script Date: 08-08-22 20:03:22 ******/
CREATE DATABASE [CYCLINGCLUB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CYCLINGCLUB', FILENAME = N'C:\Users\Sarah\CYCLINGCLUB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CYCLINGCLUB_log', FILENAME = N'C:\Users\Sarah\CYCLINGCLUB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CYCLINGCLUB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CYCLINGCLUB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET ARITHABORT OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CYCLINGCLUB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CYCLINGCLUB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CYCLINGCLUB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CYCLINGCLUB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET RECOVERY FULL 
GO

ALTER DATABASE [CYCLINGCLUB] SET  MULTI_USER 
GO

ALTER DATABASE [CYCLINGCLUB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CYCLINGCLUB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [CYCLINGCLUB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [CYCLINGCLUB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [CYCLINGCLUB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [CYCLINGCLUB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [CYCLINGCLUB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [CYCLINGCLUB] SET  READ_WRITE 
GO

