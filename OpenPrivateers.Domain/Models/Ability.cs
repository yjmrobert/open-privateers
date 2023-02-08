namespace OpenPrivateers.Domain.Models;

public class Ability : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
}