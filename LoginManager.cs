public class LoginManager
{
    private List<Usuario> usuarios;
    public LoginManager()
    {
        usuarios = new List<Usuario>();
        usuarios.Add(new Usuario("admin", "1234"));
        usuarios.Add(new Usuario("usuario1", "contrasena"));

    }
    public bool ValidarLogin(String nombreUsuario, string contraseña)
    {
        foreach (var usuario in usuarios)
        {
            if (usuario.NombreUsuario == nombreUsuario && usuario.Contrasena == contraseña)
            {
                return true;
            }
        }
        return false;
    }
}