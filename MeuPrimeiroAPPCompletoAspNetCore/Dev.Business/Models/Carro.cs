using Dev.Business.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models
{
     public class Carro:EntidadeBase
    {
        public Guid ConcessionariaId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime Ano { get; set; }

        public string Placa { get; set; }

        public string Imagem { get; set; }

        public DateTime DataEntrada { get; set; }

        public DateTime DataSaida { get; set; }

        public StatusCarro Status { get; set; }

        //propriedade de relacionamento do entity
        public Concessionaria Concessionaria_EF { get; set; }
        public List<Cliente> Clientes { get; set; }


        //private static bool ValidarPlaca(string placa)
        //{
        //    if (string.IsNullOrWhiteSpace(placa)) { return false; }

        //    if (placa.Length > 8) { return false; }

        //    placa = placa.Replace("-", "").Trim();

        //    /*
        //     *  Verifica se o caractere da posição 4 é uma letra, se sim, aplica a validação para o formato de placa do Mercosul,
        //     *  senão, aplica a validação do formato de placa padrão.
        //     */
        //    if (char.IsLetter(placa, 4))
        //    {
        //        /*
        //         *  Verifica se a placa está no formato: três letras, um número, uma letra e dois números.
        //         */
        //        var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
        //        return padraoMercosul.IsMatch(placa);
        //    }
        //    else
        //    {
        //        // Verifica se os 3 primeiros caracteres são letras e se os 4 últimos são números.
        //        var padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");
        //        return padraoNormal.IsMatch(placa);
        //    }
        //}

    }
}
