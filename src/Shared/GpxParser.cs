using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Uroskur.Shared.Models;

namespace Uroskur.Shared;

public static class GpxParser
{
    private const string DefaultNamespace = "http://www.topografix.com/GPX/1/1";

    public static List<Location> GpxToLocations(string xml)
    {
        using var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
        var xmlReader = XmlReader.Create(sourceStream, new XmlReaderSettings
        {
            Async = true
        });

        var xmlSerializer = new XmlSerializer(typeof(Gpx), DefaultNamespace);
        if (xmlSerializer.Deserialize(xmlReader) is not Gpx gpx)
        {
            return new List<Location>();
        }

        var trksegTrkpt = gpx.Trk?.Trkseg?.TrksegTrkpt;

        return trksegTrkpt == null
            ? new List<Location>()
            : trksegTrkpt.Select(trkpt => new Location(trkpt.Lat, trkpt.Lon)).ToList();
    }
}