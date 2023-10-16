using animal_service.Models;

namespace animal_service.ViewModels;

public class MarkerViewModelSummary : BaseEntity
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string LocationName { get; set; }
    public virtual List<AnimalViewModelSummary> Animals { get; set; }
}