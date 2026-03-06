using FinanceControl.API.Data;
using FinanceControl.API.Entities;

namespace FinanceControl.API.Repositories
{
    public class UsuarioRepositories : IUsuarioRepositories
    {
        private readonly DataContext _context;

        public UsuarioRepositories(DataContext context)
        {
            _context = context;
        }

        protected IQueryable<Usuario> get => _context.Set<Usuario>();

        public IQueryable<Usuario> GetById(int id)
        {
            return get.Where(u => u.id == id);
        }

        public IQueryable<Usuario> GetByEmail(string email)
        {
            return get.Where(u => u.email == email);
        }

        public void InsertUsuario(Usuario entity)
        {
            _context.usuarios.Add(entity);
        }

        public void UpdateUsuario(Usuario entity)
        {
            _context.usuarios.Update(entity);
        }

    }

    public interface IUsuarioRepositories
    {
        public IQueryable<Usuario> GetById(int id);
        public IQueryable<Usuario> GetByEmail(string email);
        public void InsertUsuario(Usuario entity);
        public void UpdateUsuario(Usuario entity);
    }
}
