using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Posts
    {
        [Key] // Chave do item
        public int IdPost { get; set; }

        // ------------ Nome
        [Display(Name = "Nome do post")] // Label na pagina
        [Required(ErrorMessage = "Este item é obrigatorio")] // Item requerido/Obrigatorio
        [StringLength(20, ErrorMessage = "Deve conter no maximo 20 caracteres")] // Quantidade de Caracteres do campo
        [MinLength(4, ErrorMessage = "Nome deve ter no minimo 4 caracteres")] // Quantidade minima do campo
        public string NomePost { get; set; }

        // ------------ Resumo
        [Display(Name = "Resumo do Post")] // Label na pagina
        [Required(ErrorMessage = "Este item é obrigatorio")] // Item requerido/Obrigatorio
        //[StringLength(50, ErrorMessage = "Deve conter no maximo 50 caracteres")] // Quantidade de Caracteres do campo
        public string ResumoPost { get; set; }

        // ------------ Conteudo
        [Display(Name = "Conteudo do post")] // Label na pagina
        [Required(ErrorMessage = "Este item é obrigatorio")] // Item requerido/Obrigatorio
        //[StringLength(300, ErrorMessage = "Deve conter no maximo 300 caracteres")] // Quantidade de Caracteres do campo
        public string ConteudoPost { get; set; }

        // ------------ Data
        [DataType(DataType.Date)] // Tipo de dado nesse caso data, mas pode ser telefone, email ...
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)] // Formato de visualização na pagina Index, dia-mes-ano
        [Display(Name = "Data da posts")]
        public DateTime DataPost { get; set; } = DateTime.Now;

        // ------------ Usuário que criou a pastagem
        public string? UsuarioCriador { get; set; }

    }
}
