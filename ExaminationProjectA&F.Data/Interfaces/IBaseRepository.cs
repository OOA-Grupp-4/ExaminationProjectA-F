using System.Linq.Expressions;

namespace ExaminationProjectA_F.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllyAsync();
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> SaveAsync(TEntity entity);
    }
}