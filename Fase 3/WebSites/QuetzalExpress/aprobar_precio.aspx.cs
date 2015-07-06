using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class aprobar_precio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void gvpaquetes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int index = Convert.ToInt32(e.CommandArgument);
        int id = Convert.ToInt32(gvpaquetes.Rows[index].Cells[0].Text);
        Double precio = Convert.ToDouble(gvpaquetes.Rows[index].Cells[2].Text);
        if (e.CommandName == "aprobar")
        {
            Boolean exito = servicio.aprobarPrecio(id, precio);
        }
        if (e.CommandName == "rechazar")
        {
            Boolean exito = servicio.rechazarPrecio(id);
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_director.aspx");
    }
}