using Microsoft.EntityFrameworkCore;

namespace OpenPrivateers.API.Models;

[PrimaryKey(nameof(ShipModuleId), nameof(AttributeId))]
public class ModuleProperty
{
    public int ShipModuleId { get; set; }
    public int AttributeId { get; set; }
    public int Value { get; set; }
    
    public ShipModule? ShipModule { get; set; }
    public Attribute? Attribute { get; set; }
}