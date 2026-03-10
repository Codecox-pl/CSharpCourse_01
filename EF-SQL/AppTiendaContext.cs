using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SQL
{
    public class AppTiendaContext : DbContext
    {
        private const string connectionString = @"Server=localhost;Database=TiendaWeb;Trusted_Connection=True;TrustServerCertificate=True;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Tienda> Tienda { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
