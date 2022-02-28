using Uroskur.Shared.Models;

namespace Uroskur.Shared;

public static class DistanceHelper
{
    public static double CalculateTotalDistance(IEnumerable<Location> locations)
    {
        var d = 0d;
        foreach (var (_, current, next) in locations.GetItems())
        {
            d += CalculateDistance(current.Lat, current.Lon,
                next.Lat,
                next.Lon);
        }

        return d;
    }

    private static double CalculateDistance(double lat1, double lon1, double lat2,
        double lon2)
    {
        double Rad(double angle)
        {
            return angle * 0.017453292519943295769236907684886127d;
        }

        double Havf(double diff)
        {
            return Math.Pow(Math.Sin(Rad(diff) / 2d), 2);
        }

        return 12745.6 *
               Math.Asin(Math.Sqrt(
                   Havf(lat2 - lat1) +
                   Math.Cos(Rad(lat1)) * Math.Cos(Rad(lat2)) *
                   Havf(lon2 - lon1)));
    }

    public static IEnumerable<Location> GetEvenDistances(IEnumerable<Location> locations)
    {
        var distances = new List<Location>();
        var i = 0;
        var total = 0d;
        foreach (var (_, current, next) in locations.GetItems())
        {
            total += CalculateDistance(current.Lat, current.Lon,
                next.Lat,
                next.Lon);

            var d = Math.Round(total, 1);
            if (d % 10 != 0 || !(Math.Abs(d - i) > 0))
            {
                continue;
            }

            distances.Add(current);
            i = (int)d;
        }

        return distances;
    }
}