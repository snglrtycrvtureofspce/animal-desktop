namespace Service.Animals.Web.Models;

/// <summary>
/// Animal Model
/// </summary>
public class AnimalEntity : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Status { get; set; } // "потерян" или "найден"
    public string Breed { get; set; } // порода
    public string PhotoUrl { get; set; }
    public virtual List<UserEntity> Users { get; set; }
    public virtual List<MarkerEntity> Markers { get; set; }
}