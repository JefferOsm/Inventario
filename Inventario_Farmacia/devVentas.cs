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
    public partial class devVentas : Form
    {
        private BD bd = new BD();
        public string idVenta;
        public string descuento;
        public string total;
        public string subtotal;
        public devVentas()
        {
            InitializeComponent();
        }

        private void devVentas_Load(object sender, EventArgs e)
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
            subtotal = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[4].Value);
            descuento = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[5].Value);
            total = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[6].Value);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
