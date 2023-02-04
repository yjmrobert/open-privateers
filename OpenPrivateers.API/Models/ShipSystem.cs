namespace OpenPrivateers.API.Models;

public class ShipSystem : BaseEntity
{
    public string? Name { get; set; }
    public int SystemHealth { get; set; }
    
    public List<ModuleInstallation>? ModuleInstallations { get; set; }
}