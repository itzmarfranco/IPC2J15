using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class entregar_paquete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void gvpaquetes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int index = Convert.ToInt32(e.CommandArgument);
        int precio = Convert.ToInt32(gvpaquetes.Rows[index].Cells[3].Text);
        int peso = Convert.ToInt32(gvpaquetes.Rows[index].Cells[2].Text);
        int lote = Convert.ToInt32(gvpaquetes.Rows[index].Cells[1].Text);
        int casilla = Convert.ToInt32(txtcasilla.Text);
        int paquete = servicio.buscarPaquete(precio, peso, lote);
        if (e.CommandName == "entregar")
        {
            /*agregar a factura*/
            empleado emp = (empleado)Session["empleado"];
            Boolean exito = servicio.facturar(casilla, emp.getId(), paquete, servicio.calcularMonto(paquete));
            Response.Redirect("/entregar_paquete.aspx");
            gvfactura.DataSource = servicio.llenarFactura(servicio.ultimaFactura());
            gvfactura.DataBind();
        }
    }
    protected void btnbuscar_Click(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        String c = txtcasilla.Text;
        if (c != "" || c == null)
	    {
            int casilla = Convert.ToInt32(c);
            gvpaquetes.DataSource = servicio.cargarEntrega(casilla);
            gvpaquetes.DataBind();
            lblerror.Text = "";
	    }
        else
        {
            lblerror.Text = "Ingrese un número de casilla";
        }
        
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_servicio.aspx");
    }
}