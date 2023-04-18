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
    public partial class Laboratorios : Form
    {
        private BD bd = new BD();
        private string idPais;
        private string idCiudad;
        private string idLab;
        public Laboratorios()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pais_Click(object sender, EventArgs e)
        {
            Paises pais = new Paises();
            pais.ShowDialog();
            this.txt_pais.Text = pais.nomPais;
            idPais = pais.idPais;
        }

        private void btn_ciudad_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            ciudad.ShowDialog();
            this.txt_ciudad.Text = ciudad.nomCiudad;
            idCiudad = ciudad.idCiudad;
        }

        private void Laboratorios_Load(object sender, EventArgs e)
        {
            ConsultarLaboratorio();
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }
        public void ConsultarLaboratorio()
        {
            bd.AbrirConexion();
            this.dgv_laboratorios.DataSource = bd.getLaboratorio();
            bd.CerrarConexion();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.InsertarLaboratorio(txt_nombre.Text, idPais, idCiudad, txt_direccion.Text, txt_telefono.Text);
            bd.CerrarConexion();
            ConsultarLaboratorio();
        }

        private void dgv_laboratorios_Click(object sender, EventArgs e)
        {
            idLab = Convert.ToString(this.dgv_laboratorios.SelectedRows[0].Cells[0].Value);
            string nombre = Convert.ToString(this.dgv_laboratorios.SelectedRows[0].Cells[1].Value);
            string pais = Convert.ToString(this.dgv_laboratorios.SelectedRows[0].Cells[2].Value);
            string ciudad = Convert.ToString(this.dgv_laboratorios.SelectedRows[0].Cells[3].Value);
            string direccion = Convert.ToString(this.dgv_laboratorios.SelectedRows[0].Cells[4].Value);
            string telefono = Convert.ToString(this.dgv_laboratorios.SelectedRows[0].Cells[5].Value);

            this.txt_nombre.Text = nombre;
            this.txt_pais.Text = pais;
            this.txt_ciudad.Text = ciudad;
            this.txt_direccion.Text = direccion;
            this.txt_telefono.Text = telefono;

            this.btn_actualizar.Visible = true;
            this.btn_eliminar.Visible = true;
            this.btn_guardar.Visible = false;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.updateLaboratorio(txt_nombre.Text, idPais, idCiudad, txt_direccion.Text,txt_telefono.Text, idLab);
            bd.CerrarConexion();
            ConsultarLaboratorio();
            this.btn_guardar.Visible = true;
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.deleteLaboratorio(idLab);
            bd.CerrarConexion();
            ConsultarLaboratorio();
            this.btn_guardar.Visible = true;
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }

        private void dgv_laboratorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
