using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhizzHardBooks
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            R_WHB.WS_WHB servicio = new R_WHB.WS_WHB();
            int car = Convert.ToInt32(txtcarne.Text);
            String nom = txtnombre.Text;
            int dpi = Convert.ToInt32(txtdpi.Text);
            String dir = txtdireccion.Text;
            int tel = Convert.ToInt32(txttelefono.Text);
            Boolean exito = servicio.registrarCliente(car, nom, dpi, dir, tel);
            if (exito)
            {
                lblerror.Text = "Cliente registrado";
                txtcarne.Text = "";
                txtnombre.Text = "";
                txtdpi.Text = "";
                txtdireccion.Text = "";
                txttelefono.Text = "";
            }
            else
            {
                lblerror.Text = "Error en el registro";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
