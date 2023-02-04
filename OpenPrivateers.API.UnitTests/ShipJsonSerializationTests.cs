using System.Text.Json;
using System.Text.Json.Serialization;
using OpenPrivateers.API.Models;

namespace OpenPrivateers.API.UnitTests;

public class Tests
{
    
    private static readonly string ShipDataDirectoryPath =
        Path.Join(Directory.GetCurrentDirectory(), "../../../../OpenPrivateers.API/Data");
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SanityCheck()
    {
        Assert.Pass();
    }

    [Test]
    public void CanSerializeJsonIntoShip()
    {
        // serialize ../OpenPrivateers.API/Data/FG300_A.json into a Ship object
        
        var fg300AJson = File.ReadAllText($"{ShipDataDirectoryPath}/FG300_A.json");
        var fg300A = JsonSerializer.Deserialize<Ship>(fg300AJson);
        
        Assert.That(fg300A, Is.Not.Null);
        Assert.That(fg300A?.Name, Is.EqualTo("FG300"));
    }
}