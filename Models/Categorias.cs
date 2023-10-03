using System.ComponentModel.DataAnnotations;
namespace Blog.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriasId { get; set; }

        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Display(Name = "Definição")]
        public string Definicao { get; set; }

        // propriedade navegação
        //public List<Posts> Posts { get; set; }
    }
}
