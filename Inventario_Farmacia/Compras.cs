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
    public partial class Compras : Form
    {
        private BD bd = new BD();
        private int Ncompra = Properties.Settings.Default.Ncompra;
        private string idProv;
        private string idMedicamento;
        private decimal subtotal;
        private decimal ISV;
        private decimal total;
        private decimal stockActualizado;
        private string idProductoEliminar;
        private string idvcompraEliminar;
        private decimal importeRest;
        private string cantidadRest;
        private string stockRest;
        public Compras()
        {
            InitializeComponent();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            Fac_Proveedores proveedor = new Fac_Proveedores();
            proveedor.ShowDialog();
            txt_proveedor.Text = proveedor.nombre;
            txt_idProveedor.Text = proveedor.idProv;
            idProv = proveedor.idProv;
        }

        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            list_medicamentos medicamentos = new list_medicamentos();
            medicamentos.ShowDialog();
            txt_IDmedicamento.Text = medicamentos.idMedicamento;
            txt_tipoMedicamento.Text = medicamentos.tipoMed;
            txt_medicamento.Text = medicamentos.nombre;
            txt_costo.Text = medicamentos.costo;
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
            decimal total = cantidad * Convert.ToDecimal(txt_costo.Text);
            txt_importe.Text = total.ToString();
        }

        private void btn_metodoPago_Click(object sender, EventArgs e)
        {
            Formas_Pago pago = new Formas_Pago();
            pago.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            ocultar();
            txt_Ncompra.Text = "CN" + Ncompra;
            if (txt_IDmedicamento.Text == "")
            {
                btn_agregar.Enabled = false;
            }
            else
            {
                btn_agregar.Enabled = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Ncompra++;
            txt_Ncompra.Text = "CN" + Ncompra;
            limpiar();
            ocultar();
        }

        private void Compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Ncompra = Ncompra;
            Properties.Settings.Default.Save();
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
            decimal total = cantidad * Convert.ToDecimal(txt_costo.Text);
            txt_importe.Text = total.ToString();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un dígito numérico o una tecla especial
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
            }
        }

        private void txt_ISV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            if (txt_idProveedor.Text == "" || txt_tipoPago.Text=="")
            {
                MessageBox.Show("Seleccione el proveedor y el metodo de pago para continuar");
            }
            else
            {
                DateTime fecha = txt_fechaCompra.Value;
                string fechaFormat = fecha.ToString("yyyy-MM-dd");

                //INSERTAR COMPRA
                bd.AbrirConexion();
                bd.insertCompra(txt_Ncompra.Text,fechaFormat, idProv, txt_tipoPago.Text, txt_ISV.Text, txt_subTotal.Text,txt_totalPago.Text);
                bd.CerrarConexion();
                mostrar();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "0")
            {
                MessageBox.Show("Ingresar la cantidad a comprar");
            }
            else
            {

                //actualizar stock producto
                stockActualizado = Convert.ToDecimal(txt_stock.Text) + Convert.ToDecimal(txt_cantidad.Text);
                if (stockActualizado <= 0)
                {
                    MessageBox.Show("No hay stock de este producto");
                }
                else
                {
                    subtotal = subtotal + Convert.ToDecimal(txt_importe.Text);
                    ISV = subtotal * Convert.ToDecimal(txt_ISV.Text);
                    total = subtotal + ISV ;

                    txt_subTotal.Text = subtotal.ToString();
                    txt_totalPago.Text = total.ToString();

                    bd.AbrirConexion();
                    bd.updateStock(stockActualizado.ToString(), txt_IDmedicamento.Text);
                    bd.CerrarConexion();

                    //Actualizar Compra
                    bd.AbrirConexion();
                    bd.updateCompra(txt_ISV.Text, txt_subTotal.Text,txt_totalPago.Text, txt_Ncompra.Text);
                    bd.CerrarConexion();

                    //INSERTAR EL DETALLE
                    bd.AbrirConexion();
                    bd.insertarDetalleCompra(txt_Ncompra.Text, txt_IDmedicamento.Text, txt_cantidad.Text, txt_importe.Text);
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
            this.dgv_compraProductos.DataSource = bd.getProductosCompra(txt_Ncompra.Text);
            bd.CerrarConexion();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            bd.AbrirConexion();
            bd.deleteProductoCompra(idvcompraEliminar, idProductoEliminar);
            bd.CerrarConexion();

            llenarGridDetalle();

            decimal cantidaStock;
            cantidaStock = Convert.ToDecimal(stockRest) - Convert.ToDecimal(cantidadRest);

            bd.AbrirConexion();
            bd.updateStock(cantidaStock.ToString(), idProductoEliminar);
            bd.CerrarConexion();

            subtotal = subtotal - importeRest;
            ISV = subtotal * Convert.ToDecimal(txt_ISV.Text);
            total = subtotal + ISV ;

            txt_subTotal.Text = subtotal.ToString();
            txt_totalPago.Text = total.ToString();


            //Actualizar Venta
            bd.AbrirConexion();
            bd.updateCompra(txt_ISV.Text, txt_subTotal.Text,txt_totalPago.Text, txt_Ncompra.Text);
            bd.CerrarConexion();
        }

        private void dgv_compraProductos_Click(object sender, EventArgs e)
        {
            idProductoEliminar = Convert.ToString(this.dgv_compraProductos.SelectedRows[0].Cells[0].Value);
            idvcompraEliminar = txt_Ncompra.Text;
            importeRest = Convert.ToDecimal(this.dgv_compraProductos.SelectedRows[0].Cells[6].Value);
            cantidadRest = Convert.ToString(this.dgv_compraProductos.SelectedRows[0].Cells[5].Value);
            stockRest = Convert.ToString(this.dgv_compraProductos.SelectedRows[0].Cells[4].Value);
        }
        private void limpiar()
        {
            txt_IDmedicamento.Text = "";
            txt_tipoMedicamento.Text = "";
            txt_concentracion.Text = "";
            txt_medicamento.Text = "";
            txt_stock.Text = "";
            txt_cantidad.Text = "0";
            txt_importe.Text = "";
            txt_subTotal.Text = "0";
            txt_ISV.Text = "0.15";
            txt_totalPago.Text = "0";
            txt_proveedor.Text = "";
            txt_idProveedor.Text = "";
            dgv_compraProductos.DataSource = null;
            dgv_compraProductos.Columns.Clear();

            subtotal = 0;
            ISV = 0;
            total = 0;

        }
        private void ocultar()
        {
            gb_ag.Visible = false;
            gb_medi.Visible = false;
            dgv_compraProductos.Visible = false;
            txt_subTotal.Visible = false;
            txt_totalPago.Visible = false;
        }
        private void mostrar()
        {
            gb_ag.Visible = true;
            gb_medi.Visible = true;
            dgv_compraProductos.Visible = true;
            txt_subTotal.Visible = true;
            txt_totalPago.Visible = true;
        }
    }
}
