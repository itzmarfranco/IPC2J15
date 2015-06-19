using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registro_clientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnregistrar_Click(object sender, EventArgs e)
    {
        String nom = txtnombre.Text;
        String ape = txtapellido.Text;
        String nit = txtnit.Text;
        int tel = Convert.ToInt32(txttel.Text);
        String dom = txtdomicilio.Text;
        String suc = ddlsucursales.SelectedValue.ToString();
        String tar = txttarjeta.Text;
        String cor = txtcorreo.Text;
        String con = txtcontra.Text;
        String co2 = txtconfirmar.Text;
        /* Información necesaria para crear la cuenta
         La demás la podrá ingresar luego*/
        if (nom != "" && ape != "" && tar != "" && cor != "" && con != "" && co2 != "") 
        {
            /*Las contraseñas son iguales*/
            if (con == co2)
            {
                R_QE.WS_QE servicio = new R_QE.WS_QE();
                Boolean exito = servicio.registrarCliente(nom, ape, nit, tel, dom, suc, tar, cor, con);
                if (exito)
                {
                    lblerror.Text = "Espere a la aprobación de un empleado";
                    txtnombre.Text = "";
                    txtapellido.Text = "";
                    txtnit.Text = "";
                    txtdomicilio.Text = "";                    
                    txttarjeta.Text = "";
                    txtcorreo.Text = "";
                    txtcontra.Text = "";
                    txtconfirmar.Text = "";
                }
            }
            else
            {
                lblerror.Text = "Las contraseñas no coinciden";
            }
        }
        else
        {
            lblerror.Text = "Hay campos obligatorios en blanco";
        }

    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal.aspx");
    }
}