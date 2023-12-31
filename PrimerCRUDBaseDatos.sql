USE [Generacion23]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 24/12/2023 10:52:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[idAlumno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellidoPaterno] [varchar](100) NULL,
	[apellidoMaterno] [varchar](100) NULL,
	[edad] [int] NULL,
	[correo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (2, N'Jose', N'Variela', N'Lara', 51, N'joseruizla@correo.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (4, N'Bryan', N'Martinez', N'Perez', 24, N'bryanmp@correo.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (5, N'Armando', N'Osorio', N'Rodriguez', 23, N'Aror@correo.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1002, N'Andrea', N'Martinez', N'Perez', 25, N'andreamarez@gmail.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1004, N'Juan', N'Guitierrez', N'Mendez', 36, N'juangm@gmail.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1005, N'Mario ', N'Ozorio', N'Chon', 38, N'marioozochom@correo.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1006, N'Maria', N'Jin', N'Jon', 12, N'lujinjon12@gmail.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1011, N'Mario ', N'Perez', N'Barrera', 75, N'mariperexbarrera@hotmail.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1012, N'Manuel ', N'Lara', N'Osorio', 56, N'manuellaraOso@correo.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1014, N'Hannah', N'Jonson', N'Bucanas', 21, N'hannajonnas@correo.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1016, N'Angel ', N'Noroña', N'Bonilla', 68, N'norov68@gmail.com')
INSERT [dbo].[Alumno] ([idAlumno], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [correo]) VALUES (1017, N'Ana', N'Cortez', N'Aguilar', 89, N'ana89@correo.com')
SET IDENTITY_INSERT [dbo].[Alumno] OFF
GO
