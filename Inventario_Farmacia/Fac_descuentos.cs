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
    public partial class Fac_descuentos : Form
    {
        private BD bd = new BD();
        public string idDescuento;
        private int terceraEdad;
        private int general;
        public decimal total;
        public Fac_descuentos()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_descuento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fac_descuentos_Load(object sender, EventArgs e)
        {
            ConsultarDescuentos();
        }

        public void ConsultarDescuentos()
        {
            bd.AbrirConexion();
            this.dgv_descuentos.DataSource = bd.GetDescuentos();
            bd.CerrarConexion();
        }

        private void dgv_descuentos_Click(object sender, EventArgs e)
        {
            idDescuento = Convert.ToString(this.dgv_descuentos.SelectedRows[0].Cells[0].Value);
            string terceraEdad = Convert.ToString(this.dgv_descuentos.SelectedRows[0].Cells[1].Value);
            string general = Convert.ToString(this.dgv_descuentos.SelectedRows[0].Cells[2].Value);

            total = Convert.ToDecimal(terceraEdad) + Convert.ToDecimal(general);
        }
    }
}
