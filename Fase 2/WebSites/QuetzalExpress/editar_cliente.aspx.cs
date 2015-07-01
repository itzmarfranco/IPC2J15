using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class editar_cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cliente cli = (cliente)Session["cliente"];
        lblcasilla.Text = cli.getCasilla().ToString();
        txtnombre.Text = cli.getNombre();
        txtapellido.Text = cli.getApellido();
        txtnit.Text = cli.getNit();
        txttel.Text = cli.getTel().ToString();
        txtdomicilio.Text = cli.getDomicilio();
        txttarjeta.Text = cli.getTarjeta();
        txtcontra.Text = cli.getContraseña();
        
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_cliente.aspx");
    }
    protected void btnactualizar_Click(object sender, EventArgs e)
    {
        String cas = lblcasilla.Text;
        String nom = txtnombre.Text;
        String ape = txtapellido.Text;
        String nit = txtnit.Text;
        int tel = Convert.ToInt32(txtnit.Text);
        String dom = txtdomicilio.Text;
        String suc = ddlsucursales.SelectedValue.ToString();
        String tar = txttarjeta.Text;
        String con = txtcontra.Text;
        String co2 = txtconfirmar.Text;
        /* Información necesaria para modificar la cuenta*/
        if (nom != "" && ape != "" && tar != "" && con != "" && co2 != "")
        {
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            Boolean exito = servicio.actualizarCliente(nom, ape, nit, tel, dom, suc, tar, con, cas);
            if (exito)
            {
                cliente cli = (cliente)Session["cliente"];
                Session["cliente"] = new cliente(Convert.ToInt32(cas), nom, ape, nit, tel, dom, suc, tar, cli.getCorreo(), con);
                lblerror.Text = "Datos actualizados";                
                Response.Redirect("/principal_cliente.aspx");
            }
            else
            {
                lblerror.Text = "No se pudo actualizar la información";
            }
        }
        else
        {
            lblerror.Text = "Falta información obligatoria";
        }
    }
}