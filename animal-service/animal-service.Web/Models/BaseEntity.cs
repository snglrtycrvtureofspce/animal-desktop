using animal_service.Infrastructure;

namespace animal_service.Models;

/// <summary>
/// Base model
/// </summary>
public class BaseEntity : IEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModificationDate { get; set; }
}