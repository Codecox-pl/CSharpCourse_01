using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppStore.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        { 
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Producto>()
                .HasMany(p => p.CategoriaRelationList)
                .WithMany(c => c.ProductoRelationList)
                .UsingEntity<CategoriaProducto>(
                    cp => cp.HasOne(p => p.Categoria)
                            .WithMany(p => p.ProductoCategoriaRelationList)
                            .HasForeignKey(p => p.CategoriaId),
                    cp => cp.HasOne(p => p.Producto)
                            .WithMany(p => p.ProductoCategoriaRelationList)
                            .HasForeignKey(p => p.ProductoId),
                    cp =>
                    {
                        cp.HasKey(t => new { t.ProductoId, t.CategoriaId });
                    }

                  );
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<CategoriaProducto> CategoriaProductos { get; set; }
    }
}
