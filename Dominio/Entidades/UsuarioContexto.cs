using Dominio.Entidades;

public class UsuarioContexto
{
    private Usuario _usuarioLogado;

    public void DefinirUsuario(Usuario usuario)
    {
        _usuarioLogado = usuario;
    }

    public Usuario ObterUsuario()
    {
        return _usuarioLogado;
    }
}

