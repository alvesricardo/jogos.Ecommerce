using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogos.Ecommerce.Dominio
{
    public class FichaTecnica
    {
        public int Id { get; set; }
        public string Nome {get; set;}
        public string Desenvolvedora { get; set; }
        public string Publicadora { get; set; }
        public int AnoLancamento { get; set; }
        public virtual Plataforma Plataforma { get; set; }
        public long IdPlataforma { get; set; }
        public string Genero { get; set; }
        public string Enredo { get; set; }
        public string Email { get; set; }
        
       
        
    }
}
