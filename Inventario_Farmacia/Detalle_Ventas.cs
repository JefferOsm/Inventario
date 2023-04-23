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
    public partial class Detalle_Ventas : Form
    {
        private BD bd = new BD();
        public string idVenta;
        public Detalle_Ventas()
        {
            InitializeComponent();
        }

        private void Detalle_Ventas_Load(object sender, EventArgs e)
        {
            ConsultarVentas();
        }
        public void ConsultarVentas()
        {
            bd.AbrirConexion();
            this.dgv_ventas.DataSource = bd.GetVentas();
            bd.CerrarConexion();
        }

        private void dgv_ventas_Click(object sender, EventArgs e)
        {
            btn_eliminar.Visible = true;
            idVenta = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[0].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Seguro que desea eliminar todas las referencias a esta venta", "Mensaje", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                bd.AbrirConexion();
                bd.deleteVentas(idVenta);
                bd.CerrarConexion();
                ConsultarVentas();
            }
            
        }

        private void dgv_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_ventas_DoubleClick(object sender, EventArgs e)
        {
            Productos_Venta medicamento = new Productos_Venta();
            medicamento.idVenta = this.idVenta;
            medicamento.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
