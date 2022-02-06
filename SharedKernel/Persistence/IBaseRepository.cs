using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Persistence
{
    public interface IBaseRepository<EntityType> where EntityType : class
    {
        protected IQueryable<EntityType> GetAll();
        protected IQueryable<EntityType> GetByConditionAsync(Expression<Func<EntityType, bool>> expression);
        Task<EntityType> FindByConditionAsync(Expression<Func<EntityType, bool>> expression, CancellationToken cancellationToken = default);
        Task<EntityType> FindAllAsync(CancellationToken cancellationToken = default);
        Task CreateAsync(EntityType entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(EntityType entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(EntityType entity, CancellationToken cancellationToken = default);
    }
}
