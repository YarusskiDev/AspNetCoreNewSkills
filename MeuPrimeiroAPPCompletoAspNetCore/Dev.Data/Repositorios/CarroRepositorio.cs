using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Data.Repositorios
{
    public class CarroRepositorio : BaseRepositorio<Carro>, ICarroRepositorio
    {
        public CarroRepositorio(MeuDbContexto db) : base(db)
        {

        }
    }
}
