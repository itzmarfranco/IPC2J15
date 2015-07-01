using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class buscar_cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_servicio.aspx");
    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        String dato = txtdato.Text;
        if (dato != "")
        {
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            gvinformacion.DataSource = servicio.llenarInfoCliente(dato);
            gvinformacion.DataBind();
        }
        else
        {
            lblerror.Text = "Ingrese algo para buscar";
        }
    }
}