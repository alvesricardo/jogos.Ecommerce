using jogos.Ecommerce.Dominio;
using jogos.Ecommerce.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Ecommerce.Dados.Entity.TypeConfiguration
{
    class FichaTecnicaTypeConfiguration : JogosEntityAbstractConfig<FichaTecnica>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id).IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).HasColumnName("Id");

            Property(p => p.Nome).IsRequired().HasMaxLength(200).HasColumnName("Nome");

            Property(p => p.Desenvolvedora).IsRequired().HasMaxLength(200).HasColumnName("Desenvolvedora");

            Property(p => p.Publicadora).IsRequired().HasMaxLength(200).HasColumnName("Publicadora");

            Property(p => p.AnoLancamento).IsRequired().HasColumnName("Ano de Lançamento");

            Property(p => p.Plataforma).HasMaxLength(100).IsRequired().HasColumnName("Plataforma");

            Property(p => p.Genero).IsRequired().HasMaxLength(100).HasColumnName("Genero");

            Property(p => p.Enredo).HasMaxLength(1200).HasColumnName("Enredo");
            
            Property(p => p.Email).IsRequired().HasColumnName("Email");
    }

        protected override void ConfigurarChaveEstrangeira()
        {
            
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Jogos");
        }
    }
}