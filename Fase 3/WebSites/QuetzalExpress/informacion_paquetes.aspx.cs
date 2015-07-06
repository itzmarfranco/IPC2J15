using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class informacion_paquetes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        cliente cli = (cliente)Session["cliente"];
        gvpaquetes.DataSource = servicio.cargarPaquetesCliente(cli.getCasilla());
        gvpaquetes.DataBind();
        lbl.Text = cli.getNombre();
        fu.Visible = false;
    }
    protected void gvpaquetes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int index = Convert.ToInt32(e.CommandArgument);
        int id = Convert.ToInt32(gvpaquetes.Rows[index].Cells[3].Text);
        if (e.CommandName == "ver")
        {
            lbl.Text = id.ToString();
            gvpaquete.DataSource = servicio.cargarPaqueteCliente(id);
            gvpaquete.DataBind();
            gvpaquete.DataBind();
            /*calcular monto*/
            lblmonto.Text = servicio.calcularMonto(id).ToString();            
        }
        if (e.CommandName == "verindividual")
        {
            lbl.Text = id.ToString();
            gvpaquete.DataSource = null;
            gvpaquete.DataBind();
            gvpaquete.DataSource = servicio.cargarEstadoPaquetesCliente(id);
            gvpaquete.DataBind();
            /*calcular monto*/
            lblmonto.Text = servicio.calcularMonto(id).ToString();
            //Response.Redirect("/informacion_paquetes_individual.aspx");
        }
        if (e.CommandName == "agregarfactura")
        {
            lblid.Text = id.ToString();
            fu.Visible = true;
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_cliente.aspx");
    }
    protected void btnguardar_Click(object sender, EventArgs e)
    {
        if (fuimagen.HasFile)
        {
            fuimagen.SaveAs(Server.MapPath("~/imagen/") + fuimagen.FileName);
            Response.Write("Agregado");
        }
        else
        {
            Response.Write("No Agregado");
        }

        String path = fuimagen.FileName;
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        try
        {
            Boolean exito = servicio.guardarImagen(Convert.ToInt32(lblid.Text), path);
            if (exito)
            {
                lblerror.Text = "Imagen guardada";
            }
            else
            {
                lblerror.Text = "No se guardo";
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}