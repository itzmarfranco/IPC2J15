using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class conexion
{
    SqlConnection c;

    public conexion()
    {
        c = new SqlConnection("Data Source = ITZMARWIN7-PC; Initial Catalog = HardBooks; Integrated Security = True");
    }

    public conexion(String usuario, String contraseña)
    {
        c = new SqlConnection(string.Format("Data Source = ITZMARWIN7-PC; Initial Catalog = TAMAKO2; User ID = {0}; Password = {1}", usuario, contraseña));
    }

    public SqlConnection obtenerConexion()
    {
        try
        {
            return c;
        }
        catch
        {
            return null;
        }
    }

    public void abrir()
    {
        try
        {
            c.Open();
        }
        catch { }
    }
    public void cerrar()
    {
        try
        {
            c.Close();
        }
        catch { }
    }

    public static bool ejecutar1(String query)
    {
        /* método usado para verificar existencia de registros */
        bool exito = false;
        conexion c = new conexion();
        try
        {
            SqlCommand command = new SqlCommand(query, c.obtenerConexion());
            c.abrir();
            Object o = command.ExecuteScalar();
            if (o == null) // el comando no se ejecutó
            {
                exito = false;
            }
            else
            {
                exito = true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("El error es " + e.Message);
        }
        c.cerrar();
        return exito;
    }
    public static bool ejecutar2(String query)
    {
        /* método usado para la inserción de registros */
        conexion c = new conexion();
        bool exito = false;
        try
        {
            SqlCommand command = new SqlCommand(query, c.obtenerConexion());
            c.abrir();
            int rows = command.ExecuteNonQuery();
            if (rows <= 0) // el comando no se ejecutó
            {
                exito = false;
            }
            else
            {
                exito = true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("El error es " + e.Message);
            throw;
        }
        c.cerrar();
        return exito;
    }
    public static String ejecutar3(String query)
    {
        /* método usado para el retorno de registros */
        conexion c = new conexion();
        String resultado = null;
        try
        {
            SqlCommand comando = new SqlCommand(query, c.obtenerConexion());
            c.abrir();
            resultado = comando.ExecuteScalar().ToString();
            if (resultado == null) // el comando no se ejecutó
            {
                resultado = "No se encontró coincidencia";
            }
            else
            {
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("El error es " + e.Message);
        }
        c.cerrar();
        return resultado;
    }
   
    public static bool clienteExiste(String usuario, String contra)
    {
        String query = string.Format("SELECT * FROM CLIENTE WHERE usuario = '{0}' AND contraseña = '{1}'", usuario, contra);
        bool existe = ejecutar1(query);
        return existe;
    }
    public static String obtenerCampo(String campo, String tabla, String usuario)
    {
        String valor = "";
        String query = string.Format("SELECT {0} FROM {1} WHERE usuario = '{2}'", campo, tabla, usuario);
        valor = conexion.ejecutar3(query);
        return valor;
    }
}