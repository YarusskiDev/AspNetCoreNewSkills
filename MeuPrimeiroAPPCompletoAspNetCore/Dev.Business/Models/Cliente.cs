using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models
{
    public class Cliente:EntidadeBase
    {
        public string Nome { get; set; }

        public Guid EnderecoId { get; set; }
        public string Cpf { get; set; }

        public string Telefone { get; set; }


        //EF
        public Endereco Endereco { get; set; }
        public Carro Carro { get; set; }
    }
}
