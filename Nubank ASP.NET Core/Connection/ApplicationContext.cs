using Microsoft.EntityFrameworkCore;
using NubankCore.Models;

namespace NubankCore.Connection
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Responsavel> Responsavel { get; set; }
        public DbSet<Lancamento> Lancamento { get; set; }
        public DbSet<Responsavel> Fatura { get; set; }
    }
}
