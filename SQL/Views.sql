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

--Descuentos
Create view verDescuentos as
select descuentoID "ID", descuento_tercera_edad "Tercera Edad",descuento_general "General"
from Descuento;

--Compras
create view productosCompra as
select Compras.compraID "ID", Medicamento.medicamentoID as "ID Medicamento",Medicamento.nom_medicamento as Nombre,Medicamento.contenido as Concentracion,
Tipo_medicamento.tipo_medicamento as Tipo, Medicamento.cantidad_stock as Stock, Detalle_compra.cantidad "Cantidad Comprada" ,
Detalle_compra.importe as Total FROM Detalle_compra
inner join Compras on
Detalle_compra.compraID=Compras.compraID
inner join Medicamento on
Detalle_compra.medicamentoID=Medicamento.medicamentoID
inner join Tipo_medicamento on 
Medicamento.tipo_medicamentoID= Tipo_Medicamento.tipo_medicamentoID;


--Ventas
create view productosVenta as
select Ventas.numero_ventaID "ID", Medicamento.medicamentoID as "ID Medicamento",Medicamento.nom_medicamento as Nombre,Medicamento.contenido as Concentracion,
Tipo_medicamento.tipo_medicamento as Tipo, Medicamento.cantidad_stock as Stock, Detalle_venta.cantidad "Cantidad Vendida" ,
Detalle_venta.importe as Total FROM Detalle_venta
inner join Ventas on
Detalle_venta.ventaID=Ventas.numero_ventaID
inner join Medicamento on
Detalle_venta.medicamentoID=Medicamento.medicamentoID
inner join Tipo_medicamento on 
Medicamento.tipo_medicamentoID= Tipo_Medicamento.tipo_medicamentoID;


