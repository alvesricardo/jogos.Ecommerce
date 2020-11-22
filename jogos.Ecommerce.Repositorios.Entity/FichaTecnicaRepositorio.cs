using jogos.Ecommerce.Dados.Entity.Context;
using jogos.Ecommerce.Dominio;
using jogos.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace jogos.Ecommerce.Repositorios.Entity
{
    public class FichaTecnicaRepositorio : RepositorioGenericoEntity<FichaTecnica, int>
    {
        public FichaTecnicaRepositorio(JogoDbContext contexto) : base(contexto)
        {

        }

        public override List<FichaTecnica> Selecionar()
        {
            return _contexto.Set<FichaTecnica>().Include(p => p.Plataforma).ToList();
        }
        public override FichaTecnica SelecionarPorId (int id)
        {
            return _contexto.Set<FichaTecnica>().Include(p => p.Plataforma).SingleOrDefault(f => f.Id == id);
        }
    }
}
