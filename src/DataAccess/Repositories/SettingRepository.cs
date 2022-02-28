using System.Collections.Immutable;
using Uroskur.Model;

namespace Uroskur.DataAccess.Repositories;

public class SettingRepository : BaseRepository<Setting>, ISettingRespository
{
    public SettingRepository(DataContext context) : base(context)
    {
    }

    public override async Task<Setting?> UpsertAsync(Setting entity)
    {
        var setting = await FindAsync(entity.Id);
        if (setting == null)
        {
            if (await AddAsync(entity))
            {
                return entity;
            }

            return null;
        }

        setting.ClientId = entity.ClientId;
        setting.ClientSecret = entity.ClientSecret;
        setting.AppId = entity.AppId;

        await UpdateAsync(setting);

        return setting;
    }

    public async Task<Setting?> FindSettingAsync()
    {
        return (await FindAllAsync()).ToImmutableList().FirstOrDefault();
    }
}