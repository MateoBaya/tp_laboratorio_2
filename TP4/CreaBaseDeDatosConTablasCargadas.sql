USE [master]
GO
/****** Object:  Database [Pelis]    Script Date: 22/11/2021 16:23:20 ******/
CREATE DATABASE [Pelis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pelis', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Pelis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pelis_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Pelis_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Pelis] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pelis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pelis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pelis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pelis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pelis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pelis] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pelis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pelis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pelis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pelis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pelis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pelis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pelis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pelis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pelis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pelis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pelis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pelis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pelis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pelis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pelis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pelis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pelis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pelis] SET RECOVERY FULL 
GO
ALTER DATABASE [Pelis] SET  MULTI_USER 
GO
ALTER DATABASE [Pelis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pelis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pelis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pelis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pelis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pelis] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Pelis', N'ON'
GO
ALTER DATABASE [Pelis] SET QUERY_STORE = OFF
GO
USE [Pelis]
GO
/****** Object:  Table [dbo].[PeliculasGuardadas]    Script Date: 22/11/2021 16:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeliculasGuardadas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[duracion] [int] NOT NULL,
	[visitas] [int] NOT NULL,
	[ranking] [float] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[caratula] [image] NULL,
 CONSTRAINT [PK_PeliculasGuardadas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 22/11/2021 16:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombreComprador] [varchar](100) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[cantEntradas] [int] NOT NULL,
	[tipoPelicula] [varchar](10) NOT NULL,
	[horario] [varchar](50) NOT NULL,
	[precio] [int] NOT NULL,
	[idComprador] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosRegistrados]    Script Date: 22/11/2021 16:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosRegistrados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[dni] [int] NOT NULL,
	[usuario] [varchar](100) NOT NULL,
	[contraseña] [varchar](100) NOT NULL,
	[genero] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UsuariosRegistrados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PeliculasGuardadas] ON 

INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (1, N'Batman', 120, 5535, 4, N'Gran pelicula por un gran director', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (2, N'Json vs Xml', 200, 6, 2, N'Malisima', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (3, N'Json vs Xml 2', 180, 52, 2, N'Como siguen haciendo esta pelicula', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (4, N'Json vs Xml 3', 80, 359, 3.5, N'Al menos tiene una duracion normal esta vez', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (5, N'Spiderman', 100, 8774, 5, N'Gran pelicula, un clásico del cine de superheroes', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (6, N'Alien', 90, 9004, 5, N'Un clásico del terror', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (7, N'The room', 80, 62, 1, N'Nadie sabe por qué salió, pero salió', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (8, N'X-men', 90, 6881, 4.5, N'Buena película, envejeció algo mal', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (9, N'Interestellar', 150, 7444, 4, N'Una buena película, espere una trama compleja de ciencia ficción', NULL)
INSERT [dbo].[PeliculasGuardadas] ([id], [titulo], [duracion], [visitas], [ranking], [descripcion], [caratula]) VALUES (11, N'Dune', 160, 5851, 3.5, N'Basada en su libro, puede no ser entretenida para todos', NULL)
SET IDENTITY_INSERT [dbo].[PeliculasGuardadas] OFF
GO
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (1, N'Gran comprador', N'X-men', 1, N'4D', N'12:00', 1700, 2)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (2, N'Gran comprador', N'X-men', 3, N'4D', N'17:50', 5100, 2)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (3, N'Gran comprador', N'Json vs Xml 2', 2, N'2D', N'19:15', 1400, 2)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (4, N'Soy Otro Usuario', N'Batman', 3, N'3D', N'18:30', 3600, 3)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (5, N'Gran comprador', N'Spiderman', 5, N'3D', N'20:00', 6000, 2)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (6, N'Ulises', N'Dune', 3, N'3D', N'18:30', 3600, 4)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (7, N'Ulises', N'Alien', 1, N'4D', N'20:00', 1700, 4)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (8, N'Pedro El Comprador', N'Spiderman', 5, N'2D', N'20:00', 3500, 5)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (9, N'Pedro El Comprador', N'Interestellar', 5, N'4D', N'17:50', 8500, 5)
INSERT [dbo].[Tickets] ([id], [nombreComprador], [titulo], [cantEntradas], [tipoPelicula], [horario], [precio], [idComprador]) VALUES (10, N'Soy Otro Usuario', N'Batman', 1, N'3D', N'17:00', 1200, 3)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
GO
SET IDENTITY_INSERT [dbo].[UsuariosRegistrados] ON 

INSERT [dbo].[UsuariosRegistrados] ([id], [nombre], [dni], [usuario], [contraseña], [genero]) VALUES (1, N'admin admin', 44262048, N'admin', N'admin', N'Masculino')
INSERT [dbo].[UsuariosRegistrados] ([id], [nombre], [dni], [usuario], [contraseña], [genero]) VALUES (2, N'Gran comprador', 26564489, N'PrimerComprador', N'compra', N'Femenino')
INSERT [dbo].[UsuariosRegistrados] ([id], [nombre], [dni], [usuario], [contraseña], [genero]) VALUES (3, N'Soy Otro Usuario', 45854968, N'VeoPelis', N'pelis', N'Otro')
INSERT [dbo].[UsuariosRegistrados] ([id], [nombre], [dni], [usuario], [contraseña], [genero]) VALUES (4, N'Ulises', 33555264, N'spiderman', N'spiderman', N'Otro')
INSERT [dbo].[UsuariosRegistrados] ([id], [nombre], [dni], [usuario], [contraseña], [genero]) VALUES (5, N'Pedro El Comprador', 49333265, N'Pedro', N'elcomprador', N'Masculino')
SET IDENTITY_INSERT [dbo].[UsuariosRegistrados] OFF
GO
USE [master]
GO
ALTER DATABASE [Pelis] SET  READ_WRITE 
GO
