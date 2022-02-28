using System.Linq.Expressions;

namespace Uroskur.DataAccess.Repositories;

public interface IBaseRepository<T> where T : class
{
    Task<IEnumerable<T>> FindAllAsync();
    Task<T?> FindAsync(long id);
    Task<bool> AddAsync(T? entity);
    Task<bool> RemoveAsync(long id);
    Task<T?> UpsertAsync(T stravaUser);
    Task<IEnumerable<T?>> Find(Expression<Func<T?, bool>> predicate);
}