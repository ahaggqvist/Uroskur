using Uroskur.Model;

namespace Uroskur.DataAccess.Repositories;

public interface IStravaUserRepository : IBaseRepository<StravaUser>
{
    Task<StravaUser?> FindByAthleteIdAsync(long? id);
}