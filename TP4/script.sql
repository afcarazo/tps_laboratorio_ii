USE [master]
GO
/****** Object:  Database [TP4_AgustinaCarazo]    Script Date: 11/22/2021 3:08:25 PM ******/
CREATE DATABASE [TP4_AgustinaCarazo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Asegurados', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Asegurados.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Asegurados_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Asegurados_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_AgustinaCarazo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4_AgustinaCarazo', N'ON'
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET QUERY_STORE = OFF
GO
USE [TP4_AgustinaCarazo]
GO
/****** Object:  Table [dbo].[asegurados]    Script Date: 11/22/2021 3:08:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asegurados](
	[Dni] [int] NOT NULL,
	[Genero] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[IdLocalidad] [int] NOT NULL,
	[IdMarcaVehiculo] [int] NULL,
	[AnioVehiculo] [int] NOT NULL,
	[ModeloVehiculo] [nvarchar](50) NOT NULL,
	[PatenteVehiculo] [nchar](10) NOT NULL,
	[IdTipoVehiculo] [int] NOT NULL,
	[IdPlanDePago] [int] NOT NULL,
	[MontoTotal] [int] NOT NULL,
	[IdTipoSeguro] [int] NOT NULL,
	[IdMarcaMoto] [int] NULL,
	[Cilindrada] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (22143675, 0, N'Ana', N'Mend', N'AnaM@gmail.com', 3, 4, 2011, N'Toyota corolla 1.8 Xei At Pack', N'WRET55    ', 0, 0, 5763, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (35789456, 0, N'Elena', N'Craw', N'ElenaC@gmail.com', 4, 2, 2015, N'VW 10.150 E 39', N'ASER23    ', 2, 0, 2733, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (24756981, 1, N'Fausto', N'Perz', N'Faus@gmail.com', 4, 2, 2021, N'VW Amarok 3.0 V6 Extreme', N'ESTE55    ', 0, 0, 8508, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (44789221, 2, N'Manuel', N'Castro', N'ManC@gmail.com', 1, NULL, 2021, N'Fz Fi ', N'LLLS55    ', 1, 0, 1816, 0, 0, 150)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (45888999, 0, N'Amanda', N'Frits', N'Amanda@gmail.com', 3, 2, 2019, N'VW Golf 1.4 Comfortline Tsi Dsg', N'WRER55    ', 2, 0, 8932, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (22445788, 1, N'Francisco', N'Port', N'FranP@gmail.com', 3, 3, 2015, N'Peugeot 308 1.6 Active ', N'ASWW66    ', 0, 0, 8071, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (44578941, 0, N'Fiona', N'Dominguez', N'FioD@gmail.com', 5, 6, 2016, N'Honda Civic Exs At 140cv', N'FSRF22    ', 2, 0, 8872, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (19456789, 1, N'Ruben', N'Fernandez', N'RubenF@gmail.com', 5, NULL, 2021, N'Patagonian Eagle 150', N'FERW88    ', 1, 1, 2808, 0, 0, 150)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (26788915, 2, N'Jess', N'Forw', N'JessForw@hotmail.com', 6, 0, 2021, N'Renault Logan 1.6 16v Life', N'FREW88    ', 2, 0, 3778, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (42456789, 0, N'Myriam', N'Troc', N'Myriam5145@gmail.com', 0, 5, 2005, N'Chevrolet Meriva 1.8 ', N'FTTR99    ', 0, 0, 13423, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (22456789, 1, N'adrian', N'gomez', N'adriangomez@gmai.com', 0, 3, 2008, N'peugeot 2008 1.6 active', N'AOPE12    ', 0, 0, 6920, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (15489632, 0, N'maria', N'arreta', N'mariaarreta@gmail.com', 1, 4, 2018, N'toyota 86 ft', N'JKIL22    ', 2, 1, 2755, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (14789456, 2, N'jess', N'lopez', N'jess565@hotmail.com', 2, 5, 2019, N'chevrolet camaro ss', N'WERF87    ', 2, 0, 8738, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (42456789, 2, N'ariel', N'henandez', N'arielhernandez@gmail.com', 0, 6, 2017, N'civic 2.0 ex-2017', N'LWRO66    ', 0, 1, 12368, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (19456789, 0, N'marcela ', N'callejos', N'marceca@gmail.com', 2, NULL, 2012, N'yamaha tornado', N'GHTS12    ', 1, 1, 6393, 1, 0, 250)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (27456789, 1, N'tomas ', N'lopez', N'tomaslopez@gmail.com', 6, 2, 2017, N'vw 10.150 e 39 ', N'IOPE78    ', 0, 0, 12798, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (42123789, 2, N'noa', N'martinez', N'noa48@hotmail.com', 0, 6, 2020, N'honda cb1 125 cc', N'ASWT78    ', 0, 0, 6306, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (16123456, 1, N'juan', N'perez', N'juanp@hotmail.com', 0, NULL, 2021, N'zanella styler ', N'RYTR45    ', 1, 1, 8713, 1, 0, 200)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (22456789, 1, N'valentin', N'brizuela', N'valetin548@gmail.com', 4, 3, 2021, N'peugeot partner 1.6 furgon ', N'OLDE78    ', 0, 0, 8311, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (19716157, 1, N'juan', N'dominguez', N'juand@hotmail.com', 0, 2, 2020, N'vw 10.150 e 43', N'VCDE45    ', 2, 0, 8699, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (43589321, 0, N'camila', N'diaz', N'cami458@hotmail.com', 3, 1, 2017, N'fiat 500 1.4', N'OIER85    ', 2, 1, 8319, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (42789456, 0, N'ludmila', N'rodriguez', N'lud45@gmail.com', 4, 5, 2017, N'chevrolet camaro L/17', N'PYEF75    ', 2, 0, 8625, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (44789152, 0, N'fiona', N'holanda', N'fio45@hotmai.com', 1, 4, 2019, N'toyota yaris cvt', N'OERE45    ', 2, 0, 3626, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (20456789, 1, N'pepe', N'perez', N'pepeperez@hotmail.com', 0, 0, 2020, N'renault captur 1.6 life', N'FBEY45    ', 2, 0, 8933, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (27456124, 2, N'eric', N'dominguez', N'eric45@gmail.com', 3, 1, 2021, N'fiat 500 1.4 abarth 595 turismo', N'FGYR45    ', 0, 0, 12306, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (27458714, 1, N'joaquin', N'salva', N'joaquins@hotmail.com', 5, NULL, 2021, N'yamaha mt03', N'FYER45    ', 1, 1, 2107, 0, 0, 321)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (25456789, 1, N'lucas ', N'medez', N'lucas48@gmail.com', 6, NULL, 2017, N'elite 125', N'DYFE12    ', 1, 1, 9142, 1, 0, 170)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (42456789, 1, N'mateo', N'lud', N'mate45@gmail.com', 0, NULL, 2021, N'zanella cruiser 150', N'FYFG78    ', 1, 0, 8214, 1, 0, 160)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (45321812, 0, N'amanda', N'prun', N'amandap@gmail.com', 5, 0, 2021, N'sandero stepway 1.6 16v zen', N'FVET21    ', 0, 0, 9067, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (26894453, 0, N'paula', N'cabel', N'pau4@gmail.com', 0, 6, 1996, N'honda accord 2.2 exr', N'DYRE22    ', 0, 0, 13826, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (19456789, 1, N'ezequiel ', N'mor', N'eze45@gmail.com', 2, 1, 2020, N'fiat 500 L 1.4 pop star', N'FTER54    ', 2, 0, 8216, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (27899741, 0, N'pamela', N'herandez', N'pame@hotmail.com', 2, 5, 2019, N'chevrolet agile 1.4 ls L/14', N'FHER45    ', 2, 1, 8530, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (23478115, 2, N'kia', N'comat', N'kia@gmail.com', 4, 6, 2018, N'honda cb1 125 cc', N'FRED52    ', 2, 0, 2187, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (29587156, 1, N'ruben ', N'cape', N'rubenc@gmail.com', 6, 0, 2014, N'fiat doblo 1.4 active ', N'PORE45    ', 0, 0, 12039, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (19456789, 1, N'carlos', N'menz', N'carlos@gmail.com', 0, 2, 2018, N'vw 10.150 e 43', N'FYER78    ', 0, 1, 5109, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (43404810, 0, N'antonia ', N'mels', N'antods453@gmail.com', 4, 4, 2020, N'toyota 86 gt', N'FRTE78    ', 0, 0, 7826, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (27854126, 0, N'vanesa ', N'cott', N'vanesac@gmail.com', 3, 5, 2014, N'chevrolet onix 1.4 ltz mt 98cv', N'DETR45    ', 0, 0, 13444, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (43457894, 1, N'federico', N'gomez', N'fedeg@gmail.com', 5, NULL, 2018, N'yamaha r3 yzt ', N'FBER12    ', 1, 0, 9501, 1, 0, 321)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (22215489, 0, N'silvia', N'misw', N'sil@gmail.com', 1, 4, 2015, N'toyota 86 gt aut', N'GTER45    ', 2, 0, 3524, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (22369871, 1, N'Jose ', N'Perez ', N'JoseP@gmail.com', 5, 5, 2005, N'Meriva 1.8', N'GFDH00    ', 0, 1, 12352, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (40789654, 0, N'Paola', N'Fernandez', N'PaoFer@gmail.com', 5, NULL, 2020, N'FZ25', N'POEL03    ', 1, 1, 2198, 0, 0, 250)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (43405147, 2, N'Joaquin', N'Pirw', N'Joa@gmail.com', 1, 2, 2019, N'Golf 1.4 Comfortline ', N'OWET45    ', 0, 0, 6870, 0, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (14789456, 1, N'Beto', N'Hernandez', N'Beto123@gmail.com', 1, 4, 2019, N'TOYOTA 86 FT', N'SFRT88    ', 2, 1, 8225, 1, NULL, NULL)
INSERT [dbo].[asegurados] ([Dni], [Genero], [Nombre], [Apellido], [Email], [IdLocalidad], [IdMarcaVehiculo], [AnioVehiculo], [ModeloVehiculo], [PatenteVehiculo], [IdTipoVehiculo], [IdPlanDePago], [MontoTotal], [IdTipoSeguro], [IdMarcaMoto], [Cilindrada]) VALUES (43223333, 1, N'Facundo', N'Pintos', N'Facupp@gmail.com', 2, NULL, 2021, N'Zr ', N'FDER99    ', 1, 0, 9354, 1, 0, 150)
GO
USE [master]
GO
ALTER DATABASE [TP4_AgustinaCarazo] SET  READ_WRITE 
GO
