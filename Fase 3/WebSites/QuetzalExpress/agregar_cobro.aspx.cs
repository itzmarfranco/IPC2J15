using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class agregar_cobro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("principal_admin.aspx");
    }
    protected void btnguardar_Click(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        String nombre = txtnombre.Text;
        String v = txtvalor.Text;
        if (nombre != "" && v != "")
        {
            Double valor = Convert.ToDouble(v);
            Boolean exito = servicio.agregarCobro(nombre, valor);
            if (exito)
            {
                lblerror.Text = "Cobro agregado";
            }
            else
            {
                lblerror.Text = "No se agregó";
            }
        }
    }
    protected void btncargar_Click(object sender, EventArgs e)
    {
        if (fuimp.HasFile)
        {
            fuimp.SaveAs(Server.MapPath("~/csv/") + fuimp.FileName);
            Response.Write("Agregado");
        }
        else
        {
            Response.Write("No Agregado");
        }

        String path = Server.MapPath("\\csv\\" + fuimp.FileName);
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        try
        {
            Boolean exito = servicio.cargarImpuestoCSV(path);
            if (exito)
            {
                lblerror2.Text = /*"Carga exitosa"*/path;
            }
            else
            {
                lblerror2.Text = "No se pudo cargar";
            }
        }
        catch (Exception)
        {
            throw;
        } 
    }
}