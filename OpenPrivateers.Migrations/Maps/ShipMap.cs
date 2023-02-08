using System.Globalization;
using CsvHelper.Configuration;
using OpenPrivateers.Domain.Models;

namespace OpenPrivateers.Migrations.Maps;

public sealed class ShipMap : ClassMap<Ship>
{
    public ShipMap()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.ShipClass).Ignore();
        Map(m => m.ShipSystems).Ignore();
        Map(m => m.WeaponSystems).Ignore();
    }
}