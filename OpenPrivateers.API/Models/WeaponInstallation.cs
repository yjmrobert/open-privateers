namespace OpenPrivateers.API.Models;

public class WeaponInstallation
{
    public WeaponSystem? WeaponSystem { get; set; }
    public Weapon? Weapon { get; set; }
    public int? Quantity { get; set; }
}