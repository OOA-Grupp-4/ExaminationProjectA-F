using ExaminationProjectA_F.Data.Contexts;
using ExaminationProjectA_F.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExaminationProjectA_F.Data.Repositories;

public abstract class BaseRepository<TEntity>(DataContext context) : IBaseRepository<TEntity> where TEntity : class
{
    private readonly DataContext _context = context;

    public async Task<TEntity> SaveAsync(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
        }
        catch { }
        return null!;
    }

    public async Task<IEnumerable<TEntity>> GetAllyAsync()
    {
        try
        {
            var entities = await _context.Set<TEntity>().ToListAsync();
            return entities;
        }
        catch { }
        return null!;
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        try
        {
            var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(expression);

            if (entity != null)
                return entity;
        }
        catch { }
        return null!;
    }

}
