using System.ComponentModel.DataAnnotations;
using Ganss.XSS;

namespace Uroskur.WebApp.Models;

public class SettingModel
{
    private string? _clientSecret;
    private string? _appId;

    [RegularExpression("^[a-zA-Z0-9]+$")]
    [Range(0, int.MaxValue, ErrorMessage = "Client ID must be a positive number.")]
    public int? ClientId { get; set; }

    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? ClientSecret
    {
        get => _clientSecret;
        set
        {
            var htmlSanitizer = new HtmlSanitizer();
            if (value != null)
            {
                _clientSecret = htmlSanitizer.Sanitize(value);
            }
        }
    }

    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? AppId
    {
        get => _appId;
        set
        {
            var htmlSanitizer = new HtmlSanitizer();
            if (value != null)
            {
                _appId = htmlSanitizer.Sanitize(value);
            }
        }
    }
}