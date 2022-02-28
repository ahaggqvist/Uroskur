using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

#pragma warning disable CS8602

namespace Uroskur.DataAccess.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DataContext? _context;
    private readonly DbSet<T> _dbSet;

    public BaseRepository(DataContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> FindAllAsync()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public virtual async Task<T?> FindAsync(long id)
    {
        return await _dbSet.FindAsync((int)id);
    }

    public virtual async Task<bool> AddAsync(T? entity)
    {
        if (entity == null || _context == null)
        {
            return false;
        }

        await _dbSet.AddAsync(entity);

        _ = await _context?.SaveChangesAsync();

        return true;
    }

    public virtual async Task<bool> RemoveAsync(long id)
    {
        var entity = await FindAsync(id);
        if (entity == null || _context == null)
        {
            return false;
        }

        _dbSet.Remove(entity);
        _ = await _context?.SaveChangesAsync();

        return true;
    }

    public virtual Task<T?> UpsertAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IEnumerable<T?>> Find(Expression<Func<T?, bool>> predicate)
    {
        return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    protected async Task<bool> UpdateAsync(T? entity)
    {
        if (entity == null || _context == null)
        {
            return false;
        }

        _dbSet.Update(entity);

        _ = await _context?.SaveChangesAsync();

        return true;
    }
}