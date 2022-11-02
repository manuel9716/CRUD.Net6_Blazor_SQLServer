using Crud.Net.Server.Modelos;
using Crud.Net.Shared;
using System.Data;

namespace Crud.Net.Server.Servicios
{
    public class GestionUsuarios : IUsuario
    {
        readonly NetCore6Context dbContext = new();
        public GestionUsuarios(NetCore6Context db)
        {
            dbContext = db;
        }
        public void ActualizarUsuario(Usuario u)
        {
            throw new NotImplementedException();
        }

        public void BorrarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario DatosUsuario(int id)
        {
            try
            {
                Usuario? u = dbContext.Usuarios.Find(id);
                if ( u != null)
                {
                    return u;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Usuario Datosusuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> DatosUsuarios()
        {
            try
            {
                return dbContext.Usuarios.ToList(); 
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void NuevoUsuario(Usuario u)
        {
            try
            {
                u.FechaAlta = DateTime.Now;
                dbContext.Usuarios.Add(u);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
