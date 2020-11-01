using jogos.Ecommerce.Web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jogos.Ecommerce.Web.ViewModel.FichaTecnica
{
    public class FichaTecnicaViewModel
    {
        [Required(ErrorMessage = "Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do jogo é obrigatório")]
        [MaxLength(200, ErrorMessage = "Deve ter no máximo 200 caracteres")]
        [Display(Name = "Nome do Jogo")]
        public string Nome { get; set; }

        [Display(Name = "Desenvolvedora")]
        [Required(ErrorMessage = "Nome da desenvolvedora é obrigatório")]
        [MaxLength(200, ErrorMessage = "Desenvolvedora deve ter no máximo 200 caracteres")]
        public string Desenvolvedora { get; set; }

        [Required(ErrorMessage = "Nome da publicadora é obrigatório")]
        [MaxLength(200, ErrorMessage = "Publicadora deve ter no máximo 200 caracteres")]
        [Display(Name = "Publicadora")]
        public string Publicadora { get; set; }

        [Required(ErrorMessage = "O ano de lançamento é obrigatório")]
        [Display(Name = "Ano de Lançamento")]
        public int AnoLancamento { get; set; }

        [Required(ErrorMessage = "A plataforma é obrigatório")]
        [MaxLength(100, ErrorMessage = "Plataforma deve ter no máximo 100 caracteres")]
        [Display(Name = "Plataforma")]
        public string Plataforma { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório")]
        [MaxLength(100, ErrorMessage = "Gênero deve ter no máximo 100 caracteres")]
        [Display(Name = "Genero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O enredo é obrigatório")]
        [MaxLength(1200, ErrorMessage = "Enredo deve ter no máximo 1200 caracteres")]
        [Display(Name = "Enredo")]
        public string Enredo { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [Email(ErrorMessage = "O domínio do email dever ser @mundodosjogos.com.br")]
        [Display(Name = "Email do Responsável Pelo Cadastro")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}