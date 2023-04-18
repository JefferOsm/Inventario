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
    public partial class Med_Tipos : Form
    {
        private BD bd = new BD();
        public string idTipos;
        public string nomTipos;
        public Med_Tipos()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Med_Tipos_Load(object sender, EventArgs e)
        {
            ConsultarTipos();
        }

        public void ConsultarTipos()
        {
            bd.AbrirConexion();
            this.dgv_tipo_medicamento.DataSource = bd.getTipos();
            bd.CerrarConexion();
        }

        private void dgv_tipo_medicamento_Click(object sender, EventArgs e)
        {
            idTipos = this.dgv_tipo_medicamento.SelectedRows[0].Cells[0].Value.ToString();
            nomTipos = this.dgv_tipo_medicamento.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
