using snglrtycrvtureofspce.Core.Infrastructure;

namespace Service.Animals.Api.ViewModels;

/// <summary>
/// ViewModel for the marker
/// </summary>
public class MarkerViewModelSummary : IEntity
{
    #region IEntity
    public Guid Id { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime ModificationDate { get; set; }
    #endregion
    
    public double Latitude { get; set; }
    
    public double Longitude { get; set; }
    
    public string LocationName { get; set; }
    
    public virtual List<AnimalViewModelSummary> Animals { get; set; }
}