using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_de_paquetes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        ddlpaquetes.DataSource = servicio.cargarPaquetes();
        ddlpaquetes.DataTextField = "id";
        ddlpaquetes.DataValueField = "id";
        ddlpaquetes.DataBind();
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_registro.aspx");
    }
    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        String paq = ddlpaquetes.SelectedValue.ToString();
        String est = ddlestados.SelectedValue.ToString();
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        if (paq != "" && est != "")
        {
            int paquete = Convert.ToInt32(paq);
            Boolean exito = servicio.actualizarEstado(paquete, est);
            if (exito)
            {
                lblerror.Text = "Estado actualizado";
            }
            else
            {
                lblerror.Text = "No se pudo actualizar";
            }
        }
        else
        {
            lblerror.Text = "Seleccione los valores";
        }
    }
}