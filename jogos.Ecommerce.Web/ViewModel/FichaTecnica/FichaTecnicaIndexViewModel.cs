using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jogos.Ecommerce.Web.ViewModel.FichaTecnica
{
    public class FichaTecnicaIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Jogo")]
        public string Nome { get; set; }

        [Display(Name = "Desenvolvedora")]
        public string Desenvolvedora { get; set; }

        [Display(Name = "Publicadora")]
        public string Publicadora { get; set; }

        [Display(Name = "Ano de Lançamento")]
        public int AnoLancamento { get; set; }

        [Display(Name = "Plataforma")]
        public long IdPlataforma { get; set; }

        [Display(Name = "Genero")]
        public string Genero { get; set; }

        [Display(Name = "Enredo")]
        public string Enredo { get; set; }

        [Display(Name = "Email do Responsável Pelo Cadastro")]
        public string Email { get; set; }
    }
}