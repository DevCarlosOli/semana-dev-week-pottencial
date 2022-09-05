using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persistence;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options)
    {
        
    }

    public DbSet<Person> Pessoas { get; set; }
    public DbSet<Contract> Contrato { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Person>( p => {
            p.HasKey(e => e.Id);
            p.HasMany(e => e.Contratos)
            .WithOne()
            .HasForeignKey(c => c.PessoaId);
        });
        builder.Entity<Contract>( c => {
            c.HasKey(e => e.Id);
        });
    }
}