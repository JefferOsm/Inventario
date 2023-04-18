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
    public partial class Inventario : Form
    {
        private BD bd = new BD();
        public string idMedicamento;
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ConsultarMedicamentos();
        }

        public void ConsultarMedicamentos()
        {
            bd.AbrirConexion();
            this.dgv_medicamentos.DataSource = bd.getMedicamentos();
            bd.CerrarConexion();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.deleteMedicamento(idMedicamento);
            bd.CerrarConexion();
            ConsultarMedicamentos();
        }

        private void dgv_medicamentos_Click(object sender, EventArgs e)
        {
            idMedicamento = Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[0].Value);
        }
    }
}
