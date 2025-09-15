using System;
using System.Collections.Generic;
public class Usuario
{
    public String NombreUsuario { get; set; }
    public String Contrasena { get; set; }

    public Usuario(String nombreUsuario, String contrasena)
    {
        NombreUsuario = nombreUsuario;
        Contrasena = contrasena; 
        


    }
}