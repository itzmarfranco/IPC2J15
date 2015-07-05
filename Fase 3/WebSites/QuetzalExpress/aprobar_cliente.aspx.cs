using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class aprobar_cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        gvsolicitudes.DataSource = servicio.cargarSolicitudes();
        gvsolicitudes.DataBind();
    }
    protected void gvsolicitudes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int index = Convert.ToInt32(e.CommandArgument);
        int id = Convert.ToInt32(gvsolicitudes.Rows[index].Cells[1].Text);
        if (e.CommandName == "aprobar")
        {
            String nombre = gvsolicitudes.Rows[index].Cells[2].Text;
            String apellido = gvsolicitudes.Rows[index].Cells[3].Text;
            String nit = gvsolicitudes.Rows[index].Cells[4].Text;
            int telefono = Convert.ToInt32(gvsolicitudes.Rows[index].Cells[5].Text);
            String domicilio = gvsolicitudes.Rows[index].Cells[6].Text;
            String sucursal = gvsolicitudes.Rows[index].Cells[7].Text;
            String tarjeta = gvsolicitudes.Rows[index].Cells[8].Text;
            String correo = gvsolicitudes.Rows[index].Cells[9].Text;
            String contrasena = gvsolicitudes.Rows[index].Cells[10].Text;
            Boolean exito = servicio.registrarCliente(id, id, nombre, apellido, nit, telefono, domicilio, sucursal, tarjeta, correo, contrasena);
            if (exito)
            {
                lblerror.Text = "Cliente agregado";
            }
            else
            {
                lblerror.Text = "No se agrego al cliente";
            }
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_servicio.aspx");
    }
}