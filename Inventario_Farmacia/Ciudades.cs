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
    public partial class Ciudades : Form
    {
        private BD bd = new BD();
        public string idCiudad;
        public string nomCiudad;
        public Ciudades()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ciudades_Load(object sender, EventArgs e)
        {
            consultarCiudad();
        }

        public void consultarCiudad()
        {
            bd.AbrirConexion();
            this.dgv_ciudad.DataSource = bd.getCiudad();
            bd.CerrarConexion();
        }

        private void dgv_ciudad_Click(object sender, EventArgs e)
        {
            idCiudad = this.dgv_ciudad.SelectedRows[0].Cells[0].Value.ToString();
            nomCiudad = this.dgv_ciudad.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
