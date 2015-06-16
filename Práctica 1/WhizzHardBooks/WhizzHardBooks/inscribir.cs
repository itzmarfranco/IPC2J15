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
    public partial class inscribir : Form
    {
        public inscribir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R_WHB.WS_WHB servicio = new R_WHB.WS_WHB();
            int id = Convert.ToInt32(txtid.Text);
            String tit = txttitulo.Text;
            int exi = Convert.ToInt32(txtexistencias.Text);
            int pag = Convert.ToInt32(txtpaginas.Text);
            String tem = txttema.Text;
            String aut = txtautor.Text;
            Boolean exito = servicio.inscribirLibro(id, tit, exi, pag, tem, aut);
            if (exito)
            {
                lblerror.Text = "Libro registrado";
                txtid.Text = "";
                txttitulo.Text = "";
                txtexistencias.Text = "";
                txtpaginas.Text = "";
                txttema.Text = "";
                txtautor.Text = "";
            }
            else
            {
                lblerror.Text = "Error en el registro";
            }
        }
    }
}
