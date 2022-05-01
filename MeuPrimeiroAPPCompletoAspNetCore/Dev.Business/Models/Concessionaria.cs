using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models
{
    public class Concessionaria:EntidadeBase
    {
        public string Nome { get; set; }

        //propriedade de relacionamento do entity
        public List<Carro> Carro_EF { get; set; }
    }
}
