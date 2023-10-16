using animal_service.Models;

namespace animal_service.ViewModels;

public class AnimalViewModelSummary : BaseEntity
{
    public string Name { get; set; }
    public string PhotoUrl { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string Breed { get; set; }
    public virtual List<UserViewModelSummary> Users { get; set; }
    public virtual List<MarkerViewModelSummary> Markers { get; set; }
}