using System.Globalization;
using System.Text.Json;
using CsvHelper;
using OpenPrivateers.API.Models;
using OpenPrivateers.API.Validators;

namespace OpenPrivateers.API.UnitTests;

public class CsvImportTests
{
    
    private static readonly string DataDirectoryPath =
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
    public void CanImportShipsCsvTest()
    {
        // import the csv and convert each row into a Ship
        using var reader = new StreamReader($"{DataDirectoryPath}/Ships.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<Ship>();
        
        // assert that each ship is valid
        var validator = new ShipValidator();
        records.ToList().ForEach(ship =>
        {
            var validationResult = validator.Validate(ship);
            
            Assert.That(validationResult.IsValid, Is.True, 
                validationResult.Errors.Any() ? 
                    validationResult.Errors
                        .Select(x => x.ErrorMessage)
                        .Aggregate((x, y) => $"{x}, {y}") : 
                    "No errors found");
        });
    }
}