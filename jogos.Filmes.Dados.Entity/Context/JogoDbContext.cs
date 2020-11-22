using jogos.Ecommerce.Dominio;
using jogos.Ecommerce.Dados.Entity.TypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Ecommerce.Dados.Entity.Context
{
    public class JogoDbContext : DbContext
    {
        public DbSet<FichaTecnica> ficha{ get; set; }
        public DbSet<Plataforma> plataforma { get; set; }

        public JogoDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FichaTecnicaTypeConfiguration());
            modelBuilder.Configurations.Add(new PlataformaTypeConfiguration());
        }
    }
}
