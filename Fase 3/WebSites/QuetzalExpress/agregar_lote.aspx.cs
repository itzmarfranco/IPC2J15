using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class agregar_lote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        ddllotes.DataSource = servicio.cargarLotes();
        ddllotes.DataTextField = "id";
        ddllotes.DataValueField = "id";
        ddllotes.DataBind();

        ddlpaquetes.DataSource = servicio.cargarPaquetes();
        ddlpaquetes.DataTextField = "id";
        ddlpaquetes.DataValueField = "id";
        ddlpaquetes.DataBind();
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal_registro.aspx");
    }
    protected void btnañadir_Click(object sender, EventArgs e)
    {
        String paq = ddlpaquetes.SelectedValue.ToString();
        String lot = ddllotes.SelectedValue.ToString();
        if (paq != "" && lot != "")
        {
            int paquete = Convert.ToInt32(paq);
            int lote = Convert.ToInt32(lot);
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            if (!servicio.paqueteEstaEnLote(paquete))
            {
                Boolean exito = servicio.agregarLote(paquete, lote);
                if (exito)
                {
                    lblerror.Text = "Paquete añadido al lote";
                }
                else
                {
                    lblerror.Text = "No se pudo añadir al lote";
                }
            }
            else
            {
                lblerror.Text = "El paquete ya está en un lote";
            }
        }
        else
        {
            lblerror.Text = "Seleccione ambos campos";
        }
    }
    protected void btncrear_Click(object sender, EventArgs e)
    {
        String num = txtnlote.Text;
        int numero;
        if (num != "")
        {
            numero = Convert.ToInt32(num);
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            Boolean exito = servicio.crearLote(numero);
            if (exito)
            {
                lblerror2.Text = "Lote creado";
                txtnlote.Text = "";
                Response.Redirect("/agregar_lote.aspx");
            }
            else
            {
                lblerror2.Text = "No se creó el lote";
            }
        }
        else
        {
            lblerror2.Text = "Ingrese un número de lote";
        }
    }
}