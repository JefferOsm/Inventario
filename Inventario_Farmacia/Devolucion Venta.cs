using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_Farmacia
{
    public partial class Devolucion_Venta : Form
    {
        private BD bd = new BD();
        public string idVenta;
        public string idMed;
        public string totalMed;
        public string precioMed;
        private int Ndev = Properties.Settings.Default.NdevolucionV;
        public Devolucion_Venta()
        {
            InitializeComponent();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            devVentas ventas = new devVentas();
            ventas.ShowDialog();
            txt_idVenta.Text = ventas.idVenta;
            idVenta = ventas.idVenta;
            txt_totalVenta.Text = ventas.total;
            txt_descuento.Text = ventas.descuento;
            txt_subt.Text = ventas.subtotal;
        }

        private void Devolucion_Venta_Load(object sender, EventArgs e)
        {
            txt_Ndevolucion.Text = "DVN" + Ndev;
        }

        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            devProductos med = new devProductos();
            med.idVenta = txt_idVenta.Text;
            med.ShowDialog();
            idMed = med.idMed;
            txt_IDmedicamento.Text = med.idMed;
            txt_medicamento.Text = med.nombre;
            txt_cantidadVendida.Text = med.cantidad;
            txt_stock.Text = med.stock;
            totalMed = med.total;
            precioMed = med.precio;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
      
            if(txt_idVenta.Text=="" || txt_IDmedicamento.Text == "")
            {
                MessageBox.Show("Ingrese la venta y el medicamento que desea devolver");
            }
            else
            {

                DateTime fecha = txt_fechaCompra.Value;
                string fechaFormat = fecha.ToString("yyyy-MM-dd");
                Ndev++;
                txt_Ndevolucion.Text = "DVN" + Ndev;

                bd.AbrirConexion();
                bd.insertDevolucion(txt_Ndevolucion.Text,txt_idVenta.Text,txt_IDmedicamento.Text,txt_cantidad.Text,txt_motivo.Text,fechaFormat,txt_importe.Text);
                bd.CerrarConexion();

                decimal cantidad = 0;
                decimal Ntotal = 0;
                cantidad = Convert.ToDecimal(txt_cantidadVendida.Text) - Convert.ToDecimal(txt_cantidad.Text);
                Ntotal = Convert.ToDecimal(totalMed) - Convert.ToDecimal(txt_importe.Text);

                if (cantidad <= 0)
                {
                    MessageBox.Show("No puede devolver mas de los que compro");
                }
                else
                {
                    bd.AbrirConexion();
                    bd.UpdateDevolucion(cantidad.ToString(), Ntotal.ToString(), txt_idVenta.Text, txt_IDmedicamento.Text);
                    bd.CerrarConexion();

                    decimal NsubtotalV = 0;
                    decimal NtotalV = 0;
                    NsubtotalV = Convert.ToDecimal(txt_subt.Text) - Convert.ToDecimal(txt_importe.Text);
                    NtotalV = Convert.ToDecimal(txt_totalVenta.Text) - Convert.ToDecimal(txt_importe.Text);

                    bd.AbrirConexion();
                    bd.updateDevVenta(NsubtotalV.ToString(), NtotalV.ToString(), txt_idVenta.Text);
                    bd.CerrarConexion();

                    decimal stockActualizado = 0;
                    stockActualizado = Convert.ToDecimal(txt_stock.Text) + Convert.ToDecimal(txt_cantidad.Text);

                    bd.AbrirConexion();
                    bd.updateStock(stockActualizado.ToString(), txt_IDmedicamento.Text);
                    bd.CerrarConexion();
                }
                MessageBox.Show("Devolucion Completada");
                
            }
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            decimal cantidad = 0;
            if (txt_cantidad.Text == "")
            {
                cantidad = 0;
            }
            else
            {
                cantidad = Convert.ToDecimal(txt_cantidad.Text);
            }
            decimal total = cantidad * Convert.ToDecimal(precioMed)-(cantidad* Convert.ToDecimal(precioMed)*Convert.ToDecimal(txt_descuento.Text));
            txt_importe.Text = total.ToString();
        }

        private void Devolucion_Venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.NdevolucionV = Ndev;
            Properties.Settings.Default.Save();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un dígito numérico o una tecla especial
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
            }
        }
    }
}
