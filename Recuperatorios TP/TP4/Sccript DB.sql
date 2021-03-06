USE [master]
GO

/****** Object:  Database [FabricaMuebles]    Script Date: 26/07/2021 9:01:42 ******/
CREATE DATABASE [FabricaMuebles]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FabricaMuebles', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FabricaMuebles.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FabricaMuebles_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FabricaMuebles_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FabricaMuebles].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FabricaMuebles] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FabricaMuebles] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FabricaMuebles] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FabricaMuebles] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FabricaMuebles] SET ARITHABORT OFF 
GO

ALTER DATABASE [FabricaMuebles] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [FabricaMuebles] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FabricaMuebles] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FabricaMuebles] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FabricaMuebles] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FabricaMuebles] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FabricaMuebles] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FabricaMuebles] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FabricaMuebles] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FabricaMuebles] SET  DISABLE_BROKER 
GO

ALTER DATABASE [FabricaMuebles] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FabricaMuebles] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FabricaMuebles] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FabricaMuebles] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FabricaMuebles] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FabricaMuebles] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [FabricaMuebles] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FabricaMuebles] SET RECOVERY FULL 
GO

ALTER DATABASE [FabricaMuebles] SET  MULTI_USER 
GO

ALTER DATABASE [FabricaMuebles] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FabricaMuebles] SET DB_CHAINING OFF 
GO

ALTER DATABASE [FabricaMuebles] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [FabricaMuebles] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [FabricaMuebles] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [FabricaMuebles] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [FabricaMuebles] SET QUERY_STORE = OFF
GO

ALTER DATABASE [FabricaMuebles] SET  READ_WRITE 
GO


