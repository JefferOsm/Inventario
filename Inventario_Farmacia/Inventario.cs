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
            DialogResult resp = MessageBox.Show("Seguro que desea eliminar todas las referencias a esta compra", "Mensaje", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                bd.AbrirConexion();
                bd.deleteMedicamento(idMedicamento);
                bd.CerrarConexion();
                ConsultarMedicamentos();
            }
        }

        private void dgv_medicamentos_Click(object sender, EventArgs e)
        {
            btn_eliminar.Visible = true;
            idMedicamento = Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[0].Value);
        }

        private void dgv_medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_medicamentos_DoubleClick(object sender, EventArgs e)
        {
            idMedicamento = Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[0].Value);
            string nombre= Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[1].Value); 
            string contenido= Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[4].Value);
            string cantidad= Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[5].Value);
            DateTime fechaV= Convert.ToDateTime(this.dgv_medicamentos.SelectedRows[0].Cells[6].Value);
            string precioC= Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[7].Value);
            string precioV= Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[8].Value);
            string san = Convert.ToString(this.dgv_medicamentos.SelectedRows[0].Cells[9].Value);

            updateMedicamento form = new updateMedicamento();
            form.idMED = idMedicamento;
            form.txt_nombre.Text = nombre;
            form.txt_cantidad.Text = cantidad;
            form.txt_contenido.Text = contenido;
            form.txt_fechaVencimiento.Value = fechaV;
            form.txt_precioCompra.Text = precioC;
            form.txt_precioVenta.Text = precioV;
            form.txt_sanitario.Text = san;
            form.ShowDialog();
            ConsultarMedicamentos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
