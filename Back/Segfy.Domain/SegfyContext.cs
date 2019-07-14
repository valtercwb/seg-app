using Microsoft.EntityFrameworkCore;
using Segfy.Domain.Entities;

namespace Segfy.Domain
{
    public class SegfyContext : DbContext
    {
        public SegfyContext(DbContextOptions<SegfyContext> options) : base(options) { }

        public DbSet<ApoliceAutomovel> ApoliceAutomovel { get; set; }
        public DbSet<Segurado> Segurado { get; set; }
        public DbSet<Automovel> Automovel { get; set; }
    }
}
