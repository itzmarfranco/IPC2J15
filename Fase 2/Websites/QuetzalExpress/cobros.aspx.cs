using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cobros : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        gvcobros.DataSource = servicio.llenarCobros();
        gvcobros.DataBind();
        ta.Visible = false;
    }
    protected void gvcobros_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int index = Convert.ToInt32(e.CommandArgument);       
        int id = Convert.ToInt32(gvcobros.Rows[index].Cells[2].Text);
        if (e.CommandName == "modificar")
        {
            lblid.Text = gvcobros.Rows[index].Cells[2].Text;
            txtnombre.Text = gvcobros.Rows[index].Cells[3].Text;
            txtvalor.Text = gvcobros.Rows[index].Cells[4].Text;
            ta.Visible = true;
            //Boolean exito = servicio.facturar(casilla, emp.getId(), paquete, servicio.calcularMonto(paquete));
            //Response.Redirect("/entregar_paquete.aspx");            
        }
        if (e.CommandName == "inhabilitar")
        {
            Boolean exito = servicio.inhabilitarCobro(id);
            if (exito)
            {
                lblerror.Text = "Cobro inhabilitado";
            }
            else
            {
                lblerror.Text = "ERROR";
            }
        }
    }
    protected void btncancelar_Click(object sender, EventArgs e)
    {
        ta.Visible = false;
    }
    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int id = Convert.ToInt32(lblid.Text);
        String nombre = txtnombre.Text;
        String v = txtvalor.Text;
        if (nombre != "" && v != "")
        {
            Double valor = Convert.ToDouble(v);
            Boolean exito = servicio.actualizarCobro(nombre, valor, id);
            if (exito)
            {
                lblerror.Text = "Cobro actualizado";
                Response.Redirect("/cobros.aspx");
            }
            else
            {
                lblerror.Text = "No se actualizó";
            }
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_admin.aspx");
    }
}