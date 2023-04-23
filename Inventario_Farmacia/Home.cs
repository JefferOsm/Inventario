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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void tsm_medicamentos_Click(object sender, EventArgs e)
        {

        }

        private void tsm_medicamentos_Click_1(object sender, EventArgs e)
        {
            Medicamentos medicamentos = new Medicamentos();
            medicamentos.ShowDialog();
        }

        private void tsm_proveedores_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            proveedor.ShowDialog();
        }

        private void tsm_laboratorios_Click(object sender, EventArgs e)
        {
            Laboratorios lab = new Laboratorios();
            lab.ShowDialog();
        }

        private void tsm_categorias_Click(object sender, EventArgs e)
        {
            Tipos_medicamento tipo = new Tipos_medicamento();
            tipo.ShowDialog();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            Inventario invent = new Inventario();
            invent.ShowDialog();
        }

        private void tsm_venta_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.ShowDialog();
        }

        private void tsm_compra_Click(object sender, EventArgs e)
        {
            Compras compra = new Compras();
            compra.ShowDialog();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Detalle_Compras compra = new Detalle_Compras();
            compra.ShowDialog();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Detalle_Ventas venta = new Detalle_Ventas();
            venta.ShowDialog();
        }

        private void btn_descuentos_Click(object sender, EventArgs e)
        {
            Descuentos descuento = new Descuentos();
            descuento.ShowDialog();
        }

        private void tsm_devV_Click(object sender, EventArgs e)
        {
            Devolucion_Venta dev = new Devolucion_Venta();
            dev.ShowDialog();
        }

        private void btn_dev_Click(object sender, EventArgs e)
        {
            verDevoluciones devo = new verDevoluciones();
                devo.ShowDialog();
        }
    }
}
