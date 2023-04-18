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
    public partial class Tipos_medicamento : Form
    {
        private BD bd = new BD();
        private string idTipo;
        public Tipos_medicamento()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_tipoMedicamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tipos_medicamento_Load(object sender, EventArgs e)
        {
            ConsultarTipos();
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }
        public void ConsultarTipos()
        {
            bd.AbrirConexion();
            this.dgv_tipoMedicamento.DataSource = bd.getTipos();
            bd.CerrarConexion();
        }

        private void dgv_tipoMedicamento_Click(object sender, EventArgs e)
        {
            idTipo = Convert.ToString(this.dgv_tipoMedicamento.SelectedRows[0].Cells[0].Value);
            string nombre = Convert.ToString(this.dgv_tipoMedicamento.SelectedRows[0].Cells[1].Value);

            txt_nombre.Text = nombre;
            this.btn_actualizar.Visible = true;
            this.btn_eliminar.Visible = true;
            this.btn_guardar.Visible = false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.insertarTipo(txt_nombre.Text);
            bd.CerrarConexion();
            ConsultarTipos();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.UpdateTipo(txt_nombre.Text, idTipo);
            bd.CerrarConexion();
            ConsultarTipos();
            this.btn_guardar.Visible = true;
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.deleteTipo(idTipo);
            bd.CerrarConexion();
            ConsultarTipos();
            this.btn_guardar.Visible = true;
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }
    }
}
