using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cotizacion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        if (!Page.IsPostBack)
        {
            ddlcategorias.DataSource = servicio.cargarCategorias();
            ddlcategorias.DataTextField = "nombre";
            ddlcategorias.DataValueField = "valor";
            ddlcategorias.DataBind();
        }        
    }
    protected void btncalcular_Click(object sender, EventArgs e)
    {
        String pes = txtpeso.Text;
        String pre = txtprecio.Text;
        String cat = ddlcategorias.SelectedValue.ToString();
        if (pes != "" && pre != "" && cat != "")
        {
            Double peso = Convert.ToDouble(pes);
            Double precio = Convert.ToDouble(pre);
            Double impuesto = Convert.ToDouble(cat);
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            lblcosto.Text = servicio.cotizar(peso, precio, impuesto).ToString();
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_cliente.aspx");
    }
}