using FinanceControl.API.Data;
using FinanceControl.API.Entities;

namespace FinanceControl.API.Repositories
{
    public class TransacaoRepositories(DataContext context) : ITransacaoRepositories
    {
        public IQueryable<Transacao> get => context.Set<Transacao>();
        public IQueryable<Transacao> getList => context.Set<Transacao>();
    }

    public interface ITransacaoRepositories
    {
    }
}
