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
    public partial class Productos_Venta : Form
    {
        private BD bd = new BD();
        public string idVenta;
        public Productos_Venta()
        {
            InitializeComponent();
        }

        private void Productos_Venta_Load(object sender, EventArgs e)
        {
            llenarGridDetalle();
        }

        private void llenarGridDetalle()
        {
            bd.AbrirConexion();
            this.dgv_productos.DataSource = bd.getProductosVenta(idVenta);
            bd.CerrarConexion();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
