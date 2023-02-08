using Microsoft.EntityFrameworkCore;

namespace OpenPrivateers.Domain.Models;

[PrimaryKey(nameof(ShipSystemId), nameof(ShipModuleId))]
public class ModuleInstallation
{
    public int ShipSystemId { get; set; }
    public int ShipModuleId { get; set; }
    public int? Quantity { get; set; }
    
    public ShipSystem? ShipSystem { get; set; }
    public ShipModule? ShipModule { get; set; }
}