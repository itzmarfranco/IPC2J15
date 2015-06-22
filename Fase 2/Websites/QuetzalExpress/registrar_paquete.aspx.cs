﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registrar_paquete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        R_QE.WS_QE servicio = new R_QE.WS_QE();
        ddlcategorias.DataSource = servicio.cargarCategorias();
        ddlcategorias.DataTextField = "nombre";
        ddlcategorias.DataValueField = "valor";
        ddlcategorias.DataBind();
    }
    protected void btnregistrar_Click(object sender, EventArgs e)
    {
        String pe = txtpeso.Text;
        String pr = txtprecio.Text;
        String cat = ddlcategorias.SelectedItem.ToString();
        String ca = txtcasilla.Text;

        Double peso;
        Double precio;
        String categoria;
        int casilla;

        if (pe != "" && pr != "" && ca != "" && cat != "")
        {
            peso = Convert.ToDouble(pe);
            precio = Convert.ToDouble(pr);
            categoria = cat;
            casilla = Convert.ToInt32(ca);            
            R_QE.WS_QE servicio = new R_QE.WS_QE();
            if (servicio.clienteExiste(casilla))
            {
                Boolean exito = servicio.registrarPaquete(peso, precio, categoria, casilla);
                if (exito)
                {
                    lblerror.Text = "Paquete registrado";
                }
                else
                {
                    lblerror.Text = "No se pudo registrar el paquete";
                }           
            }
            else
            {
                lblerror.Text = "No existe el cliente con esa casilla";
            }
        }
        else
        {
            lblerror.Text = "Falta llenar campos";
        }
    }
}