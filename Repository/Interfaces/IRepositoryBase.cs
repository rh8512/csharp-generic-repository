using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity Save(TEntity entity);
        public TEntity Update(TEntity entity);
        public bool Delete(TEntity entity);
    }
}