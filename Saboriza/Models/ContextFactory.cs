using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Saboriza.Models
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var connectionString = Environment.GetEnvironmentVariable("SABORIZA_DB_CONNECTION");

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Variável de ambiente 'SABORIZA_DB_CONNECTION' não encontrada.");

            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseNpgsql(connectionString);

            Console.WriteLine($"SABORIZA_DB_CONNECTION: {connectionString}");

            return new Context(optionsBuilder.Options);
        }
    }
}
