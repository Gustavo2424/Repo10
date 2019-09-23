Create Database FERRETERÍA

Create Table CLIENTES
(
IdCliente int not null identity (1, 1) Primary key,
Nombre varchar(50) not null,
Dirección varchar(100),
Telefono varchar (15),
Email varchar (15),
Rfc varchar (20)
)

Create Table VENDEDORES
(
IdVendedor int not null identity (1, 1) Primary Key,
Nombre varchar(50) not null
)

Create Table FABRICANTES
(
IdFabricante int not null identity (10, 1) Primary Key,
Nombre varchar(50) not null
)

Create Table GARANTÍAS
(
IdGarantía int not null identity (100, 1) Primary Key,
Semanas int not null
)

Create Table PRODUCTOS
(
IdProducto int not null identity (1000, 1) Primary Key,
Nombre varchar (50) not null,
Precio money not null,
IdFabricante int not null,
IdGarantía int not null,
foreign key (IdFabricante) references FABRICANTES(IdFabricante),
foreign key (IdGarantía) references GARANTÍAS(IdGarantía),
)

Create Table VEHÍCULOS
(
IdVehículo int not null identity (100, 100) Primary Key,
Placas varchar (10) not null
)

Create Table ENTREGAS
(
IdEntrega int not null identity (1, 1) Primary Key,
Fecha datetime,
IdVehículo int,
foreign key (IdVehículo) references VEHÍCULOS(IdVehículo)
)

Create Table MÉTODOSPAGO
(
IdMétodoPago int not null identity (10,10) Primary Key,
Descripción varchar (40) not null
)

Create Table BANCOS
(
IdBanco int not null identity (10000, 100) Primary Key,
Descripción varchar (70) not null
)

Create Table SUCURSALES
(
IdSucursal int not null identity (50, 5) Primary Key,
IdBanco int not null,
Descripción varchar (30) not null,
Dirección varchar (100),
Teléfono varchar (15)
foreign key (IdBanco) references BANCOS(IdBanco)
)

Create Table VENTAS
(
IdVenta int not null identity (1, 1) Primary Key,
IdCliente int not null,
IdVendedor int not null,
Fecha datetime,
IdVehículo int,
foreign key (IdCliente) references CLIENTES(IdCliente),
foreign key (IdVendedor) references VENDEDORES(IdVendedor),
foreign key (IdVehículo) references VEHÍCULOS(IdVehículo),
)

Create Table DETALLEVENTA
(
IdVenta int not null,
IdProducto int not null,
PrecioUnitario money,
Cantidad int,
MontoTotal money,
foreign key (IdVenta) references VENTAS(IdVenta),
foreign key (IdProducto) references PRODUCTOS(IdProducto)
)


Create Table VENTACOBRO
(
IdVenta int not null,
IdMétodoPago int not null,
Submonto money,
IdBanco int,
foreign key (IdVenta) references VENTAS(IdVenta),
foreign key (IdMétodoPago) references MÉTODOSPAGO(IdMétodoPago),
foreign key (IdBanco) references BANCOS(IdBanco)
)

Create Table ENTREGASDETALLE
(
IdEntrega int not null,
IdVenta int not null,
foreign key (IdEntrega) references ENTREGAS(IdEntrega),
foreign key (IdVenta) references VENTAS(IdVenta),
Primary Key (IdEntrega, IdVenta)
)

SELECT * FROM BANCOS