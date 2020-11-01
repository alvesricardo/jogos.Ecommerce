using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Ecommerce.Generica.Entity
{
    public abstract class JogosEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade> where TEntidade : class
    {
        public JogosEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveEstrangeira();
        }

        protected abstract void ConfigurarNomeTabela();

        protected abstract void ConfigurarCamposTabela();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarChaveEstrangeira();
        
    }
}
