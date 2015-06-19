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
        String usu = txtusuario.Text;
        String contra = txtcontraseña.Text;
        if (usu == null || usu == "" || contra == null || contra == "")
        {
            lblerror.Text = "Campos vacíos";
        }
        else
        {
            lblerror.Text = "";
            if (conexion.clienteExiste(usu, contra))
            {      
                /*int casilla = Convert.ToInt32(conexion.obtenerCampoCliente("casilla", "CLIENTE", usu));
                String nombre = conexion.obtenerCampoCliente("nombre", "CLIENTE", usu);
                String apellido = conexion.obtenerCampoCliente("apellido", "CLIENTE", usu);
                String nit = conexion.obtenerCampoCliente("nit", "CLIENTE", usu);
                int telefono = Convert.ToInt32(conexion.obtenerCampoCliente("telefono", "CLIENTE", usu));
                String domicilio = conexion.obtenerCampoCliente("domicilio", "CLIENTE", usu);
                String sucursal = conexion.obtenerCampoCliente("sucursal", "CLIENTE", usu);
                String tarjeta = conexion.obtenerCampoCliente("tarjeta", "CLIENTE", usu);
                String correo = conexion.obtenerCampoCliente("correo", "CLIENTE", usu);
                String contraseña = conexion.obtenerCampoCliente("contraseña", "CLIENTE", usu);
                Session["cliente"] = new cliente(casilla, nombre, apellido, nit, telefono, domicilio, sucursal, tarjeta, correo, contraseña);
                Response.Redirect("/principal_cliente.aspx");*/
            }
            else if (conexion.empleadoExiste(usu, contra))
            {
                /*int id = Convert.ToInt32(conexion.obtenerCampo("id", "EMPLEADO", usu));
                String departamento = conexion.obtenerCampo("departamento", "EMPLEADO", usu);
                String nombre = conexion.obtenerCampo("nombre", "EMPLEADO", usu);
                String apellido = conexion.obtenerCampo("apellido", "EMPLEADO", usu);
                String correo = conexion.obtenerCampo("correo", "EMPLEADO", usu);
                String usuario = conexion.obtenerCampo("usuario", "EMPLEADO", usu);
                String contraseña = conexion.obtenerCampo("contraseña", "EMPLEADO", usu);
                String rol = conexion.obtenerCampo("rol", "EMPLEADO", usu);
                Session["empleado"] = new empleado(id, departamento, nombre, apellido, correo, usuario, contraseña, rol);
                Response.Redirect("/principal_admin.aspx");*/
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