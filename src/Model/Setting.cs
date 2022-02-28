using System.ComponentModel.DataAnnotations.Schema;

namespace Uroskur.Model;

[Table("settings")]
public sealed class Setting : BaseModel
{
    public int? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public string? AppId { get; set; }

    public override string ToString()
    {
        return $"{nameof(ClientId)}: {ClientId}, {nameof(ClientSecret)}: {ClientSecret}, {nameof(AppId)}: {AppId}";
    }
}