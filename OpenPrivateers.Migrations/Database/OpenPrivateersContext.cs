using Microsoft.EntityFrameworkCore;
using OpenPrivateers.Domain.Models;

namespace OpenPrivateers.Migrations.Database;

public class OpenPrivateersContext : DbContext
{
    public DbSet<Ability>? Abilities { get; set; }
    public DbSet<AttackPriority>? AttackPriorities { get; set; }
    public DbSet<GameAttribute>? GameAttributes { get; set; }
    
    public DbSet<DamageType>? DamageTypes { get; set; }
    public DbSet<ModuleInstallation>? ModuleInstallations { get; set; }
    public DbSet<ModuleProperty>? ModuleProperties { get; set; }
    
    public DbSet<Ship>? Ships { get; set; }
    public DbSet<ShipClass>? ShipClasses { get; set; }
    public DbSet<ShipModule>? ShipModules { get; set; }
    public DbSet<ShipSystem>? ShipSystems { get; set; }
    
    public DbSet<Weapon>? Weapons { get; set; }
    public DbSet<WeaponClassification>? WeaponClassifications { get; set; }
    public DbSet<WeaponInstallation>? WeaponInstallations { get; set; }
    public DbSet<WeaponSystem>? WeaponSystems { get; set; }

    
    public OpenPrivateersContext(DbContextOptions<OpenPrivateersContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        this.SeedShipData(modelBuilder);
    }
}