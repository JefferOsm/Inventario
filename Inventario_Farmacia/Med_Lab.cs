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
    public partial class Med_Lab : Form
    {
        private BD bd = new BD();
        public string idLab;
        public string nomLab;
        public Med_Lab()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Med_Lab_Load(object sender, EventArgs e)
        {
            ConsultarLaboratorio();
        }
        public void ConsultarLaboratorio()
        {
            bd.AbrirConexion();
            this.dgv_laboratorio.DataSource = bd.getLaboratorio();
            bd.CerrarConexion();
        }

        private void dgv_laboratorio_Click(object sender, EventArgs e)
        {
            idLab = this.dgv_laboratorio.SelectedRows[0].Cells[0].Value.ToString();
            nomLab = this.dgv_laboratorio.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
