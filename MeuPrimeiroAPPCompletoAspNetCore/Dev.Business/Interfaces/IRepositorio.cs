using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IRepositorio<T>
    {
        Task Adicionar(T entidade);
        Task<T> ObterPorId(Guid id);
        Task<List<T>> ObterTodos();
        Task Atualizar(T entidade);
        Task Remover(Guid id);
        Task<int> SaveChanges();
    }
}
