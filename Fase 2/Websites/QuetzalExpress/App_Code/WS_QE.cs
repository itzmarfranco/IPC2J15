using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Descripción breve de WS_QE
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WS_QE : System.Web.Services.WebService {

    public WS_QE () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }
    [WebMethod]
    public Boolean registrarCliente(String nom, String ape, String nit, int tel, String dom, String suc, String tar, String cor, String con)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO CLIENTE VALUES (-7, '{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}')", nom, ape, nit, tel, dom, suc, tar, cor, con);
        conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean actualizarCliente(String nom, String ape, String nit, int tel, String dom, String suc, String tar, String con, String cas)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE CLIENTE SET nombre = '{0}', apellido = '{1}', nit = '{2}', telefono = {3}, domicilio = '{4}', sucursal = '{5}', tarjeta = '{6}', contraseña = '{7}' WHERE casilla = {8}", nom, ape, nit, tel, dom, suc, tar, con, cas);
        conexion.ejecutar2(query);
        return exito;
    }
}
