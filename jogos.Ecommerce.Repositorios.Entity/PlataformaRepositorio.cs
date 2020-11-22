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
    public class PlataformaRepositorio : RepositorioGenericoEntity<Plataforma, long>
    {
        public PlataformaRepositorio(JogoDbContext contexto) : base(contexto)
        {

        }

        public override List<Plataforma> Selecionar()
        {
            return _contexto.Set<Plataforma>().Include(p => p.Fichas).ToList();
        }
        public override Plataforma SelecionarPorId(long id)
        {
            return _contexto.Set<Plataforma>().Include(p => p.Fichas).SingleOrDefault(a => a.IdPlataforma == id);
        }
    }
}
