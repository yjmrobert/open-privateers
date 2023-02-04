namespace OpenPrivateers.API.Models;

public class ModuleInstallation
{
    public ShipSystem? ShipSystem { get; set; }
    public ShipModule? ShipModule { get; set; }
    public int? Quantity { get; set; }
}