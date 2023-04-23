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
    public partial class Detalle_Compras : Form
    {
        private BD bd = new BD();
        public string idCompra;
        public Detalle_Compras()
        {
            InitializeComponent();
        }

        private void Detalle_Compras_Load(object sender, EventArgs e)
        {
            ConsultarCompras();
        }
        public void ConsultarCompras()
        {
            bd.AbrirConexion();
            this.dgv_Compras.DataSource = bd.GetCompras();
            bd.CerrarConexion();
        }

        private void dgv_Compras_Click(object sender, EventArgs e)
        {
            idCompra = Convert.ToString(this.dgv_Compras.SelectedRows[0].Cells[0].Value);
        }
    }
}
