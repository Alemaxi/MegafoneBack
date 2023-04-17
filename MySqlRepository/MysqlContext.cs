using Domain.core.Entity;
using Microsoft.EntityFrameworkCore;

namespace MySqlRepository
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<MegaFone> MegaFones { get; set;}
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mensagem> Mensagems { get; set; }
        public DbSet<ReceptorXMegaFone> ReceptoresXMegaFones { get; set; }
    }
}
