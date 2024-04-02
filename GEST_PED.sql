CREATE DATABASE GEST_PED

CREATE TABLE CLIENTE (
IdCliente INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
Apellido VARCHAR(100) NOT NULL,
CorreoElectronico VARCHAR(250) NOT NULL,
Telefono VARCHAR(15) NOT NULL,
Direccion VARCHAR(250) NOT NULL);

CREATE TABLE PEDIDOS (
IdPedido INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
IdCliente INT NOT NULL,
Fecha DATETIME NOT NULL,
Total MONEY NOT NULL,
Estado VARCHAR(50) NOT NULL,
FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE (IDCLIENTE));

INSERT INTO CLIENTE (Nombre, Apellido, CorreoElectronico, Telefono, Direccion) 
VALUES 
('Juan', 'Pérez', 'juan@example.com', '555-1234', 'Calle Principal 123'),
('María', 'González', 'maria@example.com', '555-5678', 'Avenida Central 456'),
('Pedro', 'Rodríguez', 'pedro@example.com', '555-9876', 'Calle Secundaria 789'),
('Ana', 'López', 'ana@example.com', '555-4321', 'Paseo de la Colina 321'),
('Luis', 'Martínez', 'luis@example.com', '555-2468', 'Calle de la Luna 987'),
('Laura', 'Sánchez', 'laura@example.com', '555-1357', 'Avenida del Sol 654'),
('Carlos', 'Hernández', 'carlos@example.com', '555-3690', 'Calle de la Montaña 369'),
('Sofía', 'Díaz', 'sofia@example.com', '555-7531', 'Avenida de las Flores 753'),
('Daniel', 'Gómez', 'daniel@example.com', '555-1593', 'Calle del Río 159'),
('Elena', 'Vargas', 'elena@example.com', '555-8024', 'Avenida de la Estrella 802');

INSERT INTO PEDIDOS (IdCliente, Fecha, Total, Estado) 
VALUES 
(1, '08-04-01 10:30:00', 50.00, 'Pendiente'),
(2, '2024-04-01 15:45:00', 75.20, 'En Proceso'),
(3, '2024-04-02 09:15:00', 30.50, 'Completado'),
(4, '2024-04-02 12:00:00', 100.75, 'Cancelado'),
(5, '2024-04-02 14:30:00', 65.80, 'Pendiente'),
(6, '2024-04-03 11:20:00', 40.25, 'Completado'),
(7, '2024-04-03 13:45:00', 90.00, 'En proceso'),
(8, '2024-04-03 16:10:00', 120.50, 'Cancelado'),
(9, '2024-04-04 10:00:00', 55.30, 'Pendiente'),
(10, '2024-04-04 14:20:00', 70.60, 'En proceso');

Select *
from CLIENTE
select C.Nombre, SUM(TOTAL) MONTOPEDIDOS
from PEDIDOS P
	INNER JOIN CLIENTE C ON C.IDCLIENTE = P.IDCLIENTE
WHERE P.IdCliente = 1
GROUP BY C.Nombre


