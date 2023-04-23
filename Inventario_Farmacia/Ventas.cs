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
    public partial class Ventas : Form
    {
        private BD bd = new BD();
        private int Nventa = Properties.Settings.Default.Nventa;
        private string idMedicamento;
        private string idDescuentos;
        private decimal subtotal;
        private decimal ISV;
        private decimal descuento;
        private decimal total;
        private decimal stockActualizado;
        private string idProductoEliminar;
        private string idventaEliminar;
        private decimal importeRest;
        private string cantidadSum;
        private string stockSum;
        public Ventas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            list_medicamentos medicamentos = new list_medicamentos();
            medicamentos.ShowDialog();
            txt_IDmedicamento.Text = medicamentos.idMedicamento;
            txt_tipoMedicamento.Text = medicamentos.tipoMed;
            txt_medicamento.Text = medicamentos.nombre;
            txt_precio.Text = medicamentos.precio;
            txt_concentracion.Text = medicamentos.concentracion;
            txt_stock.Text = medicamentos.cantidad;
            this.idMedicamento = medicamentos.idMedicamento;
            btn_agregar.Enabled = true;

            decimal cantidad = 0;
            if (txt_cantidad.Text == "")
            {
                cantidad = 0;
            }
            else
            {
                cantidad = Convert.ToDecimal(txt_cantidad.Text);
            }
            decimal total = cantidad * Convert.ToDecimal(txt_precio.Text);
            txt_importe.Text = total.ToString();
        }


        private void btn_descuento_Click(object sender, EventArgs e)
        {
            Fac_descuentos descuento = new Fac_descuentos();
            descuento.ShowDialog();
            txt_descuento.Text = Convert.ToString(descuento.total);
            this.idDescuentos = descuento.idDescuento;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ocultar();
            txt_Nventa.Text = "VN" + Nventa;
            if (txt_IDmedicamento.Text == "")
            {
                btn_agregar.Enabled = false;
            }
            else
            {
                btn_agregar.Enabled = true;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un dígito numérico o una tecla especial
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
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
            decimal total = cantidad * Convert.ToDecimal(txt_precio.Text);
            txt_importe.Text = total.ToString();
        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.Nventa = Nventa;
            Properties.Settings.Default.Save();

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
         
            if (txt_descuento.Text == "0" || txt_tipoPago.Text=="" )
            {
                MessageBox.Show("Seleccione el descuento y metodo de pago para continuar");
            }
            else
            {
                DateTime fecha = txt_fechaCompra.Value;
                string fechaFormat = fecha.ToString("yyyy-MM-dd");
                //INSERTAR VENTA
                bd.AbrirConexion();
                bd.insertarVenta(txt_Nventa.Text, idDescuentos, fechaFormat, txt_tipoPago.Text,txt_ISV.Text, txt_subTotal.Text, txt_descuento.Text, txt_totalPago.Text);
                bd.CerrarConexion();
                mostrar();
            }
        }

        private void ocultar() {
            db_medi.Visible = false;
            gb_ag.Visible = false;
            dgv_ventaProductos.Visible = false;
            txt_subTotal.Visible = false;
            txt_totalPago.Visible = false;
        }
        private void mostrar()
        {
            db_medi.Visible = true;
            gb_ag.Visible = true;
            dgv_ventaProductos.Visible = true;
            txt_subTotal.Visible = true;
            txt_totalPago.Visible = true;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(txt_cantidad.Text=="0")
            {
                MessageBox.Show("Ingresar la cantidad a comprar");
            }
            else
            {

                //actualizar stock producto
                stockActualizado = Convert.ToDecimal(txt_stock.Text) - Convert.ToDecimal(txt_cantidad.Text);
                if (stockActualizado <= 0)
                {
                    MessageBox.Show("No hay suficiente stock de este producto");
                }
                else
                {
                    subtotal = subtotal + Convert.ToDecimal(txt_importe.Text);
                    ISV = subtotal * Convert.ToDecimal(txt_ISV.Text);
                    descuento = subtotal * Convert.ToDecimal(txt_descuento.Text);
                    total = subtotal + ISV - descuento;

                    txt_subTotal.Text = subtotal.ToString();
                    txt_totalPago.Text = total.ToString();

                    bd.AbrirConexion();
                    bd.updateStock(stockActualizado.ToString(),txt_IDmedicamento.Text);
                    bd.CerrarConexion();

                    //Actualizar Venta
                    bd.AbrirConexion();
                    bd.updateVenta(txt_ISV.Text, txt_subTotal.Text, txt_descuento.Text, txt_totalPago.Text, txt_Nventa.Text);
                    bd.CerrarConexion();

                    //INSERTAR EL DETALLE
                    bd.AbrirConexion();
                    bd.insertarDetalleVenta(txt_Nventa.Text, txt_IDmedicamento.Text, txt_cantidad.Text, txt_importe.Text);
                    bd.CerrarConexion();

                    //llenar GRID
                    llenarGridDetalle();
                }


                txt_cantidad.Text = "0";
                txt_importe.Text = "0";

            }
          
        }

        private void llenarGridDetalle()
        {
            bd.AbrirConexion();
            this.dgv_ventaProductos.DataSource = bd.getProductosVenta(txt_Nventa.Text);
            bd.CerrarConexion();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ocultar();
            limpiar();
            Nventa++;
            txt_Nventa.Text = "VN" + Nventa;
        }

        private void limpiar()
        {
            txt_IDmedicamento.Text = "";
            txt_tipoMedicamento.Text = "";
            txt_concentracion.Text = "";
            txt_medicamento.Text = "";
            txt_stock.Text = "";
            txt_precio.Text = "0";
            txt_cantidad.Text = "0";
            txt_importe.Text = "";
            txt_subTotal.Text = "0";
            txt_ISV.Text = "0.15";
            txt_totalPago.Text = "0";
            txt_descuento.Text = "0";
            dgv_ventaProductos.DataSource = null;
            dgv_ventaProductos.Columns.Clear();

            subtotal = 0;
            ISV = 0;
            descuento = 0;
            total = 0;


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            bd.AbrirConexion();
            bd.deleteProductoVenta(idventaEliminar, idProductoEliminar);
            bd.CerrarConexion();

            llenarGridDetalle();

            decimal cantidaStock;
            cantidaStock = Convert.ToDecimal(cantidadSum) + Convert.ToDecimal(stockSum);

            bd.AbrirConexion();
            bd.updateStock(cantidaStock.ToString(), idProductoEliminar);
            bd.CerrarConexion();

            subtotal = subtotal - importeRest;
            ISV = subtotal * Convert.ToDecimal(txt_ISV.Text);
            descuento = subtotal * Convert.ToDecimal(txt_descuento.Text);
            total = subtotal + ISV - descuento;

            txt_subTotal.Text = subtotal.ToString();
            txt_totalPago.Text = total.ToString();


            //Actualizar Venta
            bd.AbrirConexion();
            bd.updateVenta(txt_ISV.Text, txt_subTotal.Text, txt_descuento.Text, txt_totalPago.Text, txt_Nventa.Text);
            bd.CerrarConexion();

        }

        private void dgv_ventaProductos_Click(object sender, EventArgs e)
        {
            idProductoEliminar = Convert.ToString(this.dgv_ventaProductos.SelectedRows[0].Cells[0].Value);
            idventaEliminar = txt_Nventa.Text;
            importeRest= Convert.ToDecimal(this.dgv_ventaProductos.SelectedRows[0].Cells[6].Value);
            cantidadSum= Convert.ToString(this.dgv_ventaProductos.SelectedRows[0].Cells[5].Value);
            stockSum= Convert.ToString(this.dgv_ventaProductos.SelectedRows[0].Cells[4].Value);
        }
    }
}
