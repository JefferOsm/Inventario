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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_medicamento_Click(object sender, EventArgs e)
        {
            list_medicamentos medicamentos = new list_medicamentos();
            medicamentos.ShowDialog();
        }

        private void btn_metodoPago_Click(object sender, EventArgs e)
        {
            Formas_Pago pago = new Formas_Pago();
            pago.ShowDialog();
        }

        private void btn_descuento_Click(object sender, EventArgs e)
        {
            Fac_descuentos descuento = new Fac_descuentos();
            descuento.ShowDialog();
        }
    }
}
