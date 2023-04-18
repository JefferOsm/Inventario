using System;
using System.Data;
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
        private string conectionString = "Server=localhost;Port=5432;Database=Inventario;User Id=postgres;Password=jeffer;";
        private NpgsqlConnection con;

        public BD()
        {
            this.con = new NpgsqlConnection(conectionString);
        }
        public void AbrirConexion()
        {
                this.con.Open();
        }

        public void CerrarConexion()
        {

             this.con.Close();

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









    }
}
