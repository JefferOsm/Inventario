using System;
using System.Data;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Drawing;

namespace Inventario_Farmacia
{
    class BD
    {
        private string conectionString;
        private NpgsqlConnection con;
        public bool conecto;
        public string ConnectionStringActual { get; set; }

        public BD()
        {
            this.conectionString = "Server=localhost;Port=5432;Database=Inventario;User Id=postgres;Password=jeffer;";
            this.con = new NpgsqlConnection(conectionString);
            this.ConnectionStringActual = conectionString;
        }
        public void AbrirConexion()
        {
            this.con.Open();
        }

        public void CerrarConexion()
        {

             this.con.Close();

        }

        public void Nuevaconexion(string usuario, string pass)
        {
            this.conectionString = "Server=localhost;Port=5432;Database=Inventario;User Id='" + usuario + "';Password='" + pass + "';";
            this.con = new NpgsqlConnection(conectionString);
            this.con.Open();
        }


        public void VerificarUsuario(string usuario, string pass)
        {
            try
            {
                AbrirConexion();
                string sql = "SELECT COUNT(*) FROM pg_user WHERE usename= '" + usuario + "'";
                NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
                long userCount = (long)cursor.ExecuteScalar();
                if (userCount > 0)
                {
                    CerrarConexion();
                    conecto = true;
                    Nuevaconexion(usuario, pass);
                    AbrirConexion();
                    MessageBox.Show("Bienvenido " + usuario);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       

        public DataTable GetProveedor()
        {
            string sql = "SELECT *From verProveedores";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable getPais()
        {
            string sql = "SELECT *From verPaises";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable getCiudad()
        {
            string sql = "SELECT *From verCiudades";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public void InsertarProveedores(string nombre, string pais, string ciudad, string direccion, string email, string tel)
        {
            string sql = "insert into Proveedor(proveedor,paisID,ciudadID,direccion,email,telefono) values('" + nombre + "'," + pais + ", " + ciudad + ", '" + direccion + "', '" + email + "', '" + tel + "' )";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);

            try
            {
                cursor.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void UpdateProveedores(string nombre, string pais, string ciudad, string direccion, string email, string tel, string referencia)
        {
            string sql = "update Proveedor set proveedor= '" + nombre + "', paisID=" + pais + ", ciudadID=" + ciudad + ", direccion='" + direccion + "', email='" + email + "', telefono='" + tel + "' where proveedorID=" + referencia +" ";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Actualizado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteProveedor(string refe)
        {
            string sql = "DELETE FROM Proveedor WHERE proveedorID = " + refe;
            NpgsqlCommand command = new NpgsqlCommand(sql, con);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
        public DataTable getLaboratorio()
        {
            string sql = "SELECT *From verLaboratorios";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public void InsertarLaboratorio(string nombre, string pais, string ciudad, string direccion, string tel)
        {
            string sql = "INSERT INTO Laboratorio (laboratorio, paisID, ciudadID, direccion, telefono) " +
                         "VALUES ('" + nombre + "', " + pais + ", " + ciudad + ", '" + direccion + "', '" + tel + "')";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, con);
            try
            {
                cursor.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateLaboratorio(string nombre, string pais, string ciudad, string direccion, string tel, string refe)
        {
            string sql = "update Laboratorio set laboratorio='" + nombre + "', paisID=" + pais + ", ciudadID=" + ciudad + ", direccion='" + direccion + "', telefono='" + tel + "' where laboratorioID=" + refe;
            NpgsqlCommand cursor = new NpgsqlCommand(sql, con);
            try
            {
                MessageBox.Show("Actualizado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteLaboratorio(string refe)
        {
            string sql = "delete from Laboratorio where laboratorioID=" + refe + "";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public DataTable getTipos()
        {
            string sql = "SELECT *From verTipoMedicamento";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public void insertarTipo(string nombre)
        {
            string sql = "insert into Tipo_medicamento(tipo_medicamento) values('" + nombre + "')";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                cursor.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateTipo(string nombre, string refe)
        {
            string sql = "UPDATE Tipo_medicamento SET tipo_medicamento = '" + nombre + "' WHERE tipo_medicamentoID = " + refe;
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            try
            {
                MessageBox.Show("Actualizado Correctamente");
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteTipo(string refe)
        {
            string sql = "delete from Tipo_medicamento where tipo_medicamentoID=" + refe + "";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        //BACK MEDICAMENTOS
        public DataTable getMedicamentos()
        {
            string sql = "select * from verMedicamentos";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cursor);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public void InsertarMedicamentos(string tipo, string laboratorio, string nombre, string contenido, string cant, string fecha, string compra, string venta, string sanitario)
        {
            string sql = "INSERT INTO Medicamento(tipo_medicamentoID, laboratorioID, nom_medicamento, contenido, cantidad_stock, fecha_vencimiento, precio_compra, precio_venta, registro_sanitario) " +
                         "VALUES (" + tipo + ", " + laboratorio + ", '" + nombre + "', '" + contenido + "', " + cant + ", '" + fecha + "', " + compra + ", " + venta + ", '" + sanitario + "')";

            NpgsqlCommand cursor = new NpgsqlCommand(sql, con);
            try
            {
                cursor.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente, ir al area de inventario para verificar los cambios");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteMedicamento(string refe)
        {
            string sql = "delete from Medicamento where medicamentoID=" + refe + "";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void UpdateMedicamento(string nombre, string cont, string stock, string fecha, string precioC, string precioV, string san ,string refe)
        {
            string sql = "UPDATE Medicamento SET nom_medicamento = '" + nombre + "',contenido='"+cont+"',cantidad_stock="+stock+",fecha_vencimiento='"+fecha+"', "+
                          "precio_compra="+precioC+",precio_venta="+precioV+",registro_sanitario='"+san+"' WHERE medicamentoID = " + refe;
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            try
            {
                MessageBox.Show("Actualizado Correctamente");
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // BACK PARA DESCUENTOS
        public DataTable GetDescuentos()
        {
            string sql = "SELECT *From verDescuentos";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public void insertarDescuento(string terceraEdad, string general)
        {
            string sql = "insert into Descuento(descuento_tercera_edad, descuento_general) values(" + terceraEdad + ", "+ general+")";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                cursor.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteDescuentos(string refe)
        {
            string sql = "delete from Descuento where descuentoID=" + refe + "";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //BACK VENTAS

        public void insertarVenta(string id, string descuentoID, string fecha, string metodoPago, string ISV, string subTotal, string descuentoT, string total)
        {
            string sql = "insert into Ventas(numero_ventaID,descuentoID,fecha,tipo_pago,ISV,subtotal,descuento,total)"+
                          " values('" + id + "', " + descuentoID + ",'"+fecha+"','"+metodoPago+"',"+ISV+","+subTotal+","+descuentoT+","+total+")";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void insertarDetalleVenta(string ventaID, string medicamentoID, string cantidad, string importe)
        {
            string sql = "insert into Detalle_venta(ventaID,medicamentoID,cantidad,importe) values('" + ventaID + "', " + medicamentoID + ","+cantidad+","+importe+")";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                cursor.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void updateStock(string cantidad, string refe)
        {
            string sql = "UPDATE Medicamento SET cantidad_stock = " + cantidad + " WHERE medicamentoID = " + refe;
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateVenta(string ISV, string subtotal, string descuento, string total ,string refe)
        {
            string sql = "UPDATE Ventas SET ISV = " + ISV + ", subtotal= " + subtotal + ",descuento=" + descuento + ",total=" + total + " WHERE numero_ventaID = '" + refe + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getProductosVenta(string idVenta)
        {
            string sql = "select Medicamento.medicamentoID as ID,Medicamento.nom_medicamento as Nombre,Medicamento.contenido as Concentracion,"+
                          "Tipo_medicamento.tipo_medicamento as Tipo, Medicamento.precio_venta as Precio , Medicamento.cantidad_stock as Stock, Detalle_venta.cantidad as Cantidad ," +
                          "Detalle_venta.importe as Total FROM Detalle_venta inner join Ventas on Detalle_venta.ventaID=Ventas.numero_ventaID "+
                          "inner join Medicamento on Detalle_venta.medicamentoID=Medicamento.medicamentoID inner join Tipo_medicamento on "+
                          "Medicamento.tipo_medicamentoID= Tipo_Medicamento.tipo_medicamentoID WHERE Detalle_venta.ventaID='"+idVenta+"'";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public void deleteProductoVenta(string venta, string medicamento)
        {
            string sql = "delete from Detalle_venta where ventaID='" + venta + "' AND medicamentoID="+medicamento+"";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //BACK COMPRAS
        public void insertCompra(string id, string fecha, string proveedorID , string metodoPago, string ISV, string subtotal, string total)
        {
            string sql = "insert into Compras(compraID,fecha,proveedorID,tipo_pago,ISV,subtotal,total)" +
                          " values('" + id + "','" + fecha + "'," + proveedorID + ",'" + metodoPago + "'," + ISV + ","+subtotal+"," + total + ")";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void insertarDetalleCompra(string compraID, string medicamentoID, string cantidad, string importe)
        {
            string sql = "insert into Detalle_compra(compraID,medicamentoID,cantidad,importe) values('" + compraID + "', " + medicamentoID + "," + cantidad + "," + importe + ")";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                cursor.ExecuteNonQuery();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateCompra(string ISV, string subtotal, string total, string refe)
        {
            string sql = "UPDATE Compras SET ISV = " + ISV + ", subtotal= " + subtotal + ",total=" + total + " WHERE compraID = '" + refe + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable getProductosCompra(string idCompra)
        {
            string sql = "select Medicamento.medicamentoID as ID,Medicamento.nom_medicamento as Nombre,Medicamento.contenido as Concentracion," +
                          "Tipo_medicamento.tipo_medicamento as Tipo,Medicamento.cantidad_stock as Stock, Detalle_compra.cantidad as Cantidad ," +
                          "Detalle_compra.importe as Total FROM Detalle_compra inner join Compras on Detalle_compra.compraID=Compras.compraID  " +
                          "inner join Medicamento on Detalle_compra.medicamentoID=Medicamento.medicamentoID inner join Tipo_medicamento on  " +
                          "Medicamento.tipo_medicamentoID= Tipo_Medicamento.tipo_medicamentoID WHERE Detalle_compra.compraID='" + idCompra + "'";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }


        public void deleteProductoCompra(string compra, string medicamento)
        {
            string sql = "delete from Detalle_compra where compraID='" + compra + "' AND medicamentoID=" + medicamento + "";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //BACK PARA CRUD VENTAS Y COMPRAS
        public DataTable GetCompras()
        {
            string sql = "SELECT *From verCompras";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public DataTable GetVentas()
        {
            string sql = "SELECT *From verVentas";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
        public void deleteVentas(string refe)
        {
            string sql = "delete from Ventas where numero_ventaID='" + refe + "'";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteCompras(string refe)
        {
            string sql = "delete from Compras where compraID='" + refe + "'";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                MessageBox.Show("Eliminado Correctamente");
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Back devolucion Venta
        public void insertDevolucion(string id, string ventaID, string medicamentoID, string cantidad, string motivo, string fecha, string total)
        {
            string sql = "insert into Devolucion_venta(devolucionID,ventaID,medicamentoID,cantidad,motivo_devolucion,fecha,total)" +
                          " values('" + id + "','" + ventaID + "'," + medicamentoID + "," + cantidad + ",'" + motivo + "','" + fecha + "'," + total + ")";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            try
            {
                cursor.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void UpdateDevolucion(string cantidad, string impor, string idVenta, string idProducto)
        {
            string sql = "UPDATE Detalle_venta SET cantidad = " + cantidad + ", importe= " + impor + " WHERE ventaID = '" + idVenta + "' AND medicamentoID="+idProducto+";";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateDevVenta(string subtotal,string total, string refe)
        {
            string sql = "UPDATE Ventas SET subtotal= " + subtotal + ",total=" + total + " WHERE numero_ventaID = '" + refe + "';";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable GetDevoluciones()
        {
            string sql = "SELECT *From verDevoluciones";
            NpgsqlCommand cursor = new NpgsqlCommand(sql, this.con);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cursor);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }


    }
}
