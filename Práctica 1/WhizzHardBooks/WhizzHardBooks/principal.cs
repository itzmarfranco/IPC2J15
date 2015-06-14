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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void consultaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultar con = new consultar();
            con.Show();
        }

        private void inscrpcionDeLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inscribir ins = new inscribir();
            ins.Show();
        }

        private void préstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestamo pre = new prestamo();
            pre.Show();
        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devolucion dev = new devolucion();
            dev.Show();
        }

        private void registroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro reg = new registro();
            reg.Show();
        }

        private void repotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporte rep = new reporte();
            rep.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
