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
            btn_eliminar.Visible = true;
            idCompra = Convert.ToString(this.dgv_Compras.SelectedRows[0].Cells[0].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Seguro que desea eliminar todas las referencias a esta compra","Mensaje", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                bd.AbrirConexion();
                bd.deleteCompras(idCompra);
                bd.CerrarConexion();
                ConsultarCompras();
            }
        }

        private void dgv_Compras_DoubleClick(object sender, EventArgs e)
        {
            Medicamentos_compra medicamento = new Medicamentos_compra();
            medicamento.idCompra = this.idCompra;
            medicamento.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
