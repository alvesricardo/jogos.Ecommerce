using jogos.Ecommerce.Repositorios.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Repositorios.Comum.Entity
{
    public class RepositorioGenericoEntity<TEntidade, TChave> : IRepositorioGenerico<TEntidade, TChave>
        where TEntidade : class
    {
        public void Alterar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPorId(TChave id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public List<TEntidade> Selecionar()
        {
            throw new NotImplementedException();
        }

        public TEntidade SelecionarPorId(TChave id)
        {
            throw new NotImplementedException();
        }
    }
}
