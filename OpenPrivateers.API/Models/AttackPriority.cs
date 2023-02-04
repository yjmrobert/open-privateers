namespace OpenPrivateers.API.Models;

public class AttackPriority
{
    public Weapon? Weapon { get; set; }
    public ShipClass? ShipClass { get; set; }
    public int Rank { get; set; }
}