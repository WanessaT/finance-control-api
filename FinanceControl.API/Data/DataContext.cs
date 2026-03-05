using FinanceControl.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Usuario> usuarios { get; set; }
    public DbSet<Categoria> categorias { get; set; }
    public DbSet<Transacao> transacoes { get; set; }
}