using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class contratar_empleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btncontratar_Click(object sender, EventArgs e)
    {
        empleado emp = (empleado)Session["empleado"];
        String nom = txtnombre.Text;
        String ape = txtapellido.Text;
        String tel = txttel.Text;
        String dom = txtdomicilio.Text;
        String sue = txtsueldo.Text;
        String cor = txtcorreo.Text;
        String con = txtcontra.Text;
        String co2 = txtconfirmar.Text;
        if (nom != "" && ape != "" && tel != "" && dom != "" && sue != "" && cor != "" && con != "" && co2 != "")
        {
            if (con == co2)
            {
                R_QE.WS_QE servicio = new R_QE.WS_QE();
                
                int telefono = Convert.ToInt32(tel);
                Double sueldo = Convert.ToDouble(sue);
                String suc = emp.getSucursal();
                String dep = emp.getDepto();
                Boolean exito = servicio.registrarEmpleado(nom, ape, telefono, dom, sueldo, suc, dep, cor, con);
                if (exito)
                {
                    lblerror.Text = "Empleado registrado";
                }
            }
            else
            {
                lblerror.Text = "Las contraseñas no coinciden";
            }
        }
        else
        {
            lblerror.Text = "Falta información";
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_director.aspx");
    }
}