using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Ecommerce.Dominio
{
    public class Plataforma
    {
        public long IdPlataforma { get; set; }
        public string NomePlataforma { get; set; }
        public string Fabricante { get; set; }
        public virtual List<FichaTecnica> Fichas { get; set; }

    }
}
