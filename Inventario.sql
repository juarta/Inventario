
	-- Tabla Suministros
	CREATE TABLE Suministros (
		CodigoProducto INT IDENTITY(1000,1) PRIMARY KEY,
		Nombre VARCHAR(30) NOT NULL,
		UnidadMedida CHAR(1) NOT NULL,
		PrecioUnitario DECIMAL(10, 2) NOT NULL,
		CantidadMinima INT NOT NULL,
		CantidadMaxima INT NOT NULL,
		CantidadActual INT NOT NULL
	);


Select * from Suministros
	-- Tabla Pedidos
	CREATE TABLE Pedidos (
		IdPedido INT IDENTITY(1,1) PRIMARY KEY,
		CodigoProducto INT REFERENCES Suministros(CodigoProducto),
		FechaPedido DATE NOT NULL,
		CantidadPedido INT NOT NULL,
		PrecioUnidad DECIMAL(10, 2) NOT NULL,
		FechaEntrega DATE NOT NULL,
		NombreEmpresa VARCHAR(50) NOT NULL,
		NombreEntrega VARCHAR(50) NOT NULL,
		NombreRecibe VARCHAR(50) NOT NULL,
		NumeroFactura VARCHAR(20) NOT NULL
	);

	