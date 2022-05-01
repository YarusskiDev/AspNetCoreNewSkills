using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models
{
    public class Endereco:EntidadeBase
    {
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int Numero { get; set; }

        //EF
        public Cliente Cliente { get; set; }

    }
}
