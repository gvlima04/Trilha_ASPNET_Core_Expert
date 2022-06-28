using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório"), Display(Name = "Título")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do título deve estar entre 3 e 60 caracteres")]
        public string? Title { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Formato inválido"), Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Formato inválido")]
        [Display(Name = "Gênero"), Required(ErrorMessage = "Campo obrigatório")]
        public string? Gender { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Display(Name = "Valor"), Required(ErrorMessage = "Campo obrigatório")]
        public decimal Value { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 0 - 5")]
        [Display(Name = "Avaliação"), Required(ErrorMessage = "Campo obrigatório")]
        public int Rating { get; set; }    
    
    }
}