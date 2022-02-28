using Uroskur.Model;

namespace Uroskur.DataAccess.Repositories;

public class GoogleUserRepository : BaseRepository<GoogleUser>, IGoogleUserRepository
{
    public GoogleUserRepository(DataContext context) : base(context)
    {
    }

    public override async Task<GoogleUser?> UpsertAsync(GoogleUser entity)
    {
        var googleUser = await FindByMailAsync(entity.Mail);
        if (googleUser == null)
        {
            if (await AddAsync(entity))
            {
                return entity;
            }

            return null;
        }

        googleUser.DisplayName = entity.DisplayName;
        googleUser.Mail = entity.Mail;
        googleUser.StravaUserId = entity.StravaUserId;

        await UpdateAsync(googleUser);

        return googleUser;
    }

    public async Task<GoogleUser?> FindByMailAsync(string? mail)
    {
        return (await Find(u => u != null && u.Mail != null && u.Mail.Equals(mail))).FirstOrDefault();
    }

    public async Task<GoogleUser?> FindByStravaUserIdAsync(long id)
    {
        return (await Find(u => u != null && u.StravaUserId == (int)id)).FirstOrDefault();
    }
}