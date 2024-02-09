using snglrtycrvtureofspce.Core.Base.Infrastructure;

namespace Service.Animals.Web.ViewModels;

public class AnimalViewModel : IEntity
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
    
    public virtual List<UserViewModel> Users { get; set; }
    
    public virtual List<MarkerViewModel> Markers { get; set; }
}