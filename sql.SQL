/*
Created: 23/03/2017
Modified: 27/03/2017
Model: Microsoft SQL Server 2016
Database: MS SQL Server 2016
*/


-- Create tables section -------------------------------------------------

-- Table Clientes

CREATE TABLE [Clientes]
(
 [ClienteID] Bigint IDENTITY(1,1) NOT NULL,
 [Nombre] Varchar(50) NOT NULL,
 [Apellido] Varchar(50) NOT NULL
)
go

SET IDENTITY_INSERT [dbo].[Clientes] ON     
GO
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido]) VALUES (1, N'Nestor', N'Rodriguez')
GO
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido]) VALUES (2, N'Marcos', N'Rodriguez')
GO
INSERT [dbo].[Clientes] ([ClienteID], [Nombre], [Apellido]) VALUES (3, N'Jose', N'Gonzalez')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO

-- Add keys for table Clientes

ALTER TABLE [Clientes] ADD CONSTRAINT [Pk_Clientes] PRIMARY KEY ([ClienteID])
go



