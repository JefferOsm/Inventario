-- Ver detalle ciudades
create view verCiudades as
select ciudadID "ID", nombre_ciudad "Ciudad" from Ciudad;

-- Ver detalle paises
create view verPaises as
select paisID "ID", nombre_pais "Pais" from Pais;

-- Ver detalle Laboratorios
create view verLaboratorios as
select laboratorioID "ID", laboratorio "Nombre", Pais.nombre_pais "Pais", 
Ciudad.nombre_ciudad "Ciudad", direccion "Direccion", telefono "Telefono"
 from Laboratorio inner join Pais
 on Laboratorio.paisID=Pais.paisID
 inner join Ciudad
 on Laboratorio.ciudadID=Ciudad.ciudadID order by laboratorioID asc;
 
 -- Ver detalle Proveedores
 create view verProveedores as
select proveedorID "ID", proveedor "Nombre", Pais.nombre_pais "Pais", 
Ciudad.nombre_ciudad "Ciudad", direccion "Direccion", email "Email", telefono "Telefono"
 from Proveedor inner join Pais
 on Proveedor.paisID=Pais.paisID
 inner join Ciudad
 on Proveedor.ciudadID=Ciudad.ciudadID order by proveedorID asc;


-- Ver detalle tipos de medicamento
create view verTipoMedicamento as
select tipo_medicamentoID "ID", tipo_medicamento "Nombre" from Tipo_Medicamento

-- Ver detalle Medicamentos
Create view verMedicamentos as
select medicamentoID "ID",nom_medicamento "Nombre", Tipo_medicamento.tipo_medicamento "Tipo", Laboratorio.laboratorio "Laboratorio",
contenido "Contenido",cantidad_stock "Cantidad",fecha_vencimiento "Fecha Vencimiento",precio_compra "Precio Compra",precio_venta "Precio Venta"
 from Medicamento inner join Tipo_medicamento on Medicamento.tipo_medicamentoID= Tipo_medicamento.tipo_medicamentoID
 inner join Laboratorio on Medicamento.laboratorioID= Laboratorio.laboratorioID order by MedicamentoID asc;

