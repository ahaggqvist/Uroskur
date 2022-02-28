using Uroskur.Model;

namespace Uroskur.DataAccess.Repositories;

public class StravaUserRepository : BaseRepository<StravaUser>, IStravaUserRepository
{
    public StravaUserRepository(DataContext context) : base(context)
    {
    }

    public override async Task<StravaUser?> UpsertAsync(StravaUser entity)
    {
        var stravaUser = await FindByAthleteIdAsync(entity.AthleteId);
        if (stravaUser == null)
        {
            if (await AddAsync(entity))
            {
                return entity;
            }

            return null;
        }

        stravaUser.AccessToken = entity.AccessToken;
        stravaUser.ExpiresAt = entity.ExpiresAt;
        stravaUser.RefreshToken = entity.RefreshToken;

        await UpdateAsync(stravaUser);

        return stravaUser;
    }

    public async Task<StravaUser?> FindByAthleteIdAsync(long? athleteId)
    {
        return (await Find(u => u != null && u.AthleteId.Equals(athleteId))).FirstOrDefault();
    }
}