using jogos.Ecommerce.Dados.Entity.Context;
using jogos.Ecommerce.Dominio;
using jogos.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Ecommerce.Repositorios.Entity
{
    public class FichaTecnicaRepositorio : RepositorioGenericoEntity<FichaTecnica, int>
    {
        public FichaTecnicaRepositorio(JogoDbContext contexto) : base(contexto)
        {

        }
    }
}
