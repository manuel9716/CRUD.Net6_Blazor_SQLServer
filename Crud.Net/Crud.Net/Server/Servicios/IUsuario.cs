using Crud.Net.Shared;

namespace Crud.Net.Server.Servicios
{
    public interface IUsuario
    {
        public List<Usuario> DatosUsuarios();
        public void NuevoUsuario(Usuario u);
        public void ActualizarUsuario(Usuario u);
        public Usuario DatosUsuario(int id);
        public void BorrarUsuario(int id);

    }
}