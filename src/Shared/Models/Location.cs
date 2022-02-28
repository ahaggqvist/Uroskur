namespace Uroskur.Shared.Models;

public class Location
{
    public Location(double lat, double lon)
    {
        Lat = lat;
        Lon = lon;
    }

    public double Lat { get; init; }
    public double Lon { get; init; }

    public override string ToString()
    {
        return $"{nameof(Lat)}: {Lat}, {nameof(Lon)}: {Lon}";
    }
}