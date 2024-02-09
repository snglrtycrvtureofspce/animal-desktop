using snglrtycrvtureofspce.Core.Base.Infrastructure;

namespace Service.Animals.Web.ViewModels;

public class MarkerViewModel : IEntity
{
    #region IEntity
    public Guid Id { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime ModificationDate { get; set; }
    #endregion
    
    public double Latitude { get; set; }
    
    public double Longitude { get; set; }
    
    public string LocationName { get; set; }
    
    public virtual List<AnimalViewModel> Animals { get; set; }
}