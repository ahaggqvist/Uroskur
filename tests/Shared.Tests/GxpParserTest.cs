using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uroskur.Shared;

namespace Shared.Tests;

[TestClass]
public class GxpParserTest
{
    [TestMethod]
    public void ParseTest()
    {
        Assert.Equals(1957, GpxParser.GpxToLocations(Gxp.FileAsString()).Count);
    }
}