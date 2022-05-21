using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uroskur.Shared;

namespace Shared.Tests;

[TestClass]
public class DistanceHelperTest
{
    [TestMethod]
    public void TestCalculateTotalDistance()
    {
        var routeLocations = GpxParser.GpxToLocations(Gxp.FileAsString());
        var totalDistance = DistanceHelper.CalculateTotalDistance(routeLocations);
        Assert.AreEqual(45, Math.Round(totalDistance));
    }

    [TestMethod]
    public void TestGetEvenDistances()
    {
        var routeLocations = GpxParser.GpxToLocations(Gxp.FileAsString());
        var locations = DistanceHelper.GetEvenDistances(routeLocations)?.ToList();
        Assert.AreEqual(4, locations?.Count);
    }
}