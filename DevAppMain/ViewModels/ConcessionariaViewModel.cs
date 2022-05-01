using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevAppMain.ViewModels
{
    public class ConcessionariaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Nome { get; set; }

        //propriedade de relacionamento do entity
        [ScaffoldColumn(false)]
        public List<Carro> Carro_EF { get; set; }
    }
}
