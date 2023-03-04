using Microsoft.EntityFrameworkCore;
using mvc_entity.Models;

namespace mvc_entity.Servicos
{
  public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options)
     {
        Database.EnsureCreated();
     }

    public DbSet<Cliente> Clientes { get; set; }
  }
}