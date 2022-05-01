using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevAppMain.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Rua { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Estado { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public int Numero { get; set; }

        //EF
        [ScaffoldColumn(false)]
        public ClienteViewModel Cliente { get; set; }
    }
}
