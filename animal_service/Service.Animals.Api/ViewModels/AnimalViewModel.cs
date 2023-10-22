using Service.Animals.Api.Infrastructure;

namespace Service.Animals.Api.ViewModels;

/// <summary>
/// ViewModel for the animal
/// </summary>
public class AnimalViewModelSummary : IEntity
{
    #region IEntity
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModificationDate { get; set; }
    #endregion
    public string Name { get; set; }
    public string PhotoUrl { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string Breed { get; set; }
    public virtual List<UserViewModelSummary> Users { get; set; }
    public virtual List<MarkerViewModelSummary> Markers { get; set; }
}