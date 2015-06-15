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
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }

        private void consultar_Load(object sender, EventArgs e)
        {
            R_WHB.WS_WHB servicio = new R_WHB.WS_WHB();
            dgvlibros.DataSource = servicio.llenarConsultarLibros().Tables["LIBRO"];
        }
    }
}
