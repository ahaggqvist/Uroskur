using Uroskur.Model;

namespace Uroskur.DataAccess.Repositories;

public interface IGoogleUserRepository : IBaseRepository<GoogleUser>
{
    Task<GoogleUser?> FindByMailAsync(string? mail);

    Task<GoogleUser?> FindByStravaUserIdAsync(long id);
}