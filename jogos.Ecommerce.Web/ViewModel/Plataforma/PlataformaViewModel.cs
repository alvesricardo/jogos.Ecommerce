using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jogos.Ecommerce.Web.ViewModel.Plataforma
{
    public class PlataformaViewModel
    {

        [Required(ErrorMessage = "Id da Plataforma é obrigatório")]
        public int IdPlataforma { get; set; }

        [Required(ErrorMessage = "Nome da plataforma é obrigatório")]
        [MaxLength(200, ErrorMessage = "Deve ter no máximo 200 caracteres")]
        [Display(Name = "Nome da Plataforma")]
        public string NomePlataforma { get; set; }

        [Required(ErrorMessage = "Nome do fabricante é obrigatório")]
        [MaxLength(200, ErrorMessage = "Deve ter no máximo 200 caracteres")]
        [Display(Name = "Nome do Fabricante")]
        public string Fabricante { get; set; }
    }
}