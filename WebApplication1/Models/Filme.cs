using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(60, MinimumLength =3,ErrorMessage ="Tamanho inválido.")]
        [MinLength(3, ErrorMessage = "Tamanho inválido.....")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Valor de 1 até 1000")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Avaliacao { get; set; }
    }
}
