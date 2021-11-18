--################################--
--####     CREACION DE BD     ####--
--################################--

-- Create a new database called 'ElementaryLearning'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'ElementaryLearning'
)
CREATE DATABASE ElementaryLearning
GO

--################################--
--#### CREACION DE LAS TABLAS ####--
--################################--



--###### TABLA DE USUARIOS #####--

-- Create a new table called '[Usuarios]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Usuarios]', 'U') IS NOT NULL
DROP TABLE [dbo].[Usuarios]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Usuarios]
(
    [IdUsuario] INT NOT NULL PRIMARY KEY IDENTITY, -- Primary Key column
    [Usuario] NVARCHAR(50) NOT NULL UNIQUE,
    [Contrasena] NVARCHAR(50) NOT NULL,
    [IdAlumno] INT --FK
    -- Specify more columns here
);
GO


--##### TABLA DE ALUMNOS #####--

-- Create a new table called '[Alumnos]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Alumnos]', 'U') IS NOT NULL
DROP TABLE [dbo].[Alumnos]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Alumnos]
(
    [IdAlumno] INT NOT NULL PRIMARY KEY IDENTITY, -- Primary Key column
    [Nombre] NVARCHAR(50) NOT NULL,
    [Edad] NVARCHAR(50) NOT NULL
    -- Specify more columns here
);
GO

--##### TABLA DE AREAS #####--

-- Create a new table called '[Areas]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Areas]', 'U') IS NOT NULL
DROP TABLE [dbo].[Areas]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Areas]
(
    [IdArea] INT NOT NULL PRIMARY KEY IDENTITY, -- Primary Key column
    [NombreArea] NVARCHAR(50) NOT NULL,
    [IdAlumno] INT NOT NULL --FK
    -- Specify more columns here
);
GO

--##### TABLA DE PUNTUACIONES #####--

-- Create a new table called '[Puntuaciones]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Puntuaciones]', 'U') IS NOT NULL
DROP TABLE [dbo].[Puntuaciones]
GO
-- Create the table in the specified schema
CREATE TABLE [dbo].[Puntuaciones]
(
    [IdPuntuacion] INT NOT NULL PRIMARY KEY IDENTITY, -- Primary Key column
    [Puntuacion] FLOAT NOT NULL,
    [Fecha] DATETIME NOT NULL,
    [IdAlumno] INT, --FK 
    [IdArea] INT --FK 
    -- Specify more columns here
);
GO


--######################--
--##### RELACIONES #####--
--######################--

--##### RELACION ALUMNOS-USUARIOS #####--
USE ElementaryLearning
ALTER TABLE Usuarios
ADD CONSTRAINT FK_Alumnos_Usuarios
FOREIGN KEY(IdAlumno) REFERENCES Alumnos (IdAlumno)
GO


--##### RELACION ALUMNOS-AREAS #####--
USE ElementaryLearning
ALTER TABLE Areas
ADD CONSTRAINT FK_Alumnos_Areas
FOREIGN KEY(IdAlumno) REFERENCES Alumnos (IdAlumno)
GO


--##### RELACION ALUMNOS-PUNTUACIONES #####--
USE ElementaryLearning
ALTER TABLE Puntuaciones
ADD CONSTRAINT FK_Alumnos_Puntuaciones
FOREIGN KEY(IdAlumno) REFERENCES Alumnos (IdAlumno)
GO


--##### RELACION AREAS-PUNTUACIONES #####--
USE ElementaryLearning
ALTER TABLE Puntuaciones
ADD CONSTRAINT FK_Areas_Puntuaciones
FOREIGN KEY(IdArea) REFERENCES Areas (IdArea)
GO


--##USAR EN CASO DE NECESITAR BORRAR LA BASE DE DATOS##--

ALTER TABLE Usuarios
drop CONSTRAINT FK_Alumnos_Usuarios

ALTER TABLE Areas
drop CONSTRAINT FK_Alumnos_Areas

ALTER TABLE Puntuaciones
drop CONSTRAINT FK_Alumnos_Puntuaciones

ALTER TABLE Puntuaciones
drop CONSTRAINT FK_Areas_Puntuaciones

drop TABLE Usuarios
DROP TABLE Alumnos
DROP TABLE Puntuaciones
DROP TABLE Areas