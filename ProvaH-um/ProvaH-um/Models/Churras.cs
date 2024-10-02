using ProvaH_um.Validations;
using System.ComponentModel.DataAnnotations;

namespace ProvaH_um.Models
{
    public class Churras
    {
        [Required(ErrorMessage = "Nome (obrigatório)")]
        [MinLength(3, ErrorMessage = "Nome mínimo 3 caracteres")]
        [MaxLength(255, ErrorMessage = "Nome máximo 255 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Descrição (obrigatório)(Ex, Vou levar 1 kg de picanha)")]
        public string Desclevar { get; set; } = string.Empty;

        [Required(ErrorMessage = "Idade (obrigatório)")]
        [IdadeValidation(ErrorMessage = "A idade não pode ser menor que 18")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Oque vai levar de bebida(obrigatório)")]
        public string Bebida { get; set; } = string.Empty;
    }
}
