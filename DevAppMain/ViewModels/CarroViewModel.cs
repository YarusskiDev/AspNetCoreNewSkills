using Dev.Business.Enumeradores;
using Dev.Business.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevAppMain.ViewModels
{
    public class CarroViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Ano { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(7,ErrorMessage ="O campo {0} deve é obrigatório e deve ter no minimo {1} caracteres")]
        public string Placa { get; set; }
        public string Imagem { get; set; }
        //[Required(ErrorMessage = "O campo {0} é obrigatório")]
        //public IFormFile ImagemUpload { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Ativo?")]
        public StatusCarro Status { get; set; }

        public Concessionaria Concessionaria_EF { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
