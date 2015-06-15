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
        String query = string.Format("SELECT titulo, autor, existencias FROM LIBRO");
        SqlConnection c = new SqlConnection("Data Source = ITZMARWIN7-PC; Initial Catalog = HardBooks; Integrated Security = True");
        c.Open();
        SqlCommand sqlc= new SqlCommand(query, c);
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlc);
        SqlCommandBuilder sqlcb = new SqlCommandBuilder(sqlda);
        DataSet ds = new DataSet();
        sqlda.Fill(ds, "LIBRO");
        DataTable tabla = ds.Tables["LIBRO"];
        c.Close();
        return ds;
    }
}
