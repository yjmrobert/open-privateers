using System.ComponentModel.DataAnnotations;

namespace OpenPrivateers.API.Models;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}