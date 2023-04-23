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
    public partial class Medicamentos_compra : Form
    {
        private BD bd = new BD();
        public string idCompra;
        public Medicamentos_compra()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Medicamentos_compra_Load(object sender, EventArgs e)
        {
            llenarGridDetalle();
        }
        private void llenarGridDetalle()
        {
            bd.AbrirConexion();
            this.dgv_productos.DataSource = bd.getProductosCompra(idCompra);
            bd.CerrarConexion();
        }

    }
}
