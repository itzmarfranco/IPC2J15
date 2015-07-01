using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class cliente
{
    int casilla;
    String nombre;
    String apellido;
    String nit;
    int telefono;
    String domicilio;
    String sucursal;
    String tarjeta;
    String correo;
    String contraseña;

    public cliente()
    {
        setCasilla(-1);
        setNombre(null);
        setApellido(null);
        setNit(null);
        setTel(-1);
        setDom(null);
        setSucursal(null);
        setTarjeta(null);
        setCorreo(null);
        setContraseña(null);
    }
    public cliente(int cas, String nom, String ape, String nit, int tel, String dom, String suc, String tar, String cor, String con)
    {
        setCasilla(cas);
        setNombre(nom);
        setApellido(ape);
        setNit(nit);
        setTel(tel);
        setDom(dom);
        setSucursal(suc);
        setTarjeta(tar);
        setCorreo(cor);
        setContraseña(con);       
    }

    public void setCasilla(int cas)
    {
        this.casilla = cas;
    }
    public void setNombre(String nombre)
    {
        this.nombre = nombre;
    }
    public void setApellido(String apellido)
    {
        this.apellido = apellido;
    }
    public void setNit(String nit)
    {
        this.nit = nit;
    }
    public void setTel(int tel)
    {
        this.telefono = tel;
    }
    public void setDom(String domicilio)
    {
        this.domicilio = domicilio;
    }
    public void setSucursal(String sucursal)
    {
        this.sucursal = sucursal;
    }
    public void setTarjeta(String tarjeta)
    {
        this.tarjeta = tarjeta;
    }
    public void setCorreo(String correo)
    {
        this.correo = correo;
    }
    public void setContraseña(String contra)
    {
        this.contraseña = contra;
    }
    public int getCasilla()
    {
        return this.casilla;
    }
    public String getNombre()
    {
        return this.nombre;
    }
    public String getApellido()
    {
        return this.apellido;
    }
    public String getNit()
    {
        return this.nit;
    }
    public int getTel()
    {
        return this.telefono;
    }
    public String getDomicilio()
    {
        return this.domicilio;
    }
    public String getSucursal()
    {
        return this.sucursal;
    }
    public String getTarjeta()
    {
        return this.tarjeta;
    }
    public String getCorreo()
    {
        return this.correo;
    }
    public String getContraseña()
    {
        return this.contraseña;
    }
}