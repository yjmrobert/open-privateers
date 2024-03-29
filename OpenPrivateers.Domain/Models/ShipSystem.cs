﻿namespace OpenPrivateers.Domain.Models;

public class ShipSystem : BaseEntity
{
    public string? Name { get; set; }
    public int SystemHealth { get; set; }
    
    public Ship? Ship { get; set; }
    public List<ModuleInstallation>? ModuleInstallations { get; set; }
}