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
    public partial class updateMedicamento : Form
    {

        private BD bd = new BD();
        public string idMED;
        public updateMedicamento()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = txt_fechaVencimiento.Value;
            string fechaFormat = fecha.ToString("yyyy-MM-dd");

            bd.AbrirConexion();
            bd.UpdateMedicamento(txt_nombre.Text,txt_contenido.Text,txt_cantidad.Text,fechaFormat,txt_precioCompra.Text,txt_precioVenta.Text,txt_sanitario.Text,idMED);
            bd.CerrarConexion();

            this.Close();


        }
    }
}
