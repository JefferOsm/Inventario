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
    public partial class verDevoluciones : Form
    {
        private BD bd = new BD();
        public string idDevolucion;
        public verDevoluciones()
        {
            InitializeComponent();
        }

        private void verDevoluciones_Load(object sender, EventArgs e)
        {
            ConsultarDevoluciones();
        }
        public void ConsultarDevoluciones()
        {
            bd.AbrirConexion();
            this.dgv_devoluciones.DataSource = bd.GetDevoluciones();
            bd.CerrarConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
