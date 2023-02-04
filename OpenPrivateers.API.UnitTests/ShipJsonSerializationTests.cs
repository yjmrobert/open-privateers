using System.Text.Json;
using System.Text.Json.Serialization;
using OpenPrivateers.API.Models;
using OpenPrivateers.API.Validators;

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
    [TestCase("FG300_A.json")]
    public void CanSerializeJsonIntoShip(string shipFileName)
    {
        // serialize ../OpenPrivateers.API/Data/FG300_A.json into a Ship object

        var shipJson = File.ReadAllText($"{ShipDataDirectoryPath}/{shipFileName}");
        var ship = JsonSerializer.Deserialize<Ship>(shipJson);
        
        // assert that every property is not null
        Assert.That(ship, Is.Not.Null);
        
        // create validator and assert that the ship is valid
        var validator = new ShipValidator();
        var validationResult = validator.Validate(ship!);
        
        
        Assert.That(validationResult.IsValid, Is.True, 
            validationResult.Errors.Any() ? 
                validationResult.Errors
                    .Select(x => x.ErrorMessage)
                    .Aggregate((x, y) => $"{x}, {y}") : 
                "No errors found");
    }
}