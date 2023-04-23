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
            idVenta = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[0].Value);
        }
    }
}
