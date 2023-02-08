namespace OpenPrivateers.Domain.Models;

public class ShipModule : BaseEntity
{
    public string? Name { get; set; }
    public string? SubName { get; set; }
    
    public List<ModuleProperty>? ModuleProperties { get; set; }
}