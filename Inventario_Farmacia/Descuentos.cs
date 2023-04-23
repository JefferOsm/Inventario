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
    public partial class Descuentos : Form
    {
        private BD bd = new BD();
        private string idDescuento;
        public Descuentos()
        {
            InitializeComponent();
        }

        private void Descuentos_Load(object sender, EventArgs e)
        {
            ConsultarDescuentos();
            this.btn_eliminar.Visible = false;
        }
        public void ConsultarDescuentos()
        {
            bd.AbrirConexion();
            this.dgv_descuentos.DataSource = bd.GetDescuentos();
            bd.CerrarConexion();
        }

        private void dgv_descuentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.insertarDescuento(txt_terceraEdad.Text, txt_General.Text);
            bd.CerrarConexion();
            ConsultarDescuentos();
        }

        private void dgv_descuentos_Click(object sender, EventArgs e)
        {
            idDescuento = Convert.ToString(this.dgv_descuentos.SelectedRows[0].Cells[0].Value);
            string terceraEdad = Convert.ToString(this.dgv_descuentos.SelectedRows[0].Cells[1].Value);
            string general = Convert.ToString(this.dgv_descuentos.SelectedRows[0].Cells[2].Value);

            txt_terceraEdad.Text = terceraEdad;
            txt_General.Text = general;


            this.btn_eliminar.Visible = true;
            this.btn_guardar.Visible = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.deleteDescuentos(idDescuento);
            bd.CerrarConexion();
            ConsultarDescuentos();
            this.btn_guardar.Visible = true;
            this.btn_eliminar.Visible = false;
        }

        private void txt_terceraEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_General_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
