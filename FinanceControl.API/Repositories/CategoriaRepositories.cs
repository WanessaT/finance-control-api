using FinanceControl.API.Data;
using FinanceControl.API.Entities;

namespace FinanceControl.API.Repositories
{
    public class CategoriaRepositories(DataContext context) : ICategoriaRepositories
    {
        public IQueryable<Categoria> get => context.Set<Categoria>();
        public IQueryable<Categoria> getList => context.Set<Categoria>();
    }

    public interface ICategoriaRepositories
    {
    }
}
