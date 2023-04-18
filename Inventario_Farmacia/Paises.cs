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
    public partial class Paises : Form
    {
        private BD bd = new BD();
        public string idPais;
        public string nomPais;
        public Paises()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Paises_Load(object sender, EventArgs e)
        {
            consultarPais();
        }

        public void consultarPais()
        {
            bd.AbrirConexion();
            this.dgv_pais.DataSource = bd.getPais();
            bd.CerrarConexion();
        }

        private void dgv_pais_Click(object sender, EventArgs e)
        {
            idPais = this.dgv_pais.SelectedRows[0].Cells[0].Value.ToString();
            nomPais = this.dgv_pais.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
