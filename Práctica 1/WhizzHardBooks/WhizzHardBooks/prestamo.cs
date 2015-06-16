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
    public partial class prestamo : Form
    {
        public prestamo()
        {
            InitializeComponent();
        }

        private void prestamo_Load(object sender, EventArgs e)
        {
            R_WHB.WS_WHB servicio = new R_WHB.WS_WHB();
            dgvlibros.ReadOnly = true;
            dgvlibros.DataSource = servicio.llenarPrestarLibro().Tables[0];
        }

        private void dgvlibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            R_WHB.WS_WHB servicio = new R_WHB.WS_WHB();
            int car = -1;            
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                try
                {
                    car = Convert.ToInt32(txtcarne.Text);
                }
                catch (Exception ex)
                {
                    lblerror.Text = "El carné es inválido";
                }
                if (e.ColumnIndex == 1) // reserva
                {
                    if (servicio.clienteExiste(car))
                    {
                        int lib = Convert.ToInt32(dgvlibros.Rows[e.RowIndex].Cells[2].Value);
                        if (servicio.ejempleresDisponibles(lib) <= 0)
                        {
                            if (servicio.yaReservoElLibro(car, lib))
                            {
                                lblerror.Text = "Ya reservó una vez este ejemplar";
                            }
                            else
                            {
                                Boolean exito = servicio.guardarReserva(car, lib);
                                if (exito)
                                {
                                    lblerror.Text = "Reserva realizada";
                                }
                                else
                                {
                                    lblerror.Text = "No se pudo reservar";
                                }
                            }
                        }
                        else
                        {
                            lblerror.Text = "Hay libros para prestar. No se puede reservar";
                        }
                    }
                }
                else if (e.ColumnIndex == 0) // préstamo
                {
                    if (servicio.clienteExiste(car))
                    {
                        int lib = Convert.ToInt32(dgvlibros.Rows[e.RowIndex].Cells[2].Value);
                        if (servicio.librosPrestadosSinDevolver(car) < 5)
                        {
                            if (servicio.yaPrestoElLibro(car, lib) == false)
                            {
                                if (servicio.ejempleresDisponibles(lib) > 0)
                                {
                                    //prestar libro
                                    Boolean exito = servicio.guardarPrestamo(car, lib);
                                    if (exito)
                                    {
                                        lblerror.Text = "Préstamo guardado";
                                    }
                                }
                                else
                                {
                                    lblerror.Text = "Ya no hay libros disponibles. Puede reservar este ejemplar";
                                }
                            }
                            else
                            {
                                // ya presto este libro
                                lblerror.Text = "Ya prestó este libro";
                            }
                        }
                        else
                        {
                            //no prestar
                            lblerror.Text = "Tiene más de 5 libros sin devolver";
                        }
                    }
                    else
                    {
                        //no existe cliente
                        lblerror.Text = "No se ha registrado como cliente";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
