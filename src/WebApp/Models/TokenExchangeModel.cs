using System.ComponentModel.DataAnnotations;
using Ganss.XSS;
using Microsoft.AspNetCore.Mvc;

namespace Uroskur.WebApp.Models;

public class TokenExchangeModel
{
    private string? _code;
    private string? _mail;

    [FromRoute]
    [EmailAddress]
    public string? Mail
    {
        get => _mail;
        set
        {
            var htmlSanitizer = new HtmlSanitizer();
            if (value != null)
            {
                _mail = htmlSanitizer.Sanitize(value);
            }
        }
    }

    [FromQuery]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public string? Code
    {
        get => _code;
        set
        {
            var htmlSanitizer = new HtmlSanitizer();
            if (value != null)
            {
                _code = htmlSanitizer.Sanitize(value);
            }
        }
    }
}