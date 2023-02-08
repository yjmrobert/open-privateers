using System.Globalization;
using System.Text.Json;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using OpenPrivateers.Domain.Models;
using OpenPrivateers.Migrations.Maps;

namespace OpenPrivateers.Migrations.Database;

public static class OpenPrivateersSeeding
{

    private static readonly string DataDirectoryPath =
        Path.Join(Directory.GetCurrentDirectory(), "./Data");
    
    public static void SeedShipData(this OpenPrivateersContext context, ModelBuilder modelBuilder)
    {
        SeedShipClasses(modelBuilder);
        SeedShips(modelBuilder);
    }

    private static void SeedShipClasses(ModelBuilder modelBuilder)
    {
        using var reader = new StreamReader($"{DataDirectoryPath}/ShipClasses.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<ShipClass>();

        // ensure that the model builder has each entity
        records.ToList().ForEach(shipClass => { modelBuilder.Entity<ShipClass>().HasData(shipClass); });
    }

    private static void SeedShips(ModelBuilder modelBuilder)
    {
        using var reader = new StreamReader($"{DataDirectoryPath}/Ships.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<Ship>();

        // ensure that the model builder has each entity
        records.ToList().ForEach(ship =>
        {
            modelBuilder.Entity<Ship>().HasData(ship);
        });
    }
}