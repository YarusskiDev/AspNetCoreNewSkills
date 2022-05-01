using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Data.Repositorios
{
    public abstract class BaseRepositorio<T> : IRepositorio<T> where T : EntidadeBase,new()
    {
        protected readonly MeuDbContexto Db;
        protected readonly DbSet<T> DbSet;

        public BaseRepositorio(MeuDbContexto db)
        {
            Db = db;
            DbSet = db.Set<T>();
        }
        public async Task Adicionar(T entidade)
        {
            DbSet.Add(entidade);
            await SaveChanges();
        }

        public async Task Atualizar(T entidade)
        {
            DbSet.Update(entidade);
            await SaveChanges();
        }

        public async Task<IEnumerable<T>> Buscar(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<T> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<List<T>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Remover(Guid id)
        {
             DbSet.Remove(new T { Id = id });
             await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
    }
}
