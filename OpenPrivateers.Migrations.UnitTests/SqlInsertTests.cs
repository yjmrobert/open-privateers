using System.Globalization;
using CsvHelper;
using OpenPrivateers.Domain.Models;
using OpenPrivateers.Domain.Validators;
using OpenPrivateers.Migrations.Maps;

namespace OpenPrivateers.Domain.UnitTests;

public class SqlInsertTests
{
     private static readonly string DataDirectoryPath =
        Path.Join(Directory.GetCurrentDirectory(), "../../../../OpenPrivateers.Migrations/Data");
    
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
        
        // csv.Context.RegisterClassMap<ShipMap>();
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

    [Test]
    public void CanImportShipClassesCsvTest()
    {
        // import the csv and convert each row into a ShipClass
        using var reader = new StreamReader($"{DataDirectoryPath}/ShipClasses.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<ShipClass>();
        
        // assert that each ship class is valid
        var validator = new ShipClassValidator();
        records.ToList().ForEach(shipClass =>
        {
            var validationResult = validator.Validate(shipClass);
            
            Assert.That(validationResult.IsValid, Is.True, 
                validationResult.Errors.Any() ? 
                    validationResult.Errors
                        .Select(x => x.ErrorMessage)
                        .Aggregate((x, y) => $"{x}, {y}") : 
                    "No errors found");
        });        
    }
}