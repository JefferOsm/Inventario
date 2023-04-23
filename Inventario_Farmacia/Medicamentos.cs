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
    public partial class Medicamentos : Form
    {
        private BD bd = new BD();
        private string idLab;
        private string idTipo;
        public Medicamentos()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tipo_Click(object sender, EventArgs e)
        {
            Med_Tipos tipos = new Med_Tipos();
            tipos.ShowDialog();
            txt_tipo.Text = tipos.nomTipos;
            idTipo = tipos.idTipos;
        }

        private void btn_laboratorio_Click(object sender, EventArgs e)
        {
            Med_Lab lab = new Med_Lab();
            lab.ShowDialog();
            txt_laboratorio.Text = lab.nomLab;
            idLab = lab.idLab;
    
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = txt_fechaVencimiento.Value;
            string fechaFormat = fecha.ToString("yyyy-MM-dd");
            bd.AbrirConexion();
            bd.InsertarMedicamentos(idTipo,idLab,txt_nombre.Text,txt_contenido.Text,txt_cantidad.Text,
                                    fechaFormat,txt_precioCompra.Text,txt_precioVenta.Text,txt_sanitario.Text);
            bd.CerrarConexion();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un dígito numérico o una tecla especial
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter presionado
            }
        }

        private void txt_precioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un dígito numérico, un separador decimal o una tecla especial
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Ignorar el carácter presionado
            }

            // Verificar si se ingresa más de un separador decimal
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Ignorar el carácter presionado
            }
        }

        private void txt_precioVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_precioVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
