using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class empleado
{
    //APELLIDOS,NOMBRES,SUELDO,SUCURSAL,DEPARTAMENTO
    int id;    
    String nombre;
    String apellido;
    double sueldo;
    String departamento;
    String correo;
    String contraseña;
    String tipo;

	public empleado()
	{
        setId(-1);
        setNombre(null);
        setApellido(null);
        setSueldo(-1);
        setDepto(null);
        setCorreo(null);
        setContraseña(null);
        setTipo(null);
	}
    public empleado(int id, String depto, String nombre, String apellido, double sueldo, String correo, String contraseña, String tipo)
    {
        setId(id);        
        setNombre(nombre);
        setApellido(apellido);
        setSueldo(sueldo);
        setDepto(depto);
        setCorreo(correo);
        setContraseña(contraseña);
        setTipo(tipo);
    }

    public void setId(int id)
    {
        this.id = id;
    }    
    public void setNombre(String nombre)
    {
        this.nombre = nombre;
    }
    public void setApellido(String apellido)
    {
        this.apellido = apellido;
    }
    public void setSueldo(double sueldo)
    {
        this.sueldo = sueldo;
    }    
    public void setDepto(String depto)
    {
        this.departamento = depto;
    }
    public void setCorreo(String correo)
    {
        this.correo = correo;
    }    
    public void setContraseña(String contra)
    {
        this.contraseña = contra;
    }
    public void setTipo(String tipo)
    {
        this.tipo = tipo;
    }
    public int getId()
    {
        return this.id;
    }        
    public String getNombre()
    {
        return this.nombre;
    }
    public String getApellido()
    {
        return this.apellido;
    }
    public double getSueldo()
    {
        return this.sueldo;
    }
    public String getDepto()
    {
        return this.departamento;
    }
    public String getCorreo()
    {
        return this.correo;
    }    
    public String getContraseña()
    {
        return this.contraseña;
    }
    public String getTipo()
    {
        return this.tipo;
    }
}