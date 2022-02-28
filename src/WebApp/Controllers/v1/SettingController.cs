using Microsoft.AspNetCore.Mvc;
using Uroskur.DataAccess.Repositories;
using Uroskur.Model;
using Uroskur.WebApp.Models;

namespace Uroskur.WebApp.Controllers.v1;

[Route("api/v1/[controller]/[action]")]
[ApiController]
public class SettingController : ControllerBase
{
    private readonly ISettingRespository _settingRepository;

    public SettingController(
        ISettingRespository settingRespository)
    {
        _settingRepository = settingRespository;
    }

    [HttpGet]
    public async Task<IActionResult> Settings()
    {
        return Ok(await _settingRepository.FindSettingAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Settings(SettingModel? settingsModel)
    {
        var setting = await _settingRepository.FindSettingAsync() ?? new Setting();
        setting.ClientId = settingsModel?.ClientId;
        setting.ClientSecret = settingsModel?.ClientSecret;
        setting.AppId = settingsModel?.AppId;

        await _settingRepository.UpsertAsync(setting);

        return Ok();
    }
}