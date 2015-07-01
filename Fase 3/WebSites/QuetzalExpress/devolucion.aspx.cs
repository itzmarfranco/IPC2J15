using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class devolucion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_servicio.aspx");
    }
    protected void btndevolver_Click(object sender, EventArgs e)
    {
        String p = txtpaquete.Text;
        if (p != "")
        {
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            int paquete = Convert.ToInt32(p);
            if (servicio.paqueteExiste(paquete))
            {
                if (servicio.paquetePagado(paquete))
                {
                    Boolean exito = servicio.devolverPaquete(paquete);
                    if (exito)
                    {
                        lblerror.Text = "Paquete devuelto";
                        servicio.modificarFactura(paquete);
                    }
                    else
                    {
                        lblerror.Text = "No se pudo devolver";
                    }
                }
                else
                {
                    lblerror.Text = "El paquete aún no ha sido pagado";
                }
            }
            else
            {
                lblerror.Text = "El paquete solicitado no existe";
            }
        }
        else
        {
            lblerror.Text = "Ingrese un número de paquete";
        }
    }
}