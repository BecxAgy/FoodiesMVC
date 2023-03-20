using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodiesMVC.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage="O nome da categoria deve ser informado")]
        [Display(Name = "Nome da Categoria")]
        [StringLength(100, ErrorMessage ="O Nome da Categoria não deve exceder 100 caracteres")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "A descrição deve ser informado")]
        [Display(Name = "Descrição")]
        [MinLength(20, ErrorMessage ="A descrição deve ter no mínimo 20 caracteres")]
        [MaxLength(250, ErrorMessage = "A descrição deve ter no máximo 250 caracteres")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
