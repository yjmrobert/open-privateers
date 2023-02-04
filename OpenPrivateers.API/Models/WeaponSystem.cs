namespace OpenPrivateers.API.Models;

public class WeaponSystem : BaseEntity
{
    public string? Name { get; set; }
    public int SystemHealth { get; set; }
    
    public Ship? Ship { get; set; }
    public List<WeaponInstallation>? WeaponInstallations { get; set; }
}