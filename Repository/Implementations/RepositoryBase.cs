using GenericRepository.Model;
using System;
using System.Collections.Generic;

namespace GenericRepository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
