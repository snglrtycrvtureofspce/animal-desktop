namespace animal_service.Models;

/// <summary>
/// AnimalUser model
/// </summary>
public class AnimalUserEntity
{
    public Guid AnimalId { get; set; }
    public virtual AnimalEntity AnimalEntity { get; set; }
    public Guid UserId { get; set; }
    public virtual UserEntity UserEntity { get; set; }
}