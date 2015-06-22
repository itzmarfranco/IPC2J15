using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class reportar_perdido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        gvbodega.DataSource = servicio.cargarBodega();
        gvbodega.DataBind();
    }
    protected void gvbodega_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        int id = Convert.ToInt32(gvbodega.Rows[index].Cells[1].Text);
        if (e.CommandName == "perdido")
        {
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            servicio.reportarPerdido(id);
            Response.Redirect("/reportar_perdido.aspx");
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_bodega.aspx");
    }
}