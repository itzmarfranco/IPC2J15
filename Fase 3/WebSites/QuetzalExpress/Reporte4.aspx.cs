using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reporte4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*R_QE.WS_QE servicio = new R_QE.WS_QE();
        gv1.DataSource = servicio.reporte4();
        gv1.DataBind();*/
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/reportes.aspx");
    }
}