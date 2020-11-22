using jogos.Ecommerce.Dominio;
using jogos.Ecommerce.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Ecommerce.Dados.Entity.TypeConfiguration
{
    class PlataformaTypeConfiguration : JogosEntityAbstractConfig<Plataforma>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdPlataforma).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).HasColumnName("IdPlataforma");
            Property(p => p.NomePlataforma).IsRequired().HasMaxLength(300).HasColumnName("NomePlataforma");
            Property(p => p.Fabricante).IsRequired().HasMaxLength(200).HasColumnName("NomeFabricante");
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdPlataforma);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Plataforma");
        }
    }
}
