using Uroskur.Model;

namespace Uroskur.DataAccess.Repositories;

public interface ISettingRespository : IBaseRepository<Setting>
{
    Task<Setting?> FindSettingAsync();
}