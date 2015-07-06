using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class agregar_precio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tbleditar.Visible = false;
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_bodega.aspx");
    }
    protected void gvimagen_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        int id = Convert.ToInt32(gvimagen.Rows[index].Cells[0].Text);
        if (e.CommandName == "editar")
        {
            tbleditar.Visible = true;
            lblid.Text = id.ToString();
        }
    }
    protected void btncancelar_Click(object sender, EventArgs e)
    {
        tbleditar.Visible = false;
    }
    protected void btnguardar_Click(object sender, EventArgs e)
    {
        if (txtprecio.Text != "")
        {
            Double precio = Convert.ToDouble(txtprecio.Text);
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            Boolean exito = servicio.actualizarPrecio(Convert.ToInt32(lblid.Text), precio);
            if (exito)
            {
                lblerror2.Text = "Precio agregado";
            }
            else
            {
                lblerror2.Text = "No se agrego";
            }
        }
        else
        {
            lblerror.Text = "Ingrese el precio de la imagen";
        }
    }
}