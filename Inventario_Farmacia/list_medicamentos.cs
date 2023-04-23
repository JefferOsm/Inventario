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
    public partial class list_medicamentos : Form
    {
        private BD bd = new BD();
        public string idMedicamento;
        public string tipoMed;
        public string concentracion;
        public string nombre;
        public string cantidad;
        public string precio;
        public string costo;

        public list_medicamentos()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_medicamentos_Load(object sender, EventArgs e)
        {
            ConsultarMedicamentos();
        }
        public void ConsultarMedicamentos()
        {
            bd.AbrirConexion();
            this.dgv_medicamentos.DataSource = bd.getMedicamentos();
            bd.CerrarConexion();
        }

        private void dgv_medicamentos_Click(object sender, EventArgs e)
        {
            idMedicamento = this.dgv_medicamentos.SelectedRows[0].Cells[0].Value.ToString();
            nombre = this.dgv_medicamentos.SelectedRows[0].Cells[1].Value.ToString();
            tipoMed = this.dgv_medicamentos.SelectedRows[0].Cells[2].Value.ToString();
            concentracion = this.dgv_medicamentos.SelectedRows[0].Cells[4].Value.ToString();
            cantidad = this.dgv_medicamentos.SelectedRows[0].Cells[5].Value.ToString();
            precio = this.dgv_medicamentos.SelectedRows[0].Cells[8].Value.ToString();
            costo = this.dgv_medicamentos.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
