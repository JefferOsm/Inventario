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
select tipo_medicamentoID "ID", tipo_medicamento "Nombre" from Tipo_Medicamento;

-- Ver detalle Medicamentos
Create view verMedicamentos as
select medicamentoID "ID",nom_medicamento "Nombre", Tipo_medicamento.tipo_medicamento "Tipo",
Laboratorio.laboratorio "Laboratorio",contenido "Contenido",
cantidad_stock "Cantidad",fecha_vencimiento "Fecha Vencimiento",
precio_compra "Precio Compra",precio_venta "Precio Venta",
registro_sanitario "Codigo Sanitario" from Medicamento inner join Tipo_medicamento on 
Medicamento.tipo_medicamentoID= Tipo_medicamento.tipo_medicamentoID inner join Laboratorio on 
Medicamento.laboratorioID= Laboratorio.laboratorioID order by MedicamentoID asc;

--Descuentos
Create view verDescuentos as
select descuentoID "ID", descuento_tercera_edad "Tercera Edad",descuento_general "General"
from Descuento;


--Ventas
create view verVentas as
select numero_ventaID "ID",fecha "Fecha", tipo_pago "Pago",ISV "ISV",
subtotal "SubTotal", descuento "Descuento", total "Total" from Ventas
order by numero_ventaID asc;

--Compras
create view verCompras as
select compraID "ID",fecha "Fecha",Proveedor.proveedor "Proveedor", tipo_pago "Pago",ISV "ISV",
subtotal "SubTotal", total "Total" from Compras inner join Proveedor
on Compras.proveedorID=Proveedor.proveedorID
order by compraID asc;

--Devoluciones
create view verDevoluciones as
select devolucionID "ID", ventaID "Venta", Medicamento.nom_medicamento "Medicamento",
Tipo_medicamento.tipo_medicamento "Tipo", cantidad "Cantidad Devuelta",
fecha "Fecha Devolucion", motivo_devolucion "Motivo", total "Total Devuelto"
from Devolucion_venta inner join Medicamento
on Devolucion_venta.medicamentoID= Medicamento.medicamentoID
inner join Tipo_medicamento on 
Medicamento.tipo_medicamentoID= Tipo_medicamento.tipo_medicamentoID;


