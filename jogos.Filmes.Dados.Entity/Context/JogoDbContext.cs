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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FichaTecnicaTypeConfiguration());
        }
    }
}
