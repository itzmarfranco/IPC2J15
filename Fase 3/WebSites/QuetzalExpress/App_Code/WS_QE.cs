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
        String query = string.Format("INSERT INTO SOLICITUD VALUES ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}', 'pendiente')", nom, ape, nit, tel, dom, suc, tar, cor, con);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean registrarCliente(int cas, int sol, String nom, String ape, String nit, int tel, String dom, String suc, String tar, String cor, String con)
    {
        Boolean exito;
        String query = string.Format("INSERT INTO CLIENTE VALUES ({0}, {1}, '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}', '{10}'; UPDATE SOLICITUD SET estado = 'aprobada' WHERE id = {11})", cas, sol,  nom, ape, nit, tel, dom, suc, tar, cor, con, cas);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean registrarEmpleado(String nom, String ape, int tel, String dom, Double sue, String suc, String dep, String cor, String con)
    {
        Boolean exito;
        String query = string.Format("INSERT INTO EMPLEADO VALUES ('{0}', '{1}', {2}, '{3}', {4}, '{5}', '{6}', '{7}', '{8}', 'empleado')", nom, ape, tel, dom, sue, suc, dep, cor, con);
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
    public Boolean registrarPaquete(double pes, double pre, String cat, int cas, String est)
    {
        Boolean exito = false;
        String query1 = string.Format("INSERT INTO PAQUETE VALUES ({0}, {1}, '{2}', {3}, NULL, '{4}')", pes, pre, cat, cas, est);
        Boolean exito1 = conexion.ejecutar2(query1);
        String query2 = string.Format("INSERT INTO ESTADO VALUES ((SELECT MAX(id) FROM PAQUETE), (SELECT GETDATE()), 'Recibido')");
        Boolean exito2 = conexion.ejecutar2(query2);
        if (exito1 && exito2)
        {
            exito = true;
        }
        return exito;
    }
    [WebMethod]
    public DataSet cargarSolicitudes()
    {
        conexion c = new conexion();
        String query = string.Format("SELECT * FROM SOLICITUD WHERE estado = 'pendiente'");
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public Boolean registrarEstado(int paq, String est)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO ESTADO VALUES ({0}, (SELECT GETDATE()), '{2}')", paq, est);
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
    public DataSet cargarPaquetesBodega()
    {
        conexion c = new conexion();
        SqlCommand sqlcmd = new SqlCommand("SELECT imagen FROM PAQUETE", c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet cargarDepartamento(String dep)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT emp.id AS 'ID', emp.nombre AS 'Nombre', emp.apellido AS 'Apellido', (SELECT sueldo FROM ASIGNACION_DEPARTAMENTO WHERE empleado = emp.id) AS 'Sueldo', (SELECT nombre FROM DEPARTAMENTO WHERE id = (SELECT ad.departamento FROM ASIGNACION_DEPARTAMENTO WHERE empleado = emp.id)) AS 'Departamento' FROM EMPLEADO emp, ASIGNACION_DEPARTAMENTO ad WHERE emp.id = ad.empleado AND (SELECT nombre FROM DEPARTAMENTO WHERE id =  ad.departamento) = '{0}' AND tipo = 'empleado'", dep);
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }    
    [WebMethod]
    public DataSet cargarPaquetesCliente(int casilla)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT PAQUETE.id AS 'ID', PAQUETE.estado AS 'Estado de precio' FROM PAQUETE WHERE casilla = {0}", casilla);
        SqlCommand cmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet cargarPaqueteCliente(int paq)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT ESTADO.nombre, PAQUETE.precio, PAQUETE.peso, (SELECT IMPUESTO.nombre FROM IMPUESTO WHERE IMPUESTO.id = PAQUETE.categoria) AS 'Categoria' FROM ESTADO, PAQUETE WHERE fecha = (SELECT MAX(ESTADO.fecha) FROM ESTADO WHERE ESTADO.paquete = {0}) AND PAQUETE.id = {0}", paq);
        SqlCommand cmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet cargarEstadoPaquetesCliente(int paquete)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT nombre AS 'Estado', MAX(fecha) AS 'Fecha de modificación' FROM ESTADO WHERE ESTADO.paquete = {0} GROUP BY nombre", paquete);
        SqlCommand cmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public Boolean clienteExiste(int casilla)
    {
        Boolean exito = false;
        String query = string.Format("SELECT * FROM CLIENTE WHERE casilla = {0}", casilla);
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
    [WebMethod]
    public DataSet cargarBodega()
    {
        String query = string.Format("SELECT id AS 'ID', lote as 'Lote', categoria AS 'Categoría', casilla AS 'Casilla', peso AS 'Peso', precio AS 'Precio', estado AS 'Estado' FROM BODEGA");
        conexion c = new conexion();
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public Boolean reportarPerdido(int bod)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE BODEGA SET estado = 'perdido' WHERE id = {0}", bod);
        exito = conexion.ejecutar1(query);
        return exito;
    }
    [WebMethod]
    public Double calcularMonto(int paq)
    {
        Double monto = -1;
        String query1 = string.Format("SELECT peso FROM PAQUETE WHERE id = {0}", paq);
        Double pe = Convert.ToDouble(conexion.ejecutar3(query1));
        String query2 = string.Format("SELECT valor FROM COBRO WHERE nombre = 'Libra'");
        Double cl = Convert.ToDouble(conexion.ejecutar3(query2));
        Double envio = pe*cl;
        String query3 = string.Format("SELECT categoria FROM PRODUCTO WHERE id = {0}", paq);
        String categoria = conexion.ejecutar3(query3);
        String query4 = string.Format("SELECT valor FROM IMPUESTO WHERE nombre = '{0}'", categoria);
        String imp = conexion.ejecutar3(query4);
        Double impuesto = Convert.ToDouble(imp);
        String query5 = string.Format("SELECT precio FROM PAQUETE WHERE id = {0}", paq);
        Double pre = Convert.ToDouble(conexion.ejecutar3(query5));
        Double importacion = pre*impuesto;
        String query6 = string.Format("SELECT valor FROM COBRO WHERE nombre = 'Comision'");
        Double comi = Convert.ToDouble(conexion.ejecutar3(query6));
        Double comision = comi*(envio + importacion);
        monto = envio + importacion + comision;
        return monto;
    }
    [WebMethod]
    public Double cotizar(Double pe, Double pre, Double imp)
    {
        Double monto = -1;        
        String query2 = string.Format("SELECT valor FROM COBRO WHERE nombre = 'Libra'");
        Double cl = Convert.ToDouble(conexion.ejecutar3(query2));
        Double envio = pe * cl;      
        Double importacion = pre * imp;
        String query6 = string.Format("SELECT valor FROM COBRO WHERE nombre = 'Comision'");
        Double comi = Convert.ToDouble(conexion.ejecutar3(query6));
        Double comision = comi * (envio + importacion);
        monto = envio + importacion + comision;
        return monto;
    }
    [WebMethod]
    public DataSet cargarEntrega(int cas)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT lote AS 'Lote', peso as 'Peso', precio AS 'Precio' FROM BODEGA WHERE casilla = {0} AND estado = 'disponible'", cas);
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public int buscarPaquete(Double pre, Double pes, int lot)
    {
        int paquete = -1;
        String query = string.Format("SELECT PAQUETE.id FROM PAQUETE WHERE PAQUETE.id IN (SELECT ASIGNACION_LOTE.paquete FROM ASIGNACION_LOTE WHERE ASIGNACION_LOTE.lote = {0}) AND PAQUETE.peso = {1} AND PAQUETE.precio = {2}", lot, pes, pre);
        paquete = Convert.ToInt32(conexion.ejecutar3(query));
        return paquete;
    }
    [WebMethod]
    public Boolean facturar(int cas, int emp, int paq, Double tot)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO FACTURA VALUES ((SELECT GETDATE()), {0}, {1}, {2}, {3})", cas, emp, paq, tot);
        exito = conexion.ejecutar1(query);
        return exito;
    }
    [WebMethod]
    public DataSet llenarFactura(int factura)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT * FROM FACTURA WHERE id = {0}", factura);
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public int ultimaFactura()
    {
        int paquete = -1;
        String query = string.Format("SELECT MAX(id) FROM FACTURA");
        paquete = Convert.ToInt32(conexion.ejecutar3(query));
        return paquete;
    }
    [WebMethod]
    public Boolean modificarFactura(int paq)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE FACTURA SET total = 0", paq);
        exito = conexion.ejecutar1(query);
        return exito;
    }
    [WebMethod]
    public Boolean devolverPaquete(int paq)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO ESTADO VALUES ({0}, (SELECT GETDATE()), 'Devuelto')", paq);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean paqueteExiste(int paq)
    {
        Boolean exito = false;
        String query = string.Format("SELECT * FROM ESTADO WHERE paquete = {0}", paq);
        exito = conexion.ejecutar1(query);
        return exito;
    }
    [WebMethod]
    public Boolean actualizarPrecio(int paq, Double pre)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE PAQUETE SET precio = {0}, estado = 'pendiente' WHERE id = {1}", pre, paq);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean aprobarPrecio(int paq, Double pre)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE PAQUETE SET precio = {0}, imagen = NULL, estado = 'aprobado' WHERE id = {1}", pre, paq);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean rechazarPrecio(int paq)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE PAQUETE SET precio = 0, estado = 'pendiente' WHERE id = {0}", paq);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean paquetePagado(int paq)
    {
        Boolean exito = false;
        String query = string.Format("SELECT * FROM ESTADO WHERE nombre = 'Entregado' AND paquete = {0}", paq);
        exito = conexion.ejecutar1(query);
        return exito;
    }
    [WebMethod]
    public DataSet llenarInfoCliente(String dato)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT casilla AS 'Casilla', nombre AS 'Nombre', apellido AS 'Apellido', telefono AS 'Teléfono', correo AS 'Correo' FROM CLIENTE WHERE casilla LIKE '%{0}%' OR nombre LIKE '%{0}%' OR apellido LIKE '%{0}%' OR telefono LIKE '%{0}%' OR correo LIKE '%{0}%'", dato);
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public Boolean despedirEmpleado(int id)
    {
        Boolean exito = false;
        String query = string.Format("DELETE FROM EMPLEADO WHERE id = {0}", id);
        exito = conexion.ejecutar1(query);
        return exito;
    }
    [WebMethod]
    public Boolean actualizarEmpleado(int id, Double sue, String suc, String dep)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE EMPLEADO SET sueldo = {0}, sucursal = '{1}', departamento = '{2}' WHERE id = {3}", sue, suc, dep, id);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean actualizarEstado(int paq, String est)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO ESTADO VALUES ({0}, (SELECT GETDATE()), '{1}')", paq, est);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean agregarCobro(String nom, Double val)
    {
        Boolean exito = false;
        String query = string.Format("INSERT INTO COBRO VALUES ('{0}', {1}, 'habilitado')", nom, val);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean actualizarCobro(String nom, Double val, int id)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE COBRO SET nombre = '{0}', valor = {1} WHERE id = {2}", nom, val, id);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public DataSet llenarCobros()
    {
        conexion c = new conexion();
        String query = string.Format("SELECT id AS 'ID', nombre AS 'Nombre', valor AS 'Valor', estado AS 'Estado' FROM COBRO");
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public Boolean inhabilitarCobro(int id)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE COBRO SET estado = 'inhabilitado' WHERE id = {0}", id);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean cargarImpuestoCSV(String pat)
    {
        Boolean exito = false;
        String query = string.Format("BULK INSERT IMPUESTO FROM '{0}' WITH (FIELDTERMINATOR = ',', ROWTERMINATOR = '\n')", pat);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public Boolean guardarImagen(int id, String pat)
    {
        Boolean exito = false;
        String query = string.Format("UPDATE PAQUETE SET imagen = '{0}' WHERE id = {1}", pat, id);
        exito = conexion.ejecutar2(query);
        return exito;
    }
    [WebMethod]
    public DataSet historialEmpleado(int id)
    {
        conexion c = new conexion();
        String query = string.Format("SELECT empleado AS 'Empleado', sueldo AS 'Sueldo', departamento AS 'Departamento', MAX(fecha) AS 'Fecha de modificación' FROM ASIGNACION_DEPARTAMENTO WHERE empleado = {0} GROUP BY empleado, sueldo, departamento", id);
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet reporte1()
    {
        conexion c = new conexion();
        String query = string.Format("SELECT (SELECT imp.nombre FROM IMPUESTO imp WHERE imp.id = paq.categoria) AS 'Categoria', (SELECT COUNT(est.paquete) FROM ESTADO est WHERE est.paquete = paq.id AND est.nombre = 'Recibido') AS 'Paquetes recibidos', (SELECT COUNT(est.paquete) FROM ESTADO est WHERE est.paquete = paq.id AND est.nombre = 'Perdido') AS 'Paquetes perdidos', (SELECT COUNT(est.paquete) FROM ESTADO est WHERE est.paquete = paq.id AND est.nombre = 'Entregado') AS 'Paquetes entregados' FROM PAQUETE paq, IMPUESTO imp WHERE paq.categoria = imp.id");
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
    [WebMethod]
    public DataSet reporte1_2()
    {
        conexion c = new conexion();
        String query = string.Format("SELECT (SELECT valor FROM IMPUESTO WHERE id = paq.categoria)*SUM(paq.precio) AS 'Suma de impuestos', (SELECT valor FROM COBRO WHERE nombre = 'Libra')*SUM(paq.peso) AS 'Suma de pesos' FROM PAQUETE paq GROUP BY paq.categoria");
        SqlCommand sqlcmd = new SqlCommand(query, c.obtenerConexion());
        c.abrir();
        SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
        DataSet ds = new DataSet();
        sqlda.Fill(ds);
        c.cerrar();
        return ds;
    }
}
