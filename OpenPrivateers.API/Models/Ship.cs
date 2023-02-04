namespace OpenPrivateers.API.Models;

public class Ship : BaseEntity
{
    public string? Name { get; set; }
    public string? VariantName { get; set; }
    public string? VariantLetter { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    
    public ShipClass? ShipClass { get; set; }
    
    public List<ShipSystem>? ShipSystems { get; set; }
    public List<WeaponSystem>? WeaponSystems { get; set; }
}