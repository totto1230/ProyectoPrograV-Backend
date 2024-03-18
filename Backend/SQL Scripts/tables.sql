---TABLES
-- USERS

CREATE TABLE dbo.Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Number VARCHAR(255) NOT NULL UNIQUE,
	Email VARCHAR(255),
	Password VARCHAR(255) NOT NULL,
	TypeU char NOT NULL,
    Status BIT NOT NULL
);

CREATE TABLE dbo.Productos (
    idProducto INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Cantidad int NOT NULL,
);


CREATE TABLE dbo.Tarjetas (
    idTarjeta INT IDENTITY(1,1) PRIMARY KEY,
    numero VARCHAR(255) NOT NULL,
    code VARCHAR(4) NOT NULL,
    expiration DATE NOT NULL, -- Corrected data type to DATE
    dinero DECIMAL(18, 2) NOT NULL -- Using DECIMAL for monetary values
);
