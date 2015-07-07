using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ver_departamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        empleado emp = (empleado)Session["empleado"];
        gvdepartamento.DataSource = servicio.cargarDepartamento(emp.getDepto());
        gvdepartamento.DataBind();
        ta.Visible = false;
    }
    protected void gvdepartamento_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int index = Convert.ToInt32(e.CommandArgument);
        int id = Convert.ToInt32(gvdepartamento.Rows[index].Cells[3].Text);
        if (e.CommandName =="ver")
        {
            his.Visible = true;
            gvhistorial.DataSource = servicio.historialEmpleado(id);
            gvhistorial.DataBind();
        }
        if (e.CommandName == "despedir")
        {
            his.Visible = false;
            Boolean exito = servicio.despedirEmpleado(id);
            if (exito)
            {
                lblerror.Text = "Empleado despedido";
                Response.Redirect("/ver_departamento.aspx");
            }
        }
        if (e.CommandName == "modificar")
        {
            his.Visible = false;
            lblid.Text = gvdepartamento.Rows[index].Cells[3].Text;
            txtsueldo.Text = gvdepartamento.Rows[index].Cells[6].Text;
            txtdepartamento.Text = gvdepartamento.Rows[index].Cells[7].Text;
            ta.Visible = true;
        }
            
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_director.aspx");
    }
    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        int id = Convert.ToInt32(lblid.Text);
        String s = txtsueldo.Text;
        String dep = txtdepartamento.Text;
        if (s != "" && dep != "")
        {
            Double sue = Convert.ToDouble(s);
            Boolean exito = servicio.actualizarEmpleado(id, sue, dep);
            if (exito)
            {
                lblerror.Text = "Empleado modificado";
                ta.Visible = false;
                Response.Redirect("/ver_departamento.aspx");
            }
            else
            {
                lblerror.Text = "No se pudo modificar";
            }
        }
    }
    protected void btncancelar_Click(object sender, EventArgs e)
    {
        ta.Visible = false;
    }
}