/*
Created: 23/03/2017
Modified: 23/03/2017
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

-- Add keys for table Clientes

ALTER TABLE [Clientes] ADD CONSTRAINT [Key1] PRIMARY KEY ([ClienteID])
go



