using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jwt.Domain.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> SelectById(Guid id);
        Task<IEnumerable<TEntity>> Select();

        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
