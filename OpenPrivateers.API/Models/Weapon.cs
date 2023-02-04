
namespace OpenPrivateers.API.Models;

public class Weapon : BaseEntity
{
    public string? Name { get; set; }
    public string? SubName { get; set; }
    public string? Description { get; set; }
    
    public DamageType? DamageType { get; set; }
    public string? PrioritizedTarget { get; set; }
    public int DamagePerHit { get; set; }
    public List<Ability>? Abilities { get; set; }
    
    public List<AttackPriority>? AttackPriorities { get; set; }
    
    public int AntiShipFire { get; set; }
    public int AirDefense { get; set; }
    public int SiegeFire { get; set; }
    
    public int Duration { get; set; }
    public int LockOnTime { get; set; }
    public int Cooldown { get; set; }
    public int ProjectilesPerShot { get; set; }
    public int ShotsPerSalvo { get; set; }
}