using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class CaminhaoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DataDeCriacao { get; set; }
    }
}
