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
    public partial class Proveedores : Form
    {
        private BD bd = new BD();
        private string idPais;
        private string idCiudad;
        private string idProv;
        public Proveedores()
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

        private void Proveedores_Load(object sender, EventArgs e)
        {
            consultarProveedores();
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }

        public void consultarProveedores()
        {
            bd.AbrirConexion();
            this.dgv_proveedores.DataSource = bd.GetProveedor();
            bd.CerrarConexion();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.InsertarProveedores(this.txt_nombre.Text, idPais, idCiudad, this.txt_direccion.Text,this.txt_correo.Text,this.txt_telefono.Text);
            bd.CerrarConexion();
            this.consultarProveedores();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.UpdateProveedores(txt_nombre.Text, idPais, idCiudad, txt_direccion.Text, txt_correo.Text, txt_telefono.Text, idProv);
            bd.CerrarConexion();
            consultarProveedores();
            this.btn_guardar.Visible = true;
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }

        private void dgv_proveedores_Click(object sender, EventArgs e)
        {
            idProv = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[0].Value);
            string nombre = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[1].Value);
            string pais = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[2].Value);
            string ciudad = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[3].Value);
            string direccion = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[4].Value);
            string email = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[5].Value);
            string telefono = Convert.ToString(this.dgv_proveedores.SelectedRows[0].Cells[6].Value);

            this.txt_nombre.Text = nombre;
            this.txt_pais.Text = pais;
            this.txt_ciudad.Text = ciudad;
            this.txt_direccion.Text = direccion;
            this.txt_correo.Text = email;
            this.txt_telefono.Text = telefono;

            this.btn_actualizar.Visible = true;
            this.btn_eliminar.Visible = true;
            this.btn_guardar.Visible = false;

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.DeleteProveedor(idProv);
            bd.CerrarConexion();
            consultarProveedores();
            this.btn_guardar.Visible = true;
            this.btn_actualizar.Visible = false;
            this.btn_eliminar.Visible = false;
        }
    }
}
