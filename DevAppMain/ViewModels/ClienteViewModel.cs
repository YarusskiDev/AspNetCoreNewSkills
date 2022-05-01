using Dev.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevAppMain.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Nome { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O campo é {0} é obrigatório e precisa ter entre{2} e {1} caracteres", MinimumLength = 5)]
        public string Telefone { get; set; }

        [HiddenInput]
        public Guid EnderecoId { get; set; }

        [ScaffoldColumn(false)]
        public EnderecoViewModel Endereco { get; set; }
        [ScaffoldColumn(false)]
        public CarroViewModel Carro { get; set; }
    }
}

