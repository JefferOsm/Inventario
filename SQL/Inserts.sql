
-- Ciudades
Insert into Ciudad(nombre_ciudad) Values(
	'Tegucigalpa'	
);
Insert into Ciudad(nombre_ciudad) Values(
	'San Pedro Sula'	
);
Insert into Ciudad(nombre_ciudad) Values(
	'Madrid'	
);
Insert into Ciudad(nombre_ciudad) Values(
	'Milan'	
);
Insert into Ciudad(nombre_ciudad) Values(
	'Lima'	
);
Insert into Ciudad(nombre_ciudad) Values(
	'Buenos Aires'	
);


-- Paises
Insert into Pais(nombre_pais) Values(
	'Honduras'	
);
Insert into Pais(nombre_pais) Values(
	'El Salvador'	
);
Insert into Pais(nombre_pais) Values(
	'Peru'	
);
Insert into Pais(nombre_pais) Values(
	'Argentina'	
);
Insert into Pais(nombre_pais) Values(
	'Italia'	
);
Insert into Pais(nombre_pais) Values(
	'España'	
);

-- Laboratorios
insert into Laboratorio(laboratorio,paisID,ciudadID,direccion,telefono) values(
	'PHARMA',
    2,
    3,
    'dict323',
    '985481300'
);
insert into Laboratorio(laboratorio,paisID,ciudadID,direccion,telefono) values(
	'ELIFARMA',
    2,
    2,
    'arequipa',
    '985733594'
);
insert into Laboratorio(laboratorio,paisID,ciudadID,direccion,telefono) values(
	'FARVET',
    3,
    4,
    'abcede',
    '912475603'
);


-- Proovedores
Insert into Proveedor(proveedor,paisID,ciudadID,direccion,email,telefono) values(
	'Proveedor 6',
	1,
	1,
	'Colonia Flor del Campo',
	'farma1@gmail.com',
	'88131223'
);
Insert into Proveedor(proveedor,paisID,ciudadID,direccion,email,telefono) values(
	'Proveedor 2',
	2,
	2,
	'Madrid',
	'farmadrid@gmail.com',
	'14131223'
);


-- Tipos de Medicamento

insert into Tipo_medicamento(tipo_medicamento) values(
	'Aerosol'
);
insert into Tipo_medicamento(tipo_medicamento) values(
	'Capsula'
);
insert into Tipo_medicamento(tipo_medicamento) values(
	'Colirio'
);
insert into Tipo_medicamento(tipo_medicamento) values(
	'Concentración'
);
insert into Tipo_medicamento(tipo_medicamento) values(
	'Crema'
);

-- Medicamentos

insert into Medicamento(tipo_medicamentoID,laboratorioID,nom_medicamento,
contenido,cantidad_stock,fecha_vencimiento,precio_compra,precio_venta,registro_sanitario) values(
	1,
    2,
    'Ibuprofeno',
    '500 mg',
    80,
    '2016-04-20',
    13.50,
    16.30,
    'EN01867');
    
    insert into Medicamento(tipo_medicamentoID,laboratorioID,nom_medicamento,
contenido,cantidad_stock,fecha_vencimiento,precio_compra,precio_venta,registro_sanitario) values(
	2,
    1,
    'Hepabionta',
    '30 mg',
    40,
    '2016-04-22',
    5.00,
    10.80,
    'EN01870');
    
    insert into Medicamento(tipo_medicamentoID,laboratorioID,nom_medicamento,
contenido,cantidad_stock,fecha_vencimiento,precio_compra,precio_venta,registro_sanitario) values(
	3,
    2,
    'Apronax',
    '500 mg',
    90,
    '2016-04-25',
    12.00,
    14.00,
    'EN01868');
    insert into Medicamento(tipo_medicamentoID,laboratorioID,nom_medicamento,
contenido,cantidad_stock,fecha_vencimiento,precio_compra,precio_venta,registro_sanitario) values(
	2,
    4,
    'Naproxeno',
    '90 mg',
    20,
    '2016-04-20',
    3.15,
    6.00,
    'EE032145');
    insert into Medicamento(tipo_medicamentoID,laboratorioID,nom_medicamento,
contenido,cantidad_stock,fecha_vencimiento,precio_compra,precio_venta,registro_sanitario) values(
	2,
    2,
    'Panadol',
    '400 mg',
    100,
    '2016-05-20',
    8.00,
    10.02,
    'EN01967');