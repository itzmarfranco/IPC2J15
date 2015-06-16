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
    public partial class devolucion : Form
    {
        public devolucion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int car = -1;
            int lib = -1;
            R_WHB.WS_WHB servicio = new R_WHB.WS_WHB();
            try
            {
                car= Convert.ToInt32(txtcarne.Text);
                lib = Convert.ToInt32(txtlibro.Text);

                if (servicio.yaPrestoElLibro(car, lib))
                {
                    Boolean exito = servicio.devolver(car, lib);
                    if (exito)
                    {
                        lblerror.Text = "Libro devuelto";
                    }
                    else
                    {
                        lblerror.Text = "Problema con la devolución";
                    }
                }
                else
                {
                    lblerror.Text = "No se ha realizado ese préstamo";
                }
            }
            catch (Exception ex)
            {
                lblerror.Text = "Valores inválidos";
            }
        }
    }
}
