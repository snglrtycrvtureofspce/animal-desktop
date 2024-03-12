namespace snglrtycrvtureofspce.Animal.Data.Entities;

public class AnimalUserEntity
{
    public Guid AnimalId { get; set; }
    public virtual AnimalEntity Animal { get; set; }
    public Guid UserId { get; set; }
    public virtual UserEntity User { get; set; }
}