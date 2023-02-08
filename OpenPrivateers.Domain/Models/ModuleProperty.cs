using Microsoft.EntityFrameworkCore;

namespace OpenPrivateers.Domain.Models;

[PrimaryKey(nameof(ShipModuleId), nameof(GameAttributeId))]
public class ModuleProperty
{
    public int ShipModuleId { get; set; }
    public int GameAttributeId { get; set; }
    public int Value { get; set; }
    
    public ShipModule? ShipModule { get; set; }
    public GameAttribute? GameAttribute { get; set; }
}