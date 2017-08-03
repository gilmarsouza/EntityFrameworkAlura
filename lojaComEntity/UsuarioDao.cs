using System.Linq;
using lojaComEntity.Entidades;

namespace lojaComEntity
{
    public class UsuarioDao
    {
        private EntidadesContext contexto;

        public UsuarioDao()
        {
            contexto = new EntidadesContext();
        }
        public void SaveChages()
        {
            contexto.SaveChanges();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }
    }
}
