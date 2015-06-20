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
    public Boolean registrarSolicitud(String nom, String ape, String nit, int tel, String dom, String suc, String tar, String cor, String con)
    {
        Boolean exito;
        String query = string.Format("INSERT INTO SOLICITUD VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}')", nom, ape, nit, tel, dom, suc, tar, cor, con);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean actualizarCliente(String nom, String ape, String nit, int tel, String dom, String suc, String tar, String con, String cas)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE CLIENTE SET nombre = '{0}', apellido = '{1}', nit = '{2}', telefono = {3}, domicilio = '{4}', sucursal = '{5}', tarjeta = '{6}', contraseña = '{7}' WHERE casilla = {8}", nom, ape, nit, tel, dom, suc, tar, con, cas);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean registrarPaquete(double pes, double pre, String cat, int cas)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO PAQUETE VALUES ({0}, {1}, '{2}', {3})", pes, pre, cat, cas);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean agregarLote(int paq, int lot)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO ASIGNACION_LOTE VALUES ({0}, {1})", lot, paq);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean crearLote(int num)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO LOTE VALUES ({0})", num);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public DataSet cargarCategorias()
    {
        conexion c = new conexion();
        SqlCommand sqlcmd = new SqlCommand("SELECT * FROM IMPUESTO", c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet cargarLotes()
    {
        conexion c = new conexion();
        SqlCommand sqlcmd = new SqlCommand("SELECT * FROM LOTE", c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet cargarPaquetes()
    {
        conexion c = new conexion();
        SqlCommand sqlcmd = new SqlCommand("SELECT * FROM PAQUETE", c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public Boolean clienteExiste(int casilla)
    {
        Boolean exito = false;
        String query = string.Format("SELECT * FROM CLIENTE WHERE casilla = {0})", casilla);
        exito = conexion.ejecutar1(query);
        return exito;
    }
    [WebMethod]
    public Boolean paqueteEstaEnLote(int paq)
    {
        Boolean exito = false;
        String query = string.Format("SELECT * FROM PAQUETE WHERE PAQUETE.id IN (SELECT ASIGNACION_LOTE.paquete FROM ASIGNACION_LOTE WHERE paquete = {0})", paq);
        exito = conexion.ejecutar1(query);
        return exito;
    }
}
