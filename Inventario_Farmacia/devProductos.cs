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
    public partial class devProductos : Form
    {
        private BD bd = new BD();
        public string idVenta;
        public string idMed;
        public string nombre;
        public string stock;
        public string cantidad;
        public string total;
        public string precio;
        public devProductos()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llenarGridDetalle()
        {
            bd.AbrirConexion();
            this.dgv_ventas.DataSource = bd.getProductosVenta(idVenta);
            bd.CerrarConexion();
        }

        private void devProductos_Load(object sender, EventArgs e)
        {
            llenarGridDetalle();
        }

        private void dgv_ventas_Click(object sender, EventArgs e)
        {
            idMed = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[0].Value);
            nombre = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[1].Value);
            stock = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[5].Value);
            precio = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[4].Value);
            cantidad = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[6].Value);
            total = Convert.ToString(this.dgv_ventas.SelectedRows[0].Cells[7].Value);
        }
    }
}
