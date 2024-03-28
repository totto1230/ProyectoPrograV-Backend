INSERT INTO Orden (numeroCliente, IdProducto, Cantidad, coordenadas, totalComprar, activa)
VALUES 
('Cliente1', 'Producto1', '1', '45.1234, -123.5678', 25.75, 1),
('Cliente2', 'Producto2', '2', '46.1234, -124.5678', 71.50, 1),
('Cliente3', 'Producto3', '3', '47.1234, -125.5678', 126.75, 0),
('Cliente4', 'Producto4', '4', '48.1234, -126.5678', 75.60, 1),
('Cliente5', 'Producto5', '5', '49.1234, -127.5678', 250.00, 1),
('Cliente6', 'Producto6', '6', '50.1234, -128.5678', 182.25, 1),
('Cliente7', 'Producto7', '7', '51.1234, -129.5678', 192.50, 0),
('Cliente8', 'Producto8', '8', '52.1234, -130.5678', 306.00, 1),
('Cliente9', 'Producto9', '9', '53.1234, -131.5678', 413.10, 1),
('Cliente10', 'Producto10', '10', '54.1234, -132.5678', 63.75, 0),
('Cliente11', 'Producto11', '11', '55.1234, -133.5678', 357.50, 1),
('Cliente12', 'Producto12', '12', '56.1234, -134.5678', 482.25, 1),
('Cliente13', 'Producto13', '13', '57.1234, -135.5678', 188.70, 1)

INSERT INTO dbo.Tarjetas (numero, code, expiration, dinero)
VALUES 
('1234567890123456', '123', '2024-12-31', 500.00),
('9876543210987654', '456', '2025-06-30', 1000.00),
('1111222233334444', '789', '2023-09-30', 750.00),
('5555666677778888', '012', '2024-03-31', 250.00),
('9999000011112222', '345', '2025-01-31', 1500.00),
('4444555566667777', '678', '2023-12-31', 200.00),
('8888999912345678', '901', '2024-08-31', 800.00),
('9876987698769876', '234', '2025-02-28', 1200.00),
('5555444433332222', '567', '2023-11-30', 400.00),
('2222333344445555', '890', '2024-09-30', 950.00),
('6666777788889999', '123', '2024-05-31', 700.00),
('1212121212121212', '456', '2025-03-31', 300.00),
('1313131313131313', '789', '2024-10-31', 650.00),
('1414141414141414', '012', '2024-07-31', 850.00),
('1515151515151515', '345', '2025-04-30', 1100.00);

INSERT INTO dbo.Productos (Name, Cantidad, Precio)
VALUES 
('Producto 1', 10, 25.50),
('Producto 2', 20, 35.75),
('Producto 3', 15, 42.25),
('Producto 4', 8, 18.90),
('Producto 5', 25, 50.00),
('Producto 6', 30, 60.75),
('Producto 7', 12, 27.50),
('Producto 8', 18, 38.25),
('Producto 9', 22, 45.90),
('Producto 10', 5, 12.75),
('Producto 11', 14, 32.50),
('Producto 12', 17, 40.25),
('Producto 13', 9, 21.90),
('Producto 14', 28, 55.00),
('Producto 15', 11, 30.75);


INSERT INTO dbo.Users (Name, Number, Email, Password, TypeU, Status) 
VALUES 
('John Doe', '123456789', 'john@example.com', 'password123', 'A', 1),
('Jane Smith', '987654321', 'jane@example.com', 'secret456', 'D', 1),
('Alice Johnson', '555555555', 'alice@example.com', 'pass1234', 'U', 1),
('Bob Brown', '111222333', 'bob@example.com', 'qwerty123', 'A', 0),
('Charlie Davis', '444444444', 'charlie@example.com', 'abc123', 'D', 1),
('David Lee', '999888777', 'david@example.com', 'davidpass', 'U', 0),
('Emily White', '666777888', 'emily@example.com', 'password456', 'A', 1),
('Frank Martin', '333222111', 'frank@example.com', 'frankpass', 'D', 1),
('Grace Clark', '123123123', 'grace@example.com', 'grace123', 'U', 1),
('Henry Taylor', '789789789', 'henry@example.com', 'henrypass', 'A', 0),
('Isabella Martinez', '456456456', 'isabella@example.com', 'isapass', 'D', 1),
('Jack Wilson', '987987987', 'jack@example.com', 'jackpass', 'U', 1),
('Karen Anderson', '654654654', 'karen@example.com', 'karen123', 'A', 1),
('Liam Thompson', '321321321', 'liam@example.com', 'liampass', 'D', 0),
('Mia Garcia', '101010101', 'mia@example.com', 'miapass', 'U', 1);
