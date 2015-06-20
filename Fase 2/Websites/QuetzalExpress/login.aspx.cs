using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnentrar_Click(object sender, EventArgs e)
    {
        String correo = txtusuario.Text;
        String contra = txtcontraseña.Text;
        if (correo == null || correo == "" || contra == null || contra == "")
        {
            lblerror.Text = "Campos vacíos";
        }
        else
        {
            lblerror.Text = "";
            if (conexion.clienteExiste(correo, contra))
            {      
                int casilla = Convert.ToInt32(conexion.obtenerCampoCliente("casilla", correo));
                String nombre = conexion.obtenerCampoCliente("nombre", correo);
                String apellido = conexion.obtenerCampoCliente("apellido", correo);
                String nit = conexion.obtenerCampoCliente("nit", correo);
                int telefono = Convert.ToInt32(conexion.obtenerCampoCliente("telefono", correo));
                String domicilio = conexion.obtenerCampoCliente("domicilio", correo);
                String sucursal = conexion.obtenerCampoCliente("sucursal", correo);
                String tarjeta = conexion.obtenerCampoCliente("tarjeta", correo);
                String cor = conexion.obtenerCampoCliente("correo", correo);
                String contraseña = conexion.obtenerCampoCliente("contraseña", correo);
                Session["cliente"] = new cliente(casilla, nombre, apellido, nit, telefono, domicilio, sucursal, tarjeta, cor, contraseña);
                Response.Redirect("/principal_cliente.aspx");
            }
            else if (conexion.empleadoExiste(correo, contra))
            {
                if (conexion.obtenerCampoEmpleado("departamento", correo) == "Registro" && conexion.obtenerCampoEmpleado("tipo", correo) == "empleado")
                {
                    Response.Redirect("/principal_registro.aspx");
                }
                if (conexion.obtenerCampoEmpleado("departamento", correo) == "Servicio al Cliente" && conexion.obtenerCampoEmpleado("tipo", correo) == "empleado")
                {
                    Response.Redirect("/principal_servicio.aspx");
                }
                if (conexion.obtenerCampoEmpleado("departamento", correo) == "Bodega" && conexion.obtenerCampoEmpleado("tipo", correo) == "empleado")
                {
                    Response.Redirect("/principal_bodega.aspx");
                }
                if (conexion.obtenerCampoEmpleado("tipo", correo) == "Director")
                {
                    Response.Redirect("/principal_director.aspx");
                }
                if (conexion.obtenerCampoEmpleado("tipo", correo) == "Administrador")
                {
                    Response.Redirect("/principal_admin.aspx");
                }
                int id = Convert.ToInt32(conexion.obtenerCampoEmpleado("id", correo));                
                String nombre = conexion.obtenerCampoEmpleado("nombre", correo);
                String apellido = conexion.obtenerCampoEmpleado("apellido", correo);
                double sueldo = Convert.ToDouble(conexion.obtenerCampoEmpleado("apellido", correo));
                String sucursal = conexion.obtenerCampoEmpleado("sucursal", correo);
                String departamento = conexion.obtenerCampoEmpleado("departamento", correo);
                String tipo = conexion.obtenerCampoEmpleado("tipo", correo);
                Session["empleado"] = new empleado(id, departamento, nombre, apellido, sueldo, sucursal, correo, contra, tipo);
            }
            else
            {
                lblerror.Text = "No existe el usuario";
            }
        }
    }
    protected void btnvolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("/principal.aspx");
    }
}