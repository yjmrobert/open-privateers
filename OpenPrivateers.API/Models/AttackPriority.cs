using Microsoft.EntityFrameworkCore;

namespace OpenPrivateers.API.Models;

[PrimaryKey(nameof(WeaponId), nameof(ShipClassId))]
public class AttackPriority
{
    public int WeaponId { get; set; }
    public int ShipClassId { get; set; }
    public int Rank { get; set; }
    
    public Weapon? Weapon { get; set; }
    public ShipClass? ShipClass { get; set; }
}