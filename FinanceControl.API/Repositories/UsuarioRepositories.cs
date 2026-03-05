using FinanceControl.API.Data;
using FinanceControl.API.Entities;

namespace FinanceControl.API.Repositories
{
    public class UsuarioRepositories(DataContext context) : IUsuarioRepositories
    {
       protected IQueryable<Usuario> get => context.Set<Usuario>();
       protected IQueryable<Usuario> getList => context.Set<Usuario>();
    }

    public interface IUsuarioRepositories
    {
       
    }
}
