Create table Ciudad (
	ciudadID serial not null ,
	nombre_ciudad varchar (50),
	constraint ciudadPK primary key (ciudadID) 
);


Create table Pais (
	paisID SERIAL not null ,
	nombre_pais varchar (150),
	constraint paisPK primary key (paisID)
);


Create table Laboratorio (
	laboratorioID SERIAL not null ,
	laboratorio varchar(100) unique not null,
	paisID int,
	ciudadID int,
	direccion varchar (200),
	telefono char(20),
	constraint laboratorioPK primary key (laboratorioID),
	constraint pais_labFK foreign key (paisID) references Pais (paisID),
	constraint ciudad_labFK foreign key (ciudadID) references Ciudad (ciudadID)	
);


create table Proveedor (
	proveedorID SERIAL not null ,
	proveedor varchar(100),
	paisID int,
	ciudadID int,
	direccion varchar (100),
	email varchar (100),
	telefono char (25),
	constraint proveedorPK primary key (proveedorID),
	constraint paisFK foreign key (paisID) references Pais (paisID),
	constraint ciudadFK foreign key (ciudadID) references Ciudad (ciudadID)
);


Create table Tipo_medicamento (
	tipo_medicamentoID SERIAL not null ,
	tipo_medicamento varchar (50) unique,
	constraint tipo_medicamentoPK primary key (tipo_medicamentoID)
);

Create table Medicamento (
	medicamentoID SERIAL not null ,
	tipo_medicamentoID int,
	laboratorioID int,
	nom_medicamento varchar (100),
	contenido varchar(10),
	cantidad_stock int,
	fecha_vencimiento date,
	precio_compra float,
	precio_venta float,
	registro_sanitario varchar (50),
	constraint medicamentoPK primary key (medicamentoID),
	constraint tipo_medicamentoID foreign key (tipo_medicamentoID) references Tipo_medicamento (tipo_medicamentoID)
);

Create table Tipo_pago (
	tipo_pagoID int not null,
	efectivo boolean,
	tarjeta boolean,
	constraint tipo_pagoPK primary key (tipo_pagoID)
);	

Create table Descuento (
	descuentoID int not null,
	descurnto_tercera_edad float,
	descurnto_general float,
	constraint descuentoPK primary key (descuentoID)
);	

Create table Factura (
	facturaID int not null,
	descuentoID int,
	tipo_pagoID int,
	proveedorID int,
	ISV float,
	subtotal decimal,
	total decimal,
	constraint facturaPK primary key (facturaID),
	constraint descurntoFK foreign key (descuentoID) references  Descuento (descuentoID),
	constraint tipo_pagoFK foreign key (tipo_pagoID) references  Tipo_pago (tipo_pagoID),
	constraint proveedorFK foreign key (proveedorID) references  Proveedor (proveedorID)
);

Create table Devolucion (
	devolucionID int not null,
	devol_compra boolean,
	devol_venta boolean,
	constraint devolucionPK primary key (devolucionID)
);

Create table Detalle_devolucion (
	devolucionID int, 
	paisID int,
	ciudadID int,
	fecha_emision date,
	motivo_devolucion varchar (200),
	constraint devolucionFK foreign key (devolucionID) references Devolucion (devolucionID),
	constraint paisFK foreign key (paisID) references Pais (paisID),
	constraint cuidadFK foreign key (ciudadID) references Ciudad (ciudadID)	
);

Create table Detalle_factura (
	facturaID int,
	medicamentoID int,
	cantidad int,
	fecha_compra date,
	fecha_venta date,
	coste float,
	importe float,
	constraint facturaFK foreign key (facturaID) references Factura (facturaID),
	constraint medicamentoFK foreign key (medicamentoID) references Medicameto (medicamentoID)
);
	
	
	
	