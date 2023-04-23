
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
    public partial class Login : Form
    {
        BD db = new BD();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            //db.VerificarUsuario(txt_usuario.Text, txt_contra.Text);
            //if (db.conecto)
            //{
               
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
           
        }
    }
}
