namespace Service.Animals.Web.Models;

/// <summary>
/// AnimalUser model
/// </summary>
public class AnimalUserEntity
{
    public Guid AnimalId { get; set; }
    public virtual AnimalEntity Animal { get; set; }
    public Guid UserId { get; set; }
    public virtual UserEntity User { get; set; }
}