using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Data.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>,IClienteRepositorio
    {
        public ClienteRepositorio(MeuDbContexto db) : base(db)
        {
        }
    }
}
