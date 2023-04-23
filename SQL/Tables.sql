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
	on delete cascade on update cascade
);


Create table Descuento (
	descuentoID SERIAL not null,
	descuento_tercera_edad float,
	descuento_general float,
	constraint descuentoPK primary key (descuentoID)
);

CREATE TABLE Ventas(
	numero_ventaID VARCHAR(15) not null,
	descuentoID INT,
	fecha DATE,
	tipo_pago VARCHAR(20),
	ISV FLOAT,
	subtotal FLOAT,
	descuento FLOAT,
	total FLOAT,
	CONSTRAINT PKventa PRIMARY KEY(numero_ventaID),
	CONSTRAINT FKventa_descuento FOREIGN KEY(descuentoID) REFERENCES descuento(descuentoID)
	on delete cascade on update cascade
);

CREATE TABLE Detalle_venta(
	ventaID VARCHAR(15),
	medicamentoID INT,
	cantidad INT,
	importe FLOAT,
	CONSTRAINT FKdetalleV_venta FOREIGN KEY(ventaID) REFERENCES ventas(numero_ventaID)
	on delete cascade on update cascade,
	CONSTRAINT FKdetalleV_medicamento FOREIGN KEY(medicamentoID) REFERENCES Medicamento(medicamentoID)
	on delete cascade on update cascade
);

CREATE TABLE Compras(
	compraID VARCHAR(15) not null,
	fecha DATE,
	proveedorID INT,
	tipo_pago VARCHAR(20),
	ISV FLOAT,
	subtotal FLOAT,
	total FLOAT,
	CONSTRAINT PKcompra PRIMARY KEY(compraID),
	CONSTRAINT FKcompra_proveedor FOREIGN KEY(proveedorID) REFERENCES Proveedor(proveedorID)
	on delete cascade on update cascade
);
CREATE TABLE Detalle_compra(
	compraID VARCHAR(15),
	medicamentoID INT,
	cantidad INT,
	importe FLOAT,
	CONSTRAINT FKdetalleV_compra FOREIGN KEY(compraID) REFERENCES Compras(compraID)
	on delete cascade on update cascade,
	CONSTRAINT FKdetalleV_medicamento FOREIGN KEY(medicamentoID) REFERENCES Medicamento(medicamentoID)
	on delete cascade on update cascade
);


Create table Devolucion_venta (
	devolucionID Varchar(15) not null,
	ventaID Varchar(15),
	medicamentoID INT,
	cantidad int,
	motivo_devolucion varchar(50),
	fecha date,
	total float,
	constraint devolucionPK primary key (devolucionID),
	CONSTRAINT FKdevolucion_venta FOREIGN KEY(ventaID) REFERENCES ventas(numero_ventaID)
	on delete cascade on update cascade,
	CONSTRAINT FKdetalleV_medicamento FOREIGN KEY(medicamentoID) REFERENCES Medicamento(medicamentoID)
	on delete cascade on update cascade
);








	
	
	