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
    public partial class Fac_Proveedores : Form
    {
        private BD bd = new BD();
        public string nombre;
        public string idProv;
        public Fac_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fac_Proveedores_Load(object sender, EventArgs e)
        {
            consultarProveedores();
        }

        public void consultarProveedores()
        {
            bd.AbrirConexion();
            this.dgv_proveedores.DataSource = bd.GetProveedor();
            bd.CerrarConexion();
        }

        private void dgv_proveedores_Click(object sender, EventArgs e)
        {
            idProv = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[0].Value);
            nombre= Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[1].Value);
        }
    }
}
