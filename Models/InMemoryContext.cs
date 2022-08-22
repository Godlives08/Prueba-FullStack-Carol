using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Prueba_FullStack_Carol.Models
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options)
        { 
        }

        public DbSet<Producto> Productos { get; set; } = null!;
    }
}
