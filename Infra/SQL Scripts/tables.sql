---TABLES
-- USERS

CREATE TABLE dbo.Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Number VARCHAR(255) NOT NULL UNIQUE,
    Email VARCHAR(255),
    Password VARCHAR(255) NOT NULL,
    TypeU CHAR(1) NOT NULL CHECK (TypeU IN ('U', 'D', 'A')),
    Status BIT NOT NULL
);


CREATE TABLE dbo.Productos (
    idProducto INT IDENTITY(25000,125) PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Cantidad int NOT NULL,
	Precio DECIMAL(6, 3) NOT NULL
);


CREATE TABLE dbo.Tarjetas (
    idTarjeta INT IDENTITY(1,1) PRIMARY KEY,
    numero VARCHAR(255) NOT NULL,
    code VARCHAR(4) NOT NULL,
    expiration DATE NOT NULL, -- Corrected data type to DATE
    dinero DECIMAL(18, 2) NOT NULL -- Using DECIMAL for monetary values
);

CREATE TABLE Orden (
    idOrden INT IDENTITY(1,1) PRIMARY KEY,
    numeroCliente VARCHAR(50),
    IdProducto VARCHAR(50),
    Cantidad VARCHAR(50),
    coordenadas VARCHAR(255),
    totalComprar FLOAT,
	activa BIT NOT NULL
);

CREATE TABLE OrdenesActivas (
    idOrdenActiva INT IDENTITY(1,1) PRIMARY KEY,
	idOrden INT FOREIGN KEY REFERENCES Orden(idOrden),
    numeroCliente VARCHAR(50),
    numeroDriver VARCHAR(50),
    IdProducto VARCHAR(50),
    Cantidad VARCHAR(50),
    coordenadas VARCHAR(255),
    totalComprar FLOAT,
	completada BIT NOT NULL
);
