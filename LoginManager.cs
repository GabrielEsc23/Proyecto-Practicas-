public class LoginManager
{
    private List<Usuario> usuarios;
    public LoginManager()
    {
        usuarios = new List<Usuario>();
        usuarios.Add(new Usuario("admin", "1234"));
        usuarios.Add(new Usuario("usuario1", "contrasena")); 


    }
}