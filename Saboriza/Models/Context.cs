using Microsoft.EntityFrameworkCore;

namespace Saboriza.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }

    }
}
