using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jogos.Ecommerce.Web.ViewModel.Plataforma
{
    public class PlataformaIndexViewModel
    {
        
        public long IdPlataforma { get; set; }
        
        [Display(Name = "Nome da Plataforma")]
        public string NomePlataforma { get; set; }
        
        [Display(Name = "Nome do Fabricante")]
        public string Fabricante { get; set; }
    }
}