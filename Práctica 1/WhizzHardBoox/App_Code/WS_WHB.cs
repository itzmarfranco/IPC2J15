using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Descripción breve de WS_WHB
/// </summary>
[WebService(Namespace = "http://localhost/WS_WHB", Name="WS_WHB")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WS_WHB : System.Web.Services.WebService {

    public WS_WHB () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }

    [WebMethod]
    public Boolean inscribirLibro(int id, String tit, int exi, int pag, String tem, String aut)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO LIBRO VALUES ({0}, '{1}', {2}, {3}, '{4}', '{5}')", id, tit, exi, pag, tem, aut);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean registrarCliente(int car, String nom, int dpi, String dir, int tel)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO CLIENTE VALUES ({0}, '{1}', {2}, '{3}', {4})", car, nom, dpi, dir, tel);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public DataSet llenarConsultarLibros()
    {
        String query = string.Format("SELECT DISTINCT titulo AS 'Título', autor AS 'Autor', existencias AS 'Existencias', existencias-(SELECT COUNT(*) FROM PRESTAMO WHERE PRESTAMO.libro = LIBRO.id AND PRESTAMO.fecha_devolucion IS NULL) AS 'Disponibles', (SELECT COUNT(*) FROM PRESTAMO WHERE PRESTAMO.libro = LIBRO.id AND PRESTAMO.fecha_devolucion IS NULL) AS 'Prestados', (SELECT COUNT(*) FROM RESERVA WHERE RESERVA.libro = LIBRO.id) AS 'Reservados' FROM LIBRO, PRESTAMO, RESERVA WHERE LIBRO.id = PRESTAMO.libro OR LIBRO.id != PRESTAMO.libro");
        conexion c = new conexion();
        SqlDataAdapter sqlda = new SqlDataAdapter(query, c.obtenerConexion());
        c.abrir();
        SqlCommandBuilder sqlcb = new SqlCommandBuilder(sqlda);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet llenarPrestarLibro()
    {
        String query = string.Format("SELECT DISTINCT id AS 'ID', titulo AS 'Título', autor AS 'Autor', existencias AS 'Existencias' FROM LIBRO");
        conexion c = new conexion();
        SqlDataAdapter sqlda = new SqlDataAdapter(query, c.obtenerConexion());
        c.abrir();
        SqlCommandBuilder sqlcb = new SqlCommandBuilder(sqlda);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet llenarReporte()
    {
        String query = string.Format("SELECT (SELECT titulo from LIBRO WHERE id = libro) AS 'Título', COUNT(*) AS 'Veces prestado' FROM PRESTAMO GROUP BY libro ORDER BY 'Veces Prestado' DESC");
        conexion c = new conexion();
        SqlDataAdapter sqlda = new SqlDataAdapter(query, c.obtenerConexion());
        c.abrir();
        SqlCommandBuilder sqlcb = new SqlCommandBuilder(sqlda);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public int librosPrestadosSinDevolver(int carne)
    {
        String query = string.Format("SELECT COUNT(*) FROM PRESTAMO, CLIENTE WHERE CLIENTE.carne = {0} AND PRESTAMO.fecha_devolucion IS NULL", carne);
        int cantidad = Convert.ToInt32(conexion.ejecutar3(query));
        return cantidad;
    }
    [WebMethod]
    public Boolean clienteExiste(int carne)
    {
        Boolean existe = false;
        String query = string.Format("SELECT * FROM CLIENTE WHERE carne = {0}", carne);
        existe = conexion.ejecutar1(query);
        return existe;
    }
    [WebMethod]
    public Boolean yaPrestoElLibro(int car, int lib)
    {
        Boolean ya = true;
        String query = string.Format("SELECT * FROM PRESTAMO WHERE cliente = {0} AND libro = {1} AND  fecha_devolucion IS NULL", car, lib);
        ya = conexion.ejecutar1(query);
        return ya;
    }
    [WebMethod]
    public Boolean yaReservoElLibro(int car, int lib)
    {
        Boolean ya = true;
        String query = string.Format("SELECT * FROM RESERVA WHERE cliente = {0} AND libro = {1}", car, lib);
        ya = conexion.ejecutar1(query);
        return ya;
    }
    [WebMethod]
    public Boolean guardarPrestamo(int car, int lib)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO PRESTAMO VALUES ((SELECT GETDATE()), NULL, {0}, {1})", car, lib);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean guardarReserva(int car, int lib)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO RESERVA VALUES ((SELECT GETDATE()), {0}, {1})", car, lib);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public int ejempleresDisponibles(int lib)
    {
        int disp = -1;
        String query = string.Format("SELECT existencias-(SELECT COUNT(*) FROM PRESTAMO WHERE PRESTAMO.libro = LIBRO.id AND PRESTAMO.fecha_devolucion IS NULL) FROM LIBRO WHERE LIBRO.id = {0}", lib);
        disp = Convert.ToInt32(conexion.ejecutar3(query));
        return disp;
    }
    [WebMethod]
    public Boolean devolver(int car, int lib)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE PRESTAMO SET fecha_devolucion = GETDATE() WHERE cliente = {0} AND libro = {1}", car, lib);
        exito = conexion.ejecutar2(query);
        return exito;
    }
}
