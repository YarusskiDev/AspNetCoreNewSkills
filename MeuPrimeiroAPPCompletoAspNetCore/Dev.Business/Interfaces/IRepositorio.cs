using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IRepositorio<T> where T:EntidadeBase
    {
        Task Adicionar(T entidade);
        Task<T> ObterPorId(Guid id);
        Task<List<T>> ObterTodos();
        Task Atualizar(T entidade);
        Task Remover(Guid id);

        Task<IEnumerable<T>> Buscar(Expression<Func<T,bool>> predicate);
        Task<int> SaveChanges();
    }
}
