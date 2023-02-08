using System.ComponentModel.DataAnnotations;

namespace OpenPrivateers.Domain.Models;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}