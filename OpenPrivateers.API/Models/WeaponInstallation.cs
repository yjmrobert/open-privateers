using Microsoft.EntityFrameworkCore;

namespace OpenPrivateers.API.Models;

[PrimaryKey(nameof(WeaponSystemId), nameof(WeaponId))]
public class WeaponInstallation
{
    public int WeaponSystemId { get; set; }
    public int WeaponId { get; set; }
    public int Quantity { get; set; }
    
    public WeaponSystem? WeaponSystem { get; set; }
    public Weapon? Weapon { get; set; }
}