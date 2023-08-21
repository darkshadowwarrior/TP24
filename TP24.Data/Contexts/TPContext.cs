using Microsoft.EntityFrameworkCore;
using TP24.Data.Entities;

namespace TP24.Data.Contexts;

public class TpContext : DbContext
{
    public TpContext(DbContextOptions<TpContext> options) :base(options)
    {

    }

    public DbSet<Payload> Payloads { get; set; }
    public DbSet<PayloadStatistics> Statistics { get; set; }
    
    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
    }
}