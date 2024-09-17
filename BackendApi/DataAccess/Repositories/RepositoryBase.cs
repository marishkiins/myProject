using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PlangodbContext RepositoryContex {  get; set; }
        public RepositoryBase(PlangodbContext repositoryContex)
        {
            RepositoryContex = repositoryContex;
        }
        public IQueryable<T> FindAll() => RepositoryContex.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => RepositoryContex.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => RepositoryContex.Set<T>().Add(entity);
        public void Update(T entity) => RepositoryContex.Set<T>().Update(entity);
        public void Delete(T entity) => RepositoryContex.Set<T>().Remove(entity);

    }
}
